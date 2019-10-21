namespace HealthCare.BusinessLayer.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    using Contracts.Interfaces;
    using Contracts.Models.CommonMedicalData;
    using Contracts.Models.MedicalManAccount.Data;
    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;
    using DataLayer;
    using DataLayer.Entities.MedicalData;
    using DataLayer.Entities.MedicalMan;
    using Exceptions;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Helpers;

    public class MedicalManService : IMedicalManService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ISessionResolver _sessionResolver;
        private readonly IMedicalDataService _medicalDataService;

        public MedicalManService(HealthCareDbContext dbContext, IMapper mapper, ISessionResolver sessionResolver, IMedicalDataService medicalDataService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _sessionResolver = sessionResolver;
            _medicalDataService = medicalDataService;
        }

        public async Task<PersistPersonalDataResponse> PersistPersonalData(PersistPersonalDataRequest request)
        {
            var userId = _sessionResolver.SessionInfo.UserId;
            var medicalManInfo = _dbContext.MedicalManInfos.SingleOrDefault(x => x.UserId == userId);

            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => medicalManInfo == null);

            var dbModel = _mapper.Map(request.GeneralDataData, medicalManInfo);
            dbModel.UserId = userId;

            var medicalManInfoId = _dbContext.PersistModel(dbModel, DatabaseOperation.Update);

            PersistAwards(request.Awards.EmptyIfNull(), medicalManInfoId);

            var medicalManCurrentSpecialtiesIds = _dbContext.MedicalManSpecialties
                .Where(x => x.MedManInfoId == medicalManInfoId && x.IsDeleted == false)
                .ToList();

            dbModel.AddSpecialties(request.Specialties.EmptyIfNull(), medicalManCurrentSpecialtiesIds, medicalManInfoId);

            await _dbContext.SaveChangesAsync();

            return new PersistPersonalDataResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<PersistOutpatientCardResponse> PersistOutpatientCard(PersistOutpatientCardRequest request)
        {
            OutpatientCard dbModel;

            if (request.OutpatientCardId != 0)
            {
                dbModel = _dbContext.OutpatientCards.SingleOrDefault(x => x.Id == request.OutpatientCardId);

                ValidationUtils.ValidateAndThrow<DataMismatchException>(() => dbModel == null);
            }
            else
            {
                ValidationUtils.ValidateAndThrow<DataMismatchException>(() => !_dbContext.Users.Any(x => x.Id == request.PatientId));

                dbModel = new OutpatientCard
                {
                    DoctorId = _sessionResolver.SessionInfo.UserId,
                    PatientId = request.PatientId
                };
            }

            var dbOperation = dbModel.Id.GetDbOperation();
            var outpatientCardId = _dbContext.PersistModel(dbModel, dbOperation);

            _medicalDataService.PersistMedicalDataRelatedEntities<AllergyData, Allergy>(request.Allergies.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard, DiseaseType.Allergy);
            _medicalDataService.PersistMedicalDataRelatedEntities<IllnessData, Illness>(request.Illnesses.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard, DiseaseType.Illness);
            _medicalDataService.PersistMedicalTests(request.MedicalTests.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard);

            await _dbContext.SaveChangesAsync();

            return new PersistOutpatientCardResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<SetPricesResponse> SetPrices(SetPricesRequest request)
        {
            var medicalManInfo = _dbContext.MedicalManInfos.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId);
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => medicalManInfo == null);

            foreach (var price in request.Prices)
            {
                var dbModel = _mapper.Map<MedicalManPrice>(price);
                dbModel.MedManInfoId = medicalManInfo.Id;

                var dbOperation = price.Id.GetDbOperation();

                _dbContext.PersistModel(dbModel, dbOperation);
            }

            await _dbContext.SaveChangesAsync();

            return new SetPricesResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        private void PersistAwards(IEnumerable<AwardData> awards, int medicalManInfoId)
        {
            foreach (var award in awards)
            {
                var dbModel = _mapper.Map<Award>(award);
                dbModel.MedManInfoId = medicalManInfoId;

                var dbOperation = dbModel.Id.GetDbOperation();

                _dbContext.PersistModel(dbModel, dbOperation);
            }
        }
    }
}
namespace HealthCare.BusinessLayer.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    using Contracts.Interfaces;
    using Contracts.Models.MedicalManAccount.Data;
    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;
    using Contracts.Models.PatientAccount.Data;
    using DataLayer;
    using DataLayer.Entities.MedicalData;
    using DataLayer.Entities.MedicalMan;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Exceptions;

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
            var medicalMenInfo = _dbContext.MedicalManInfos.SingleOrDefault(x => x.UserId == userId);

            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => medicalMenInfo == null);

            var dbModel = _mapper.Map(request.GeneralDataData, medicalMenInfo);
            dbModel.UserId = userId;

            var medicalMenInfoId = _dbContext.PersistModel(dbModel, DatabaseOperation.Update);

            PersistAwards(request.Awards.EmptyIfNull(), medicalMenInfoId);

            var medicalMenCurrentSpecialtiesIds = _dbContext.MedicalMenSpecialties
                .Where(x => x.MedMenInfoId == medicalMenInfoId && x.IsDeleted == false)
                .ToList();

            dbModel.AddSpecialties(request.Specialties.EmptyIfNull(), medicalMenCurrentSpecialtiesIds, medicalMenInfoId);

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

                ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => dbModel == null);
            }
            else
            {
                ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !_dbContext.Users.Any(x => x.Id == request.PatientId));

                dbModel = new OutpatientCard
                {
                    DoctorId = _sessionResolver.SessionInfo.UserId,
                    PatientId = request.PatientId
                };
            }

            var operation = dbModel.Id.GetDbOperation();
            var outpatientCardId = _dbContext.PersistModel(dbModel, operation);

            _medicalDataService.PersistMedicalDataRelatedEntities<AllergyData, Allergy>(request.Allergies.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard);
            _medicalDataService.PersistMedicalDataRelatedEntities<IllnessData, Illness>(request.Illnesses.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard);
            _medicalDataService.PersistMedicalTests(request.MedicalTests.EmptyIfNull(), outpatientCardId, DocumentType.OutpatientCard);

            await _dbContext.SaveChangesAsync();

            return new PersistOutpatientCardResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        private void PersistAwards(IEnumerable<AwardData> awards, int medicalManInfoId)
        {
            foreach (var dbModel in awards.Select(award => _mapper.Map<Award>(award)))
            {
                dbModel.MedManInfoId = medicalManInfoId;

                var operation = dbModel.Id.GetDbOperation();

                _dbContext.PersistModel(dbModel, operation);
            }
        }
    }
}
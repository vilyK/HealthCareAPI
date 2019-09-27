namespace HealthCare.BusinessLayer.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    using Contracts.Interfaces;
    using Contracts.Models.CommonMedicalData;
    using Contracts.Models.PatientAccount.Data;
    using Contracts.Models.PatientAccount.Requests;
    using Contracts.Models.PatientAccount.Responses;
    using DataLayer;
    using DataLayer.Entities.MedicalData;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Exceptions;

    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly HealthCareDbContext _dbContext;
        private readonly ISessionResolver _sessionResolver;
        private readonly IMedicalDataService _medicalDataService;

        public PatientService(IMapper mapper,
            HealthCareDbContext dbContext,
            ISessionResolver sessionResolver,
            IMedicalDataService medicalDataService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
            _medicalDataService = medicalDataService;
        }

        public async Task<PersistMedicalProfileResponse> PersistMedicalProfile(PersistMedicalProfileRequest request)
        {
            var patientInfoId = PersistPatientPersonalData(request.PatientData);
            var medicalProfileId = PersistMedicalProfileData(request.MedicalData, patientInfoId);

            _medicalDataService.PersistMedicalDataRelatedEntities<AllergyData, Allergy>(request.Allergies.EmptyIfNull(), medicalProfileId, DocumentType.MedicalProfile);
            _medicalDataService.PersistMedicalDataRelatedEntities<IllnessData, Illness>(request.Illnesses.EmptyIfNull(), medicalProfileId, DocumentType.MedicalProfile);
            _medicalDataService.PersistMedicalTests(request.MedicalTests.EmptyIfNull(), medicalProfileId, DocumentType.MedicalProfile);

            await _dbContext.SaveChangesAsync();

            return new PersistMedicalProfileResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        private int PersistPatientPersonalData(PatientGeneralData requestPatientData)
        {
            var patientInfo = _dbContext.PatientInfos
                .SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId);

            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => patientInfo == null);

            var dbModel = _mapper.Map(requestPatientData, patientInfo);
            dbModel.UserId = _sessionResolver.SessionInfo.UserId;

           return _dbContext.PersistModel(dbModel, DatabaseOperation.Update);
        }

        private int PersistMedicalProfileData(MedicalProfileGeneralData data, int patientInfoId)
        {
            var dbModel = _dbContext.MedicalProfiles.SingleOrDefault(x => x.PatientInfoId == patientInfoId) ?? new MedicalProfile();

            dbModel = _mapper.Map(data, dbModel);
            dbModel.PatientInfoId = patientInfoId;

            var operation = dbModel.Id.GetDbOperation();
            var medicalProfileId = _dbContext.PersistModel(dbModel, operation);

            return medicalProfileId;
        }
    }
}
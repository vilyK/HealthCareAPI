namespace HealthCare.BusinessLayer.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Options;

    using Contracts.Configuration;
    using Contracts.Interfaces;
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
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IOptionsSnapshot<CommonSettings> _settings;

        public PatientService(IMapper mapper,
            HealthCareDbContext dbContext,
            ISessionResolver sessionResolver,
            IHostingEnvironment appEnvironment,
            IOptionsSnapshot<CommonSettings> settings)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _sessionResolver = sessionResolver;
            _appEnvironment = appEnvironment;
            _settings = settings;
        }

        public async Task<PersistMedicalProfileResponse> PersistMedicalProfile(PersistMedicalProfileRequest request)
        {
            var patientInfo = _dbContext.PatientInfos
                .SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => patientInfo == null);

            var dbModel = _mapper.Map(request.PatientData, patientInfo);
            dbModel.UserId = _sessionResolver.SessionInfo.UserId;

            var patientInfoId = _dbContext.PersistModel(dbModel, DatabaseOperation.Update);

            var medicalProfileId = PersistMedicalProfileData(request.MedicalData, patientInfoId);

            PersistAllergies(request.Allergies, medicalProfileId);
            //PersistIllnesses(request.Illnesses, medicalProfileId);
            //PersistMedicalTests(request.MedicalTests, medicalProfileId);

            await _dbContext.SaveChangesAsync();

            return new PersistMedicalProfileResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        private int PersistMedicalProfileData(MedicalProfileGeneralData data, int patientInfoId)
        {
            var dbModel = _mapper.Map<MedicalProfile>(data);

            dbModel.PatientInfoId = patientInfoId;

            var operation = dbModel.Id.GetDbOperation();

            var medicalProfileId = _dbContext.PersistModel(dbModel, operation);

            return medicalProfileId;
        }

        private void PersistAllergies(IEnumerable<AllergyData> allergies, int medicalProfileId)
        {
            foreach (var allergy in allergies)
            {
                var dbModel = _mapper.Map<MedicalProfileAllergy>(allergy);

                dbModel.MedicalProfileId = medicalProfileId;
    
                var operation = dbModel.Id.GetDbOperation();

                _dbContext.PersistModel(dbModel, operation);
            }
        }

        private void PersistIllnesses(IEnumerable<IllnessData> illnesses, int medicalProfileId)
        {
            foreach (var illness in illnesses)
            {
                var dbModel = _mapper.Map<MedicalProfileIllness>(illness);

                dbModel.MedicalProfileId = medicalProfileId;

                var operation = dbModel.Id.GetDbOperation();

                _dbContext.PersistModel(dbModel, operation);
            }
        }

        private void PersistMedicalTests(IEnumerable<MedicalTestData> medicalTests, int medicalProfileId)
        {
            foreach (var medicalTest in medicalTests)
            {
                var medTestDbModel = _mapper.Map<MedicalTest>(medicalTest);

                var medicalTestId = _dbContext.PersistModel(medTestDbModel, medTestDbModel.Id.GetDbOperation());

                // check if such combination exists
                var medicalProfileMedicalTests = _dbContext.MedicalProfileMedicalTests
                                      .SingleOrDefault(x => x.MedicalProfileId == medicalProfileId && x.MedicalTestId == medicalTestId) ??
                                  new MedicalProfileMedicalTest
                                  {
                                      MedicalProfileId = medicalProfileId,
                                      MedicalTestId = medicalTestId
                                  };

                _dbContext.PersistModel(medicalProfileMedicalTests, medicalProfileMedicalTests.Id.GetDbOperation());

                foreach (var attachment in medicalTest.MedicalTestAttachments)
                {
                    var attachmentDbModel = _dbContext.MedicalTestAttachments
                                                .SingleOrDefault(x => x.Id == attachment.Id) ?? new MedicalTestAttachment();

                    var image = new FileInfo(attachment.Url);

                    var url = Path.Combine(_appEnvironment.WebRootPath, _settings.Value.MedicalTestAttachmentPath);
                    var imageName = image.Upload(url);

                    attachmentDbModel.Url = Path.Combine(url, imageName);
                    attachmentDbModel.MedicalTestId = medicalTestId;

                    _dbContext.PersistModel(attachmentDbModel, attachmentDbModel.Id.GetDbOperation());
                }
            }
        }
    }
}
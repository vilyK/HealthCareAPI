namespace HealthCare.BusinessLayer.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Options;

    using Contracts.Configuration;
    using Contracts.Interfaces;
    using Contracts.Models.CommonMedicalData;
    using DataLayer;
    using DataLayer.Entities.Base;
    using DataLayer.Entities.MedicalData;
    using Extensions;
    using HealthCare.Interfaces;
    using Interfaces;
    using Utilities.Enums;

    public class MedicalDataService : IMedicalDataService
    {
        private readonly IMapper _mapper;
        private readonly HealthCareDbContext _dbContext;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IOptionsSnapshot<CommonSettings> _settings;

        public MedicalDataService(IMapper mapper,
            HealthCareDbContext dbContext,
            IHostingEnvironment appEnvironment,
            IOptionsSnapshot<CommonSettings> settings)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _appEnvironment = appEnvironment;
            _settings = settings;
        }

        public void PersistMedicalDataRelatedEntities<TMedicalEntity, TModel>(IEnumerable<TMedicalEntity> medicalEntities, int documentId, DocumentType documentType, DiseaseType diseaseType)
                where TMedicalEntity : class, ITreatments
                where TModel : SystemData, IMedicalData
        {
            foreach (var entity in medicalEntities)
            {
                PersistMedicalDataRelatedEntity<TMedicalEntity, TModel>(entity, documentId, documentType, diseaseType);
            }
        }

        public void PersistMedicalDataRelatedEntity<TMedicalEntity, TModel>(TMedicalEntity medicalEntity, int documentId, DocumentType documentType, DiseaseType diseaseType)
            where TMedicalEntity : class, ITreatments
            where TModel : SystemData, IMedicalData
        {
            var dbModel = _mapper.Map<TModel>(medicalEntity);

            switch (documentType)
            {
                case DocumentType.MedicalProfile:
                    dbModel.MedicalProfileId = documentId;
                    break;
                case DocumentType.OutpatientCard:
                    dbModel.OutpatientCardId = documentId;
                    break;
            }

            var dbOperation = dbModel.Id.GetDbOperation();

            var diseaseId = _dbContext.PersistModel(dbModel, dbOperation);

            PersistTreatments(medicalEntity.Treatments, diseaseId, diseaseType);
        }

        public void PersistMedicalTests(IEnumerable<MedicalTestData> medicalTests, int documentId, DocumentType documentType)
        {
            foreach (var medicalTest in medicalTests)
            {
                var medTestDbModel = _mapper.Map<MedicalTest>(medicalTest);

                switch (documentType)
                {
                    case DocumentType.MedicalProfile:
                        medTestDbModel.MedicalProfileId = documentId;
                        break;
                    case DocumentType.OutpatientCard:
                        medTestDbModel.OutpatientCardId = documentId;
                        break;
                }

                var operation = medTestDbModel.Id.GetDbOperation();

                var medicalTestId = _dbContext.PersistModel(medTestDbModel, operation);

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

        private void PersistTreatments(IEnumerable<TreatmentData> treatments, int diseaseId, DiseaseType diseaseType)
        {
            foreach (var treatment in treatments)
            {
                PersistTreatment(treatment, diseaseId, diseaseType);
            }
        }

        private void PersistTreatment(TreatmentData treatment, int diseaseId, DiseaseType diseaseType)
        {
            var dbModel = _mapper.Map<Treatment>(treatment);

            switch (diseaseType)
            {
                case DiseaseType.Illness:
                    dbModel.IllnessId = diseaseId;
                    break;
                case DiseaseType.Allergy:
                    dbModel.AllergyId = diseaseId;
                    break;
            }

            var dbOperation = dbModel.Id.GetDbOperation();
            var treatmentId = _dbContext.PersistModel(dbModel, dbOperation);

            foreach (var medicament in treatment.Medicaments)
            {
                var treatmentMedicamentModel = 
                    _dbContext.TreatmentMedicaments.SingleOrDefault(x => x.TreatmentId == treatmentId && x.MedicamentId == medicament.Id)
                    ?? new TreatmentMedicament
                    {
                        TreatmentId = treatmentId,
                        MedicamentId = medicament.Id
                    };

                treatmentMedicamentModel.Description = medicament.Description;

                var dbOperation_medTreats = treatmentMedicamentModel.Id.GetDbOperation();
                _dbContext.PersistModel(treatmentMedicamentModel, dbOperation_medTreats);
            }
        }
    }
}

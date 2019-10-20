namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Collections.Generic;

    using Contracts.Interfaces;
    using Contracts.Models.CommonMedicalData;
    using DataLayer.Entities.Base;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public interface IMedicalDataService
    {
        void PersistMedicalDataRelatedEntities<TMedicalEntity, TModel>(IEnumerable<TMedicalEntity> medicalEntities,
            int documentId, DocumentType documentType, DiseaseType diseaseType)
            where TMedicalEntity : class, ITreatment
            where TModel : SystemData, IMedicalData;

        void PersistMedicalTests(IEnumerable<MedicalTestData> medicalTests, int documentId, DocumentType documentType);
    }
}

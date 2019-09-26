namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Collections.Generic;
    using Contracts.Models.PatientAccount.Data;
    using DataLayer.Entities.Base;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public interface IMedicalDataService
    {
        void PersistMedicalDataRelatedEntities<TMedicalEntity, TModel>(IEnumerable<TMedicalEntity> medicalEntities, int documentId, DocumentType documentType)
            where TMedicalEntity : class
            where TModel : SystemData, IMedicalData;

        void PersistMedicalTests(IEnumerable<MedicalTestData> medicalTests, int documentId, DocumentType documentType);
    }
}

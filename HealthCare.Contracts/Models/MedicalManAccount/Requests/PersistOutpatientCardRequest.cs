namespace HealthCare.Contracts.Models.MedicalManAccount.Requests
{
    using System.Collections.Generic;

    using PatientAccount.Data;
    using Utilities.Enums;

    public class PersistOutpatientCardRequest
    {
        public int OutpatientCardId { get; set; }

        public int PatientId { get; set; }

        public DocumentStatus Status { get; set; }

        public List<AllergyData> Allergies { get; set; }

        public List<IllnessData> Illnesses { get; set; }

        public List<MedicalTestData> MedicalTests { get; set; }

    }
}

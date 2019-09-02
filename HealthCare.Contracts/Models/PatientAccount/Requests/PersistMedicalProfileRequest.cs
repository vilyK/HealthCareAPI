namespace HealthCare.Contracts.Models.PatientAccount.Requests
{
    using System.Collections.Generic;
    using Data;

    public class PersistMedicalProfileRequest
    {
        public PatientGeneralData PatientData { get; set; }

        public MedicalProfileGeneralData MedicalData { get; set; }

        public List<AllergyData> Allergies { get; set; }

        public List<IllnessData> Illnesses { get; set; }

        public List<MedicalTestData> MedicalTests { get; set; }
    }
}

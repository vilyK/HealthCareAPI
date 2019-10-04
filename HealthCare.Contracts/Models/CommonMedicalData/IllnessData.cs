namespace HealthCare.Contracts.Models.CommonMedicalData
{
    using System.Collections.Generic;
    using Interfaces;
    using Utilities.Enums;

    public class IllnessData : ITreatments
    {
        public int Id { get; set; }

        public int IllnessTypeId { get; set; }

        public IllnessPeriod IllnessPeriod { get; set; }

        public List<TreatmentData> Treatments { get; set; }
    }
}

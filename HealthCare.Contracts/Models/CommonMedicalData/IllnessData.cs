namespace HealthCare.Contracts.Models.CommonMedicalData
{
    using System.Collections.Generic;
    using Utilities.Enums;

    public class IllnessData
    {
        public int Id { get; set; }

        public int IllnessTypeId { get; set; }

        public IllnessPeriod IllnessPeriod { get; set; }

        public List<TreatmentData> Treatments { get; set; }
    }
}

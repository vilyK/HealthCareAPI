namespace HealthCare.Contracts.Models.CommonMedicalData
{
    using System.Collections.Generic;

    public class AllergyData
    {
        public int Id { get; set; }

        public int AllergyTypeId { get; set; }

        public string Notes { get; set; }

        public List<TreatmentData> Treatments { get; set; }
    }
}

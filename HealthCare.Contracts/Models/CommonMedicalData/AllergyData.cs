namespace HealthCare.Contracts.Models.CommonMedicalData
{
    using System.Collections.Generic;
    using Interfaces;

    public class AllergyData : ITreatments
    {
        public int Id { get; set; }

        public int AllergyTypeId { get; set; }

        public string Notes { get; set; }

        public List<TreatmentData> Treatments { get; set; }
    }
}

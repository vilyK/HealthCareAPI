namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;

    using Base;

    public class Treatment : SystemData
    {
        

        public string Description { get; set; }

        public List<IllnessTreatment> IllnessTreatments { get; set; }  = new List<IllnessTreatment>();

        public List<AllergyTreatment> AllergyTreatments { get; set; }  = new List<AllergyTreatment>();

        public List<TreatmentMedicament> TreatmentMedicaments { get; set; }  = new List<TreatmentMedicament>();
    }
}

namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class AllergyTreatment : SystemData
    {
        public int Id { get; set; }

        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }

        public int TreatmentId { get; set; }
        public Treatment Treatment { get; set; }
    }
}

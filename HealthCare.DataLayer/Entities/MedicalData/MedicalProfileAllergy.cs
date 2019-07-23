namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class MedicalProfileAllergy : SystemData
    { 
        public int Id { get; set; }

        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }

        public int MedicalProfileId { get; set; }
        public MedicalProfile MedicalProfile { get; set; }
    }
}

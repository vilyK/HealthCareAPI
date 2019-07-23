namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class OutpatientCardAllergy : SystemData
    {
        public int Id { get; set; }

        public int AllergyId { get; set; }
        public Allergy Allergy { get; set; }

        public int OutpatientCardId { get; set; }
        public OutpatientCard OutpatientCard { get; set; }
    }
}

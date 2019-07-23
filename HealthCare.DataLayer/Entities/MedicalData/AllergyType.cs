namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class AllergyType : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

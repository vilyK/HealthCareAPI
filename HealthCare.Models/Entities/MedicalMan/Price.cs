namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.Collections.Generic;

    using Base;

    public class PriceType : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalManInfoPrice> MedicalMen { get; set; } = new List<MedicalManInfoPrice>();
    }
}

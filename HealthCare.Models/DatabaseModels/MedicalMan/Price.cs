namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using System.Collections.Generic;

    public class Price
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalManInfoPrice> MedMen = new List<MedicalManInfoPrice>();
    }
}

namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System.Collections.Generic;

    public class Price
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedManInfoPrice> MedMen = new List<MedManInfoPrice>();
    }
}

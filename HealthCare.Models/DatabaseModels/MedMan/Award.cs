namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System;

    public class Award
    {
        public int Id { get; set; }

        public int MedManInfoId { get; set; }
        public MedManInfo MedManInfo { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public string AdditionalInfo { get; set; }
    }
}

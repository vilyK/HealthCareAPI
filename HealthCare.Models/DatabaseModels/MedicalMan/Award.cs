namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System;
    using MedicalMan;

    public class Award
    {
        public int Id { get; set; }

        public int MedManInfoId { get; set; }

        public MedicalManInfo MedManInfo { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public string AdditionalInfo { get; set; }
    }
}

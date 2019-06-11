namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using System;

    public class Schedule
    {
        public int Id { get; set; }

        public int MedicalMedId { get; set; }
        public MedicalManInfo MedicalManInfo { get; set; }

        public DateTime Date { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

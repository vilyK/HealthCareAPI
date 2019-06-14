namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Schedule : SystemData
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int MedicalMedId { get; set; }

        [ForeignKey("MedicalMedId")]
        public MedicalManInfo MedicalManInfo { get; set; }

    }
}

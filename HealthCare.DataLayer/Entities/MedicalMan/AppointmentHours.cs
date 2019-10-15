namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Base;
    using Utilities.Enums;

    public class AppointmentHours : SystemData
    {
        public int MedicalMenInfoId { get; set; }

        [ForeignKey("MedicalMenInfoId")]
        public MedicalManInfo MedicalMenInfo { get; set; }

        public DateTime AppointmentHour { get; set; }

        public AppointmentHourStatus AppointmentHourStatus { get; set; }
    }
}

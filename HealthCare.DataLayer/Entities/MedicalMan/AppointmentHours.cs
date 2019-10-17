namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Base;
    using Utilities.Enums;

    public class AppointmentHours : SystemData
    {
        public int MedicalManInfoId { get; set; }

        [ForeignKey("MedicalManInfoId")]
        public MedicalManInfo MedicalManInfo { get; set; }

        public DateTime AppointmentHour { get; set; }

        public AppointmentHourStatus AppointmentHourStatus { get; set; }
    }
}

namespace HealthCare.DataLayer.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Utilities.Enums;

    public class Appointment : SystemData
    {
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        [InverseProperty("PatientAppointments")]
        public User.User Patient { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        [InverseProperty("DoctorAppointments")]
        public User.User Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }

        public AppointmentReason Reason { get; set; }
    }
}

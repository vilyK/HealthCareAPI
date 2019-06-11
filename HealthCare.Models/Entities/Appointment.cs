namespace HealthCare.Models.DatabaseModels.Appointment
{
    using System;
    using Utilities.Enums;

    public class Appointment
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public User.User Patient { get; set; }

        public int DoctorId { get; set; }
        public User.User Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentStatus Status { get; set; }

        public AppointmentReason Reason { get; set; }
    }
}

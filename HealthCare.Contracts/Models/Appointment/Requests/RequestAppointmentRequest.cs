namespace HealthCare.Contracts.Models.Appointment.Requests
{
    using System;
    using Utilities.Enums;

    public class RequestAppointmentRequest
    {
        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public AppointmentReason AppointmentReason { get; set; }
    }
}

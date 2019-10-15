namespace HealthCare.Contracts.Models.Appointment.Requests
{
    using Utilities.Enums;

    public class ChangeAppointmentStatusRequest
    {
        public int Id { get; set; }

        public AppointmentStatus Status { get; set; }
    }
}

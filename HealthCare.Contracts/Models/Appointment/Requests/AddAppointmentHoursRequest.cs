namespace HealthCare.Contracts.Models.Appointment.Requests
{
    using System;
    using System.Collections.Generic;

    public class AddAppointmentHoursRequest
    {
        public List<DateTime>  Hours { get; set; }
    }
}

namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Appointment.Responses;

    public interface IAppointmentService
    {
        Task<RequestAppointmentResponse> RequestAppointment(RequestAppointmentRequest request);

        Task<RequestAppointmentResponse> ChangeAppointmentStatus(ChangeAppointmentStatusRequest request);
    }
}

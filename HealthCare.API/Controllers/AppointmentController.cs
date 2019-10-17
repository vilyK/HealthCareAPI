namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Appointment.Responses;
    using Utilities.Enums;

    [Route("appointment")]
    [ApiController]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient, RoleType.Doctor)]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [Route("request")]
        [HttpPost]
        public async Task<RequestAppointmentResponse> RequestAppointment(RequestAppointmentRequest request)
        {
            return await _appointmentService.RequestAppointment(request);
        }

        [Route("changeStatus")]
        [HttpPost]
        public async Task<RequestAppointmentResponse> ChangeAppointmentStatus(ChangeAppointmentStatusRequest request)
        {
            return await _appointmentService.ChangeAppointmentStatus(request);
        }
    }
}
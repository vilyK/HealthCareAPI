namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Appointment.Responses;
    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Doctor)]
    [Route("medicalMan")]
    public class MedicalManController : ControllerBase
    {
        private readonly IMedicalManService _medicalManService;
        private readonly IAppointmentService _appointmentService;

        public MedicalManController(IMedicalManService medicalManService, IAppointmentService appointmentService)
        {
            _medicalManService = medicalManService;
            _appointmentService = appointmentService;
        }

        [Route("persistData")]
        [HttpPost]
        public async Task<PersistPersonalDataResponse> PersistData(PersistPersonalDataRequest request)
        {
            return await _medicalManService.PersistPersonalData(request);
        }

        [Route("persistOutpatientCard")]
        [HttpPost]
        public async Task<PersistOutpatientCardResponse> PersistOutpatientCard(PersistOutpatientCardRequest request)
        {
            return await _medicalManService.PersistOutpatientCard(request);
        }

        [Route("addAppointmentHours")]
        [HttpPost]
        public async Task<AddAppointmentHoursResponse> AddAppointmentHours(AddAppointmentHoursRequest request)
        {
            return await _appointmentService.AddAppointmentHours(request);
        }

        [Route("setPrices")]
        [HttpPost]
        public async Task<SetPricesResponse> SetPrices(SetPricesRequest request)
        {
            return await _medicalManService.SetPrices(request);
        }
    }
}
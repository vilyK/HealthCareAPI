namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Correspondence.Requests;
    using Contracts.Models.Correspondence.Responses;
    using Microsoft.AspNetCore.Mvc;
    using Utilities.Enums;

    [Route("user")]
    [ApiController]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient, RoleType.Doctor, RoleType.MedicalCenter, RoleType.Pharmacy, RoleType.PharmacyCompany)]
    public class CommunicationController : ControllerBase
    {
        private readonly ICommunicationService _correspondenceService;

        public CommunicationController(ICommunicationService correspondenceService)
        {
            _correspondenceService = correspondenceService;
        }

        [Route("welcomeEmail")]
        [HttpGet]
        public async Task<SendEmailResponse> SendEmail(WelcomeEmailRequest request)
        {
            return await _correspondenceService.SendEmail(request.Message, request.WelcomeViewModel);
        }
    }
}
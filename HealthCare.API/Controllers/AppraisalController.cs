namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Appraisal.Requests;
    using Contracts.Models.Appraisal.Responses;
    using Utilities.Enums;

    [Route("user")]
    [ApiController]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient, RoleType.Doctor, RoleType.MedicalCenter, RoleType.Pharmacy, RoleType.PharmacyCompany)]
    public class AppraisalController : ControllerBase
    {
        private readonly IAppraisalService _appraisalService;

        public AppraisalController(IAppraisalService appraisalService)
        {
            _appraisalService = appraisalService;
        }

        [Route("giveAppraisals")]
        [HttpGet]
        public async Task<SetAppraisalResponse> GiveAppraisals(SetAppraisalRequest request)
        {
            return await _appraisalService.GiveAppraisals(request);
        }
    }
}
namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Behaviour.Filters;
    using Microsoft.AspNetCore.Mvc;

    using BusinessLayer.Interfaces;
    using Contracts.Models.MedicalCenterAccount.Requests;
    using Contracts.Models.MedicalCenterAccount.Responses;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Doctor, RoleType.MedicalCenter)]
    [Route("medicalCenter")]
    public class MedicalCenterController : ControllerBase
    {
        private readonly IMedicalCenterService _medicalCenterService;

        public MedicalCenterController(IMedicalCenterService medicalCenterService)
        {
            _medicalCenterService = medicalCenterService;
        }

        [Route("persistMedicalCenterData")]
        [HttpPost]
        public async Task<PersistMedicalCenterDataResponse> PersistMedicalCenterData(PersistMedicalCenterDataRequest request)
        {
            return await _medicalCenterService.PersistMedicalCenterData(request);
        }
    }
}
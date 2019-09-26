namespace HealthCare.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.PatientAccount.Requests;
    using Contracts.Models.PatientAccount.Responses;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [Route("patient")]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient)]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [Route("persistMedicalProfile")]
        [HttpPost]
        public async Task<PersistMedicalProfileResponse> PersistMedicalProfile(PersistMedicalProfileRequest request)
        {
            return await _patientService.PersistMedicalProfile(request);
        }
    }
}

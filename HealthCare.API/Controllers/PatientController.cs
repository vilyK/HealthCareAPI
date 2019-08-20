namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
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

        //[Route("register")]
        //[HttpPost]
        //public async Task<RegisterUserResponse> Register(RegisterUserRequest request)
        //{
        //    //return await _userService.Register(request);
        //}
    }
}

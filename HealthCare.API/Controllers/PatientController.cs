namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Requests;
    using Contracts.Models.Responses;
    

    [ApiController]
    [ValidationFilter]
    [Route("patient")]
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

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
        private readonly IUserService _userService;

        public PatientController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("register")]
        [HttpPost]
        public async Task<RegisterUserResponse> Register(RegisterUserRequest request)
        {
            return await _userService.RegisterUser(request);
        }
    }
}

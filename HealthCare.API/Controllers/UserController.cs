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
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("login")]
        [HttpGet]
        public async Task<LoginUserResponse> Login(LoginUserRequest request)
        {
            return await _userService.LoginUser(request);
        }

        [Route("register")]
        [HttpPost]
        public async Task<RegisterUserResponse> Register(RegisterUserRequest request)
        {
            return await _userService.RegisterUser(request);
        }

        [Route("addcontact")]
        [HttpPost]
        public async Task<RegisterUserResponse> AddContact(RegisterUserRequest request)
        {
            return await _userService.RegisterUser(request);
        }

        [Route("editdata")]
        [HttpPost]
        public async Task<LoginUserResponse> EditGeneralInfo(LoginUserRequest request)
        {
            return await _userService.LoginUser(request);
        }
    }
}
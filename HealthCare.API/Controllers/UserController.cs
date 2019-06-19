namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Behaviour.Filters;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [ValidationFilter]
    public class UserController : ControllerBase
    {
        [Route("register")]
        [HttpPost]
        public async Task RegisterUser()
        {

        }

        [Route("login")]
        [HttpGet]
        public async Task Login()
        {
            
        }
    }
}
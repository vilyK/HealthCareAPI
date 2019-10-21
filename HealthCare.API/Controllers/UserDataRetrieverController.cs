namespace HealthCare.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using System.Threading.Tasks;
    using BusinessLayer.Interfaces;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    
    [Route("user")]
    [ApiController]
    public class UserDataRetrieverController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserDataRetrieverController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("retrieveDoctors")]
        [HttpGet]
        public async Task<RetrieveDoctorsResponse> RetrieveDoctors(RetrieveDoctorsRequest request)
        {
            return await _userService.RetrieveDoctors(request);
        }

        [Route("retrieveMedicalCenters")]
        [HttpGet]
        public async Task<RetrieveMedicalCentersResponse> RetrieveMedicalCenters(RetrieveMedicalCentersRequest request)
        {
            return await _userService.RetrieveMedicalCenters(request);
        }
    }
}
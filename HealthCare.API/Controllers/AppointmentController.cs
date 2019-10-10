using Microsoft.AspNetCore.Mvc;

namespace HealthCare.API.Controllers
{
    using Behaviour.Filters;
    using Utilities.Enums;

    [Route("appointment")]
    [ApiController]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient, RoleType.Doctor)]
    public class AppointmentController : ControllerBase
    {
    }
}
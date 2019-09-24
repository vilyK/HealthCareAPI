namespace HealthCare.API.Controllers
{
    using Behaviour.Filters;
    using Microsoft.AspNetCore.Mvc;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Pharmacy, RoleType.PharmacyCompany)]
    [Route("pharmacyCompany")]
    public class PharmacyCompanyController : ControllerBase
    {

    }
}
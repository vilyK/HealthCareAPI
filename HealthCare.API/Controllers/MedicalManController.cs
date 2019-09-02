namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Doctor)]
    [Route("medicalMan")]
    public class MedicalManController : ControllerBase
    {
        private readonly IMedicalManService _medicalManService;

        public MedicalManController(IMedicalManService medicalManService)
        {
            _medicalManService = medicalManService;
        }

        [Route("persistData")]
        [HttpPost]
        public async Task<PersistPersonalDataResponse> PersistData(PersistPersonalDataRequest request)
        {
            return await _medicalManService.PersistPersonalData(request);
        }

    }
}
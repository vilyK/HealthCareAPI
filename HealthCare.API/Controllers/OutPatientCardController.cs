namespace HealthCare.API.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Common;
    using Contracts.Models.OutpatientCard.Data;
    using Contracts.Models.OutpatientCard.Responses;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Doctor)]
    [Route("outpatientCard")]
    public class OutPatientCardController : ControllerBase
    {
        private readonly IMedicalManService _medicalManService;
        private readonly IPatientService _patientService;

        public OutPatientCardController(IMedicalManService medicalManService, IPatientService patientService)
        {
            _medicalManService = medicalManService;
            _patientService = patientService;
        }

        [Route("add")]
        [HttpPost]
        public async Task<TokenData> PersistOutpatientCard([ModelBinder(BinderType = typeof(JsonModelBinder))] OutPatientCardInfo request, [FromForm] IList<IFormFile> file)
        {
            return await _medicalManService.AddOutpatientCard(request, file);
        }

        [Route("getAll/{patientId}")]
        [HttpGet]
        public GetOutPatientCardsResponse GetAll(int patientId)
        {
            return _patientService.GetOutPatientCards(patientId);
        }
    }
}

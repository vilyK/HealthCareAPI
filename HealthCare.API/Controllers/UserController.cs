namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
    using Contracts.Models.Appraisal;
    using Contracts.Models.Correspondence.Requests;
    using Contracts.Models.Correspondence.Responses;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using Utilities.Enums;

    [ApiController]
    [ValidationFilter]
    [CustomAuthorizationFilter(RoleType.Admin, RoleType.Patient, RoleType.Doctor, RoleType.MedicalCenter, RoleType.Pharmacy, RoleType.PharmacyCompany)]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ICorrespondenceService _correspondenceService;
        private readonly IAppraisalService _appraisalService;

        public UserController(IUserService userService, ICorrespondenceService correspondenceService, IAppraisalService appraisalService)
        {
            _userService = userService;
            _correspondenceService = correspondenceService;
            _appraisalService = appraisalService;
        }

        [Route("register")]
        [HttpPost]
        [DisableCustomAuthorizationFilter]
        public async Task<RegisterUserResponse> Register(RegisterUserRequest request)
        {
            return await _userService.RegisterUser(request);
        }

        [Route("login")]
        [HttpPost]
        [DisableCustomAuthorizationFilter]
        public async Task<LoginUserResponse> Login(LoginUserRequest request)
        {
            return await _userService.LoginUser(request);
        }

        [Route("editData")]
        [HttpPost]
        public async Task<EditUserGeneraDataResponse> EditGeneralInfo(EditUserGeneraDataRequest request)
        {
            return await _userService.EditGeneralData(request);
        }

        [Route("addContact")]
        [HttpPost]
        public async Task<AddContactResponse> AddContact(AddContactRequest request)
        {
            return await _userService.AddContact(request);
        }

        [Route("uploadImages")]
        [HttpGet]
        [DisableCustomAuthorizationFilter]
        public async Task<UploadImagesResponse> UploadImages(UploadImagesRequest request)
        {
            return await _userService.UploadImages(request);
        }

        [Route("retrieveDoctors")]
        [HttpGet]
        [DisableCustomAuthorizationFilter]
        public async Task<RetrieveDoctorsResponse> RetrieveDoctors(RetrieveDoctorsRequest request)
        {
            return await _userService.RetrieveDoctors(request);
        }

        [Route("retrieveMedicalCenters")]
        [HttpGet]
        [DisableCustomAuthorizationFilter]
        public async Task<RetrieveMedicalCentersResponse> RetrieveMedicalCenters(RetrieveMedicalCentersRequest request)
        {
            return await _userService.RetrieveMedicalCenters(request);
        }

        [Route("sendEmail")]
        [HttpGet]
        public async Task<SendEmailResponse> SendEmail(SendEmailRequest request)
        {
            return await _correspondenceService.SendEmail(request);
        }

        [Route("setAppraisal")]
        [HttpGet]
        public async Task<SetAppraisalResponse> SetAppraisal(SetAppraisalRequest request)
        {
            return await _appraisalService.SetDoctorAppraisals(request);
        }
    }
}
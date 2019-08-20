﻿namespace HealthCare.API.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Behaviour.Filters;
    using BusinessLayer.Interfaces;
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

        public UserController(IUserService userService)
        {
            _userService = userService;
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

        [Route("editdata")]
        [HttpPost]
        public async Task<EditUserGeneraDataResponse> EditGeneralInfo(EditUserGeneraDataRequest request)
        {
            return await _userService.EditGeneralData(request);
        }

        [Route("addcontact")]
        [HttpPost]
        public async Task<AddContactResponse> AddContact(AddContactRequest request)
        {
            return await _userService.AddContact(request);
        }
    }
}
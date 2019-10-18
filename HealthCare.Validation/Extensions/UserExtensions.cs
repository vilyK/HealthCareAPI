namespace HealthCare.Validation.Extensions
{
    using System;
    using System.Collections.Generic;
    using Contracts.Models.UserAccount.Data;
    using Contracts.Models.UserAccount.Requests;
    using FluentValidation;
    using Helpers;
    using Utilities.Enums;

    public static class UserExtensions
    {
        public static IRuleBuilderOptions<T, RegisterUserRequest> VerifyUserName<T>(this IRuleBuilder<T, RegisterUserRequest> ruleBuilder)
        {
            return ruleBuilder.Must(request =>
                    request.GeneralData.Username != null && request.GeneralData.Username.Length > 6 && request.GeneralData.Username.Length < 50)
                .WithMessage("Invalid Username")
                .WithErrorCode("InvalidUsername.");
        }

        public static IRuleBuilderOptions<T, RegisterUserRequest> VerifyPassword<T>(this IRuleBuilder<T, RegisterUserRequest> ruleBuilder)
        {
            return ruleBuilder.Must(request =>
                    request.GeneralData.Password != null && request.GeneralData.Password.Length > 6 && request.GeneralData.Password.Length < 50)
                .WithMessage("Invalid Password")
                .WithErrorCode("InvalidPassword.");
        }
        
        public static IRuleBuilderOptions<T, RegisterUserRequest> VerifyName<T>(this IRuleBuilder<T, RegisterUserRequest> ruleBuilder)
        {
            return ruleBuilder.Must(request =>
                    request.Name != null && request.Name.Length > 4 && request.Name.Length < 50)
                .WithMessage("Invalid name")
                .WithErrorCode("InvalidName");
        }

        public static IRuleBuilderOptions<T, RegisterUserRequest> VerifyUserRole<T>(this IRuleBuilder<T, RegisterUserRequest> ruleBuilder)
        {
            return ruleBuilder.Must(request => Enum.IsDefined(typeof(RoleType), request.UserRole))
                .WithMessage("Invalid user role")
                .WithErrorCode("InvalidUserRole");
        }
        
        public static IRuleBuilderOptions<T, List<EmailData>> VerifyEmails<T>(this IRuleBuilder<T, List<EmailData>> ruleBuilder)
        {
            return ruleBuilder.Must(emails => emails.Count == 0 || emails.IsValidEmail())
                .WithMessage("Request contains one or more invalid emails.")
                .WithErrorCode("InvalidEmail.");
        }

        public static IRuleBuilderOptions<T, List<PhoneData>> VerifyPhoneNumbers<T>(this IRuleBuilder<T, List<PhoneData>> ruleBuilder)
        {
            return ruleBuilder.Must(phones => phones.Count == 0 || phones.IsValidPhoneNumber())
                .WithMessage("Request contains one or more invalid phone numbers.")
                .WithErrorCode("InvalidPhoneNumber");
        }

        public static IRuleBuilderOptions<T, List<AddressData>> VerifyAddresses<T>(this IRuleBuilder<T, List<AddressData>> ruleBuilder)
        {
            return ruleBuilder.Must(addresses => addresses.Count == 0)
                .WithMessage("Request contains one or more invalid addresses")
                .WithErrorCode("InvalidAddress");
        }
    }
}

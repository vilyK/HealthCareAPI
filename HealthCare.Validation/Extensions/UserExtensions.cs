﻿namespace HealthCare.Validation.Extensions
{
    using Contracts.Models.UserAccount.Requests;
    using FluentValidation;

    public static class UserExtensions
    {
        public static IRuleBuilderOptions<T, RegisterUserRequest> HasValidData<T>(this IRuleBuilder<T, RegisterUserRequest> ruleBuilder)
        {
             return ruleBuilder.Must(request => request.GeneralData.Username != null && request.GeneralData.Password != null)
                .WithMessage("Username or password cannot be empty!")
                .WithErrorCode("Invalid Details");
        }
    }
}

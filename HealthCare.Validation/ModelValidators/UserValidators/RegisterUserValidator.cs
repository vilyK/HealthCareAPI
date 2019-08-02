namespace HealthCare.Validation.ModelValidators.UserValidators
{
    using Contracts.Models.Requests;
    using Extensions;
    using FluentValidation;

    public class RegisterUserValidator : BaseValidator<RegisterUserRequest>
    {
        public RegisterUserValidator()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request)
                .HasValidData();

            RuleFor(request => request.GeneralData.Username)
                .Length(1, 30)
                .WithMessage("Username length should be between 1 and 30 characters1")
                .WithErrorCode("Invalid details");
        }
    }
}


namespace HealthCare.Validation.ModelValidators.Example
{
    using Extensions;
    using FluentValidation;
    using Interfaces.Request;

    public class RegisterUserValidator : BaseValidator<RegisterUserRequest>
    {
        public RegisterUserValidator()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request)
                .BaseValidation();
        }
    }
}


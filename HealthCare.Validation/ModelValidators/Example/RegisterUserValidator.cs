namespace HealthCare.Validation.ModelValidators.Example
{
    using FluentValidation;

    using Contracts.Models.Requests;
    using Extensions;
    
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


namespace HealthCare.Validation.ModelValidators.UserValidators
{
    using Contracts.Models.UserAccount.Requests;
    using Extensions;
    using FluentValidation;

    public class RegisterUserValidator : BaseValidator<RegisterUserRequest>
    {
        public RegisterUserValidator()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request)
                .VerifyName()
                .VerifyUserRole()
                .VerifyUserName()
                .VerifyPassword();

            RuleFor(request => request.Contacts.Emails)
                .VerifyEmails();

            RuleFor(request => request.Contacts.Phones)
                .VerifyPhoneNumbers();

            RuleFor(request => request.Contacts.Addresses)
                .VerifyAddresses();
        }
    }
}


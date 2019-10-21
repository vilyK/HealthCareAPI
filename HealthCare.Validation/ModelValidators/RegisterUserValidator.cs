namespace HealthCare.Validation.ModelValidators
{
    using FluentValidation;

    using Contracts.Models.UserAccount.Requests;
    using Extensions;

    public class RegisterUserValidator : BaseValidator<RegisterUserRequest>
    {
        public RegisterUserValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

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


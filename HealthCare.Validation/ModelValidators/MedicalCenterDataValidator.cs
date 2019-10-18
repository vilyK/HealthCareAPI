namespace HealthCare.Validation.ModelValidators
{
    using Contracts.Models.MedicalCenterAccount.Requests;
    using Extensions;
    using FluentValidation;

    public class MedicalCenterDataValidator : BaseValidator<PersistMedicalCenterDataRequest>
    {
        public MedicalCenterDataValidator()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(request => request.Data)
                .VerifyName()
                .VerifyType();
        }
    }
}

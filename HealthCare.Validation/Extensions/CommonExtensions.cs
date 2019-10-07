namespace HealthCare.Validation.Extensions
{
    using FluentValidation;

    using Contracts.Models.Appraisal.Requests;

    public static class AppraisalExtensions
    {
        public static IRuleBuilderOptions<T, SetAppraisalRequest> HasValidAppraisals<T>(this IRuleBuilder<T, SetAppraisalRequest> ruleBuilder)
        {
            return ruleBuilder.Must(appraisals => appraisals.Appraisals.HasValidAppraisal(appraisals.RecipientType))
                .WithMessage("Appraisal types or value are invalid")
                .WithErrorCode("InvalidAppraisals");
        }
    }
}

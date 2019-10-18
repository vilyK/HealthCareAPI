namespace HealthCare.Validation.Extensions
{
    using Contracts.Models.MedicalManAccount.Data;
    using FluentValidation;

    public static class MedicalManExtensions
    {
        public static IRuleBuilderOptions<T, MedicalManGeneralData> VerifyName<T>(this IRuleBuilder<T, MedicalManGeneralData> ruleBuilder)
        {
            return ruleBuilder.Must(center => center.Name.Length > 4 && center.Name.Length < 70)
                .WithMessage("Medical man name is invalid.")
                .WithErrorCode("InvalidName");
        }
    }
}

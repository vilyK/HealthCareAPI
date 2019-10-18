namespace HealthCare.Validation.Extensions
{
    using System;
    using FluentValidation;
   
    using Utilities.Enums;
    using Contracts.Models.MedicalCenterAccount.Data;

    public static class MedicalCenterExtensions
    {
        public static IRuleBuilderOptions<T, MedicalCenterData> VerifyName<T>(this IRuleBuilder<T, MedicalCenterData> ruleBuilder)
        {
            return ruleBuilder.Must(center => center.Name.Length > 4 && center.Name.Length < 70)
                .WithMessage("Medical center name is invalid.")
                .WithErrorCode("InvalidName");
        }

        public static IRuleBuilderOptions<T, MedicalCenterData> VerifyType<T>(this IRuleBuilder<T, MedicalCenterData> ruleBuilder)
        {
            return ruleBuilder.Must(center => Enum.IsDefined(typeof(MedicalCenterType), center.Type))
                .WithMessage("Medical center type is invalid.")
                .WithErrorCode("InvalidType");
        }
    }
}

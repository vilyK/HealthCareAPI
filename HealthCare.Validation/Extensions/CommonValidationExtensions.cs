namespace HealthCare.Validation.Extensions
{
    using FluentValidation;
    using Interfaces;

    public static class CommonValidationExtensions
    {
        public static IRuleBuilderOptions<T, TModel> VerifyName<T, TModel>(this IRuleBuilder<T, TModel> ruleBuilder)
            where TModel : IName
        {
            return ruleBuilder.Must(center => center.Name.Length > 4 && center.Name.Length < 70)
                .WithMessage("Invalid name.")
                .WithErrorCode("InvalidName");
        }
    }
}

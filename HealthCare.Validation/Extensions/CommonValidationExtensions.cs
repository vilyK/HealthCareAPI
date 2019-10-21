namespace HealthCare.Validation.Extensions
{
    using FluentValidation;
   
    using Interfaces;
    using Utilities.Extensions;

    public static class CommonValidationExtensions
    {
        public static IRuleBuilderOptions<T, TModel> VerifyName<T, TModel>(this IRuleBuilder<T, TModel> ruleBuilder)
            where TModel : IName
        {
            return ruleBuilder.Must(request => request.Name.Length.Between(4, 70))
                .WithMessage("Invalid name.")
                .WithErrorCode("InvalidName");
        }
    }
}

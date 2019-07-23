namespace HealthCare.Validation.Extensions
{
    using FluentValidation;

    public static class BaseValidations
    {
        public static IRuleBuilderOptions<T, TElement> BaseValidation<T, TElement>(this IRuleBuilder<T, TElement> ruleBuilder)
        {
            return ruleBuilder
                .Must(user => user == null)
                .WithMessage("Oppss...")
                .WithErrorCode("IncorrectDetails");
        }
    }
}

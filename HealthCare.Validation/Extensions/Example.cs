namespace HealthCare.Validation.Extensions
{
    using System.Collections.Generic;
    using FluentValidation;

    public class Example
    {
        public static IRuleBuilderOptions<T, List<CalculateBetsRequestSelection>> HasValidSelectionsUnderMaxNeeded<T>(this IRuleBuilder<T, List<CalculateBetsRequestSelection>> ruleBuilder)
        {
            return ruleBuilder.Must(selections => selections == null || selections.Count == 0 || selections.Count <= DefaultAllowedSelections)
                .WithMessage($"Maximum amount of selections exceeded. You cannot add more than {DefaultAllowedSelections} selections at once.")
                .WithErrorCode("MaxSelectionsExceeded");
        }
    }
}

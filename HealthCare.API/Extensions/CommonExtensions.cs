namespace HealthCare.API.Extensions
{
    using System.Linq;
    using System.Reflection;
    using Microsoft.AspNetCore.Mvc.Filters;

    public static class CommonExtensions
    {
        private const BindingFlags Flags = BindingFlags.Public | BindingFlags.Instance;

        public static bool IsAttrDisabled<TAttributeType>(this FilterContext context)
        {
            return context.Filters.Any(f => f.GetType() == typeof(TAttributeType));
        }
    }
}
namespace HealthCare.API.Extensions
{
    using System.Linq;
    using System.Reflection;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc.Filters;

    public static class CommonExtensions
    {
        private const BindingFlags Flags = BindingFlags.Public | BindingFlags.Instance;

        public static bool IsAttrDisabled<TAttributeType>(this FilterContext context)
        {
            return context.Filters.Any(f => f.GetType() == typeof(TAttributeType));
        }

        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            var destinationProperties = typeof(TDestination).GetProperties(Flags);

            foreach (var property in destinationProperties)
            {
                if (sourceType.GetProperty(property.Name, Flags) == null)
                {
                    expression.ForMember(property.Name, opt => opt.Ignore());
                }
            }

            return expression;
        }
    }
}
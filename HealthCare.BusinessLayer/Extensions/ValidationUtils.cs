namespace HealthCare.BusinessLayer.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ValidationUtils
    {
        public static void ValidateAndThrow<TException>(Func<bool> condition) 
            where TException : Exception, new()
        {
            if (condition.Invoke())
                throw new TException();
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return value.GetType().GetProperties()
                .All(p => p.GetValue(value) == null);
        }

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> enumerable) => enumerable ?? Enumerable.Empty<T>();
    }
}

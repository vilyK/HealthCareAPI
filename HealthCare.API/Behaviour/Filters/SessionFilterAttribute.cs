namespace HealthCare.API.Behaviour.Filters
{
    using System.Net;
    using Contracts.Interfaces;
    using Extensions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    using Utilities.Enums;

    public class SessionFilterAttribute : TypeFilterAttribute
    {
        public SessionFilterAttribute() : base(typeof(SessionFilterCustomAttribute)) { }

        private class SessionFilterCustomAttribute : IAuthorizationFilter
        {
            private ISessionResolver SessionResolver { get; }

            public SessionFilterCustomAttribute(ISessionResolver sessionResolver)
            {
                SessionResolver = sessionResolver;
            }

            public void OnAuthorization(AuthorizationFilterContext context)
            {
                if (context.IsAttrDisabled<DisableSessionFilterAttribute>())
                    return;

                var result = SessionResolver.RetrieveSessionInfo(context.HttpContext.Request);

                if (result.ResponseStatus == ResponseStatus.Success)
                    return;

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new ObjectResult(result);
            }
        }
    }

    public class DisableSessionFilterAttribute : ActionFilterAttribute { }
}
namespace HealthCare.API.Behaviour.Filters
{
    using System.Net;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var response = new ErrorResponse
            {
                Exception = exception,
                Description = context.Exception.Message   
           };

            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Result = new ObjectResult(response);

            context.ExceptionHandled = true;
        }
    }
}

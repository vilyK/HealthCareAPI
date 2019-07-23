namespace HealthCare.API.Behaviour.Filters
{
    using System.Linq;
    using System.Net;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class ValidationFilter : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);

            var model = context.ModelState;
            if (model.IsValid)
                return;

            var errorCode = model.Keys.FirstOrDefault()?.Replace("PredicateValidator", "");
            errorCode = errorCode != "" ? errorCode : "ValidationError";

            var message = model.Values
                .SelectMany(m => m.Errors)
                .Select(e => e.ErrorMessage)
                .FirstOrDefault();

            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Result = new ObjectResult(new ErrorResponse { StatusCode = errorCode, Description = message });
        }
    }
}

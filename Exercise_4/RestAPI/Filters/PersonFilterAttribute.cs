using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace RestAPI.Filters
{
    public class PersonFilterAttribute : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ActionArguments.ContainsKey("personId"))
            {
                var personId = (int)context.ActionArguments["personId"];
                if (personId % 2 == 0)
                {
                    context.Result = new BadRequestObjectResult("Een even ID mag niet.");
                }
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}

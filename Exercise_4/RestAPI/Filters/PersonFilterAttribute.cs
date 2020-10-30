using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace RestAPI.Filters
{
    public class PersonFilterAttribute : ActionFilterAttribute
    {
        private readonly int Modulo = 2;

        public PersonFilterAttribute(IConfiguration configuration)
        {
            Modulo = configuration.GetValue<int>("PersonFilter:Modulo");
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.ActionArguments.ContainsKey("personId"))
            {
                var personId = (int)context.ActionArguments["personId"];
                if (personId % Modulo == 0)
                {
                    context.Result = new BadRequestObjectResult($"Een ID dat deelbaar is door {Modulo} mag niet.");
                }
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;

namespace Starter.Filters
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Action Executing");

           
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Action Executed");
        }
    }
}

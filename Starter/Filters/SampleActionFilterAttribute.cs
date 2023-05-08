using Microsoft.AspNetCore.Mvc.Filters;

namespace Starter.Filters
{
    public class SampleActionFilterAttribute :Attribute, IActionFilter
    {

        private readonly string _name;
        public SampleActionFilterAttribute(string name)
        {
            _name = name;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Action Executing");

            //var stringArgs = context.ActionArguments.Where(pair => pair.Value is string).ToList();

            //foreach (var keyValue in stringArgs)
            //{
            //    var safeValue = ((string)keyValue.Value).Replace("kvp", "kovilpatti");
            //    context.ActionArguments[keyValue.Key] = safeValue;
            //}
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Action Executed");
        }
    }
}

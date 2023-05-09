using Microsoft.AspNetCore.Mvc.Filters;

namespace Starter.Filters
{
    public class ResultEx : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("On Result Executed");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("On Result Executing");
        }
    }
}

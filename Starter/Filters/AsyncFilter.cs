using Microsoft.AspNetCore.Mvc.Filters;

namespace Starter.Filters
{
    public class AsyncFilter : Attribute, IAsyncActionFilter
    {
        public readonly string _name;
        public AsyncFilter(string name)
        {
            _name = name;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Action Filter Before Executing {_name}");
            /// <summary>
            /// Write you Own Logics Big Implementation
            /// </summary>
            /// <returns></returns>
            await next();
            Console.WriteLine($"Action Filter  After Executed {_name}");
        }
       
        //public async void TestMethod()
        //{
        //    ///100 line
        //    //
        //    await;
        //}

        //public void FilterFirst()
        //{
        //    //100 Line 
        //    await TestMethod2(); //>> Thread 
        //    //10 line 
        //}

        //public async void TestMethod2()
        //{
        //    //100 line
        //}
    }
}

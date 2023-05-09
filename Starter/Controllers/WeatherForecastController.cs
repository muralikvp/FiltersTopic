using Microsoft.AspNetCore.Mvc;
using Starter.Filters;

namespace Starter.Controllers
{
    [ApiController]
    [Route("HopeTutors/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

      //  [ResultEx]
       // [TypeFilter(typeof(ResourceEx), Arguments = new object[] { "Result" })]
      //  [AsyncFilter("DisplayTraining")]
        //[HttpGet("Display")]
        [HttpGet]
        [Route("Display")]
        public string DisplayTraining()
        {
            return "Dotnet Core Training";
        }

        [SampleActionFilterAttribute("MessageGet")]
        [HttpGet]
        [Route("GetMessage")]
        public string GetMessage(string Training, string Institute="Hope Tutors")
        {
            return Institute +" : " + Training;
        }

        [SampleActionFilterAttribute("MessagePost")]
        [HttpPost]
        [Route("PostWeather")]
        public int PostWeather(WeatherForecast weather)
        {
            return weather.TemperatureF; 
        }

    }
}
using Microsoft.AspNetCore.Mvc;

namespace Starter.Controllers
{
    [ApiController]
    [Route("HopeTutors/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        //[HttpGet("Display")]
        [HttpGet]
        [Route("Display")]
        public string DisplayTraining()
        {
            return "Dotnet Core Training";
        }

        //[HttpGet("Display")]
        [HttpGet]
        [Route("GetMessage")]
        public string GetMessage(string Training, string Institute="Hope Tutors")
        {
            return Institute +" : " + Training;
        }

        [HttpPost]
        [Route("PostWeather")]
        public int PostWeather(WeatherForecast weather)
        {
            return weather.TemperatureF; 
        }

    }
}
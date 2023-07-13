using Microsoft.AspNetCore.Mvc;

namespace ButonStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public string GetName()
        {
            return "Bhuvanesh";
        }
    }
}
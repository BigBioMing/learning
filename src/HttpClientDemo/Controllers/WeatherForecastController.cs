using HttpClientDemo.HttpExtensions;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Type1([FromServices] IMyCustomTypeHttpClient myCustomTypeHttpClient)
        {
            string result = await myCustomTypeHttpClient.GetAsync();
            return Ok(result);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Type2([FromServices] IMyCustomTypeHttpClient2 myCustomTypeHttpClient)
        {
            string result = await myCustomTypeHttpClient.GetAsync();
            return Ok(result);
        }
    }
}
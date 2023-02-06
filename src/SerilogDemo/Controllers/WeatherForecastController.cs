using Microsoft.AspNetCore.Mvc;

namespace SerilogDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
            _logger.LogError("请求进入-1");
            _logger.LogDebug("请求进入0");
            _logger.LogInformation("请求进入1");
            _logger.LogInformation("请求进入2");
            Serilog.Log.Information("请求进入3");
            Serilog.Log.Information("请求进入4");
            Serilog.Log.Debug("请求进入5");
            Serilog.Log.Error("请求进入6");
            Serilog.Log.Fatal("请求进入7");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
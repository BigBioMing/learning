using CapDemo.Entities;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace CapDemo.Controllers
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
        private readonly CapDbContext _dbContext;
        private readonly ICapPublisher _capPublisher;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CapDbContext dbContext, ICapPublisher capPublisher)
        {
            _logger = logger;
            _dbContext = dbContext;
            _capPublisher = capPublisher;
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

        [HttpPost(Name = "createOrder")]
        public async Task<IActionResult> CreateOrder()
        {
            var order = new Order()
            {
                Name = "ÕÅÈý"
            };

            await _dbContext.AddAsync(order);
            await _dbContext.SaveChangesAsync();

            await _capPublisher.PublishAsync("capdemo.services.order.orderCreated", new { OrderId = order.Id });

            return Ok(order);
        }
    }
}
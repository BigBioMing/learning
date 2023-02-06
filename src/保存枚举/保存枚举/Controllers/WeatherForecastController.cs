using Microsoft.AspNetCore.Mvc;
using 保存枚举.Databases;
using 保存枚举.Entities;

namespace 保存枚举.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        protected readonly SaveEnumContext _dbContext;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SaveEnumContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var addresses = _dbContext.Addresses.ToList();
            return Ok(addresses);
        }

        [HttpPost(Name = "Save")]
        public IActionResult Post()
        {
            Address address = new Address()
            {
                AddressType = Enums.AddressType.SpiritualWorld,
                DeliveryPreference = Enums.DeliveryPreference.B,
                DetailAddress = "灵界张家屯"
            };

            //dbContext.Add(address);
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();

            return Ok("success -- 0");
        }
    }
}
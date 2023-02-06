using MediatR;
using Microsoft.AspNetCore.Mvc;
using 领域事件01.Databases;
using 领域事件01.Entities;
using 领域事件01.Notifications;

namespace 领域事件01.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DomainEventContext _dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator, DomainEventContext dbContext)
        {
            _logger = logger;
            _mediator = mediator;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _mediator.Publish(new MessageNotification() { Message = $"获取数据 {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}" });
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create()
        {
            var userInfo = new UserInfo("张三", "123456");
            _dbContext.Add(userInfo);
            await _dbContext.SaveChangesAsync();
            return Ok("success -- 0");
        }

        [HttpPost("ModifyPassword")]
        public async Task<IActionResult> ModifyPassword(int? id = null)
        {
            id = id ?? 1;
            var userInfo = _dbContext.UserInfos.OrderByDescending(n => n.Id).FirstOrDefault(n => n.Id == id);
            userInfo.ModifyPassword("888888");
            await _dbContext.SaveChangesAsync();
            return Ok("success -- 0");
        }
    }
}
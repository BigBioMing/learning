using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mobile.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            var result = await Task.FromResult(new { Content = "我是Mobile.Api服务", });
            return Ok(result);
        }
    }
}

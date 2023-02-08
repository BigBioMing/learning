using Microsoft.AspNetCore.Mvc;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            var result = await Task.FromResult(new { Content = "我是User.Api服务", });
            return Ok(result);
        }
    }
}

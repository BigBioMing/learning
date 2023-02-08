using Microsoft.AspNetCore.Mvc;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetUser(string userName)
        {
            var result = await Task.FromResult(new { Id = Random.Shared.Next(1000, 100000), UserName = userName, Type = "User" });
            return Ok(result);
        }
    }
}

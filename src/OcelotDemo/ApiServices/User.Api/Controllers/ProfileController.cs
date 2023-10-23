using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        [Route("info")]
        public IActionResult Info()
        {
            return Ok("我是user.api");
        }
    }
}

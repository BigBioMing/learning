using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mobile.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        [Route("info")]
        public IActionResult Info()
        {
            return Ok("我是mobile.api");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGategay_OcelotDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        [Route("info")]
        public IActionResult Info()
        {
            return Ok("我是ApiGategay_OcelotDemo01");
        }
    }
}

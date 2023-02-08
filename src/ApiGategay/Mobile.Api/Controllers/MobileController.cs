using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mobile.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        [HttpGet]
        public virtual async Task<IActionResult> Get(string phone)
        {
            var result = await Task.FromResult(new { Id = Random.Shared.Next(1000, 100000), Phone = phone, Type = "Mobile" });
            return Ok(result);
        }
    }
}

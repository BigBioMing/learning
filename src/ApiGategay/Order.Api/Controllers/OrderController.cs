using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public virtual async Task<IActionResult> Get(string orderCode)
        {
            var result = await Task.FromResult(new { Id = Random.Shared.Next(1000, 100000), OrderCode = orderCode, Type = "Order" });
            return Ok(result);
        }
    }
}

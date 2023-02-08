using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mobile.Aggregate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        protected readonly ITypeOrderHttpClient _httpClient;
        public OrderController(ITypeOrderHttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        [HttpGet("getorder")]
        public virtual async Task<IActionResult> GetOrder(string orderCode)
        {
            var result = await _httpClient.GetOrder(orderCode);
            return Ok(result);
        }
    }
}

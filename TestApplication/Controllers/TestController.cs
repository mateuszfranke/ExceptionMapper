using Microsoft.AspNetCore.Mvc;
using TestApplication.Exceptions;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("call1")]
        public IActionResult Call1()
        {
            return new OkResult();
        }
        
        [HttpGet("call2")]
        public IActionResult Call2()
        {
            throw new UnluckyException("unlucky man");
        }
    }
}
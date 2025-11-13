using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string SayHelloAPI()
        {
            return "hello world api";
        }
    }
}

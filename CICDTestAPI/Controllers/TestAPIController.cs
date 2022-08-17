using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CICDTestAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        [HttpGet(Name = "HelloWorld")]
        public ActionResult<String> HelloWorld()
        {
            return "Hello World";
        }
    }
}

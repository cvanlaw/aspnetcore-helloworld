using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorld : Controller
    {
        // GET api/helloworld
        [HttpGet]
        public IActionResult Get()
        {
            var result = new
            {
                Data = new
                {
                    Message = "Hello, World!"
                }
            };

            return this.Json(result);
        }
    }
}
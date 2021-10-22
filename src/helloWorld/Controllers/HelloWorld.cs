using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorld : Controller
    {
        // GET api/helloworld
        [HttpGet]
        public IActionResult Get(string name = null)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                name = "World";
            }
            
            var result = new
            {
                Data = new
                {
                    Message = $"Hello, {name}!"
                }
            };

            return this.Json(result);
        }
    }
}
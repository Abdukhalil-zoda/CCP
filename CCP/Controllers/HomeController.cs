using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CCP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Main()
        {
            return File(System.IO.File.Open(Path.Combine("Assets", "index.html"), FileMode.Open), "text/html");
        }

        [HttpPost("/login.php")]
        public IActionResult Login(login login)
        {
            var body = HttpContext.Request.Body;
            return Ok(@"inp n
out n");
        }
        
    }
}

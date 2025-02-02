using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]


    [Route("api/q2")]
    public class Q2Controller : ControllerBase
    {
        
       // Q2
        [HttpGet("q2/greeting")]
        public IActionResult Greeting(string name)
        {
            return Ok($"Hi {name}!");
        }
    }

}

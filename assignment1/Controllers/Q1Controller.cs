using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q1")]
    public class Q1Controller : ControllerBase
    {
        
        // Q1
        /// <welcome message>
        [HttpGet("q1/welcome")]
        public IActionResult Welcome()
        {
            return Ok("Welcome to 5125!");
        }
    }

}
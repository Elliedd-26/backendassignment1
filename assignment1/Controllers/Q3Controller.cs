using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q3")]
    public class Q3Controller : ControllerBase
    {
        
       // Q3
        /// <summary>
        [HttpGet("q3/cube/{number}")]
        public IActionResult Cube(int number)
        {
            return Ok(number * number * number);
        }
    }

}

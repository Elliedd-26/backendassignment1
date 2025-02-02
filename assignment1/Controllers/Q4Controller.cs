using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q4")]
    public class Q4Controller : ControllerBase
    {
        
      // Q4
        /// <summary>
        /// Returns the start of a knock knock joke.
        /// </summary>
        /// <returns>Start of the joke</returns>
        /// <example>POST api/q4/knockknock</example>
        [HttpPost("q4/knockknock")]
        public IActionResult KnockKnock()
        {
            return Ok("Who’s there?");
        }
    }

}

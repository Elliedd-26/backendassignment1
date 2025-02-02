using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q5")]
    public class Q5Controller : ControllerBase
    {
        
     // Q5
        [HttpPost("q5/secret")]
        public IActionResult Secret([FromBody] int secret)
        {
            return Ok($"Shh.. the secret is {secret}");
        }
    }

}
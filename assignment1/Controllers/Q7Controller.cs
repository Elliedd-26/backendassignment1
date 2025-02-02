using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q7")]
    public class Q7Controller : ControllerBase
    {
        
      // Q7
        [HttpGet("q7/timemachine")]
        public IActionResult TimeMachine(int days)
        {
            DateTime currentDate = DateTime.Today;
            DateTime adjustedDate = currentDate.AddDays(days);
            return Ok(adjustedDate.ToString("yyyy-MM-dd"));
        }
    }

}
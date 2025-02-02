using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q6")]
    public class Q6Controller : ControllerBase
    {
        // Q6

        [HttpGet("q6/hexagon")]
        public IActionResult Hexagon(double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return Ok(area);
        }
      
    }

}
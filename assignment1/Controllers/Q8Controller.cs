using Microsoft.AspNetCore.Mvc;

namespace asign1installtry.Controllers
{
    [ApiController]

    [Route("api/q8")]
    public class Q8Controller : ControllerBase
    {
        
      // Q8
        [HttpPost("q8/squashfellows")]
        public IActionResult SquashFellows([FromForm] int small, [FromForm] int large)
        {
            double smallPrice = 25.50;
            double largePrice = 40.50;
            double subtotal = (small * smallPrice) + (large * largePrice);
            double tax = subtotal * 0.13;
            double total = subtotal + tax;

            string summary = $"{small} Small @ ${smallPrice} = ${small * smallPrice}; " +
                             $"{large} Large @ ${largePrice} = ${large * largePrice}; " +
                             $"Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";
            return Ok(summary);
        }
    }

}
using Microsoft.AspNetCore.Mvc;

namespace week2installtry.Controllers
{
    [ApiController]
    [Route("[controller]")] // 路由前缀为 "ExampleController"
    public class ExampleController : ControllerBase
    {
        // GET: ExampleController/Get1
        [HttpGet(template: "Get1")]
        public string Get1()
        {
            return "Routing 1";
        }

        // GET: ExampleController/Get2
        [HttpGet(template: "Get2")]
        public string Get2()
        {
            return "Routing 2";
        }
    }
}

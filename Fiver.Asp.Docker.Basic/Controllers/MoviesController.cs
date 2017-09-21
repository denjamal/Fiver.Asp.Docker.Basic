using Microsoft.AspNetCore.Mvc;

namespace Fiver.Asp.Docker.Basic.Controllers
{
    [Route("api/movies")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from inside Docker!!!");
        }
    }
}

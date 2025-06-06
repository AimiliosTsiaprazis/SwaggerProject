using Microsoft.AspNetCore.Mvc;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTime()
        {
            return Ok(new
            {
                DateInfo = DateTime.Now,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Time = DateTime.Now.TimeOfDay
            });
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new
            {
                Admin = "Aimilios Tsiaprazis",
                User1 = "Max Mustermann",
                Testing = "TestUser"
            });
        }
    }
}
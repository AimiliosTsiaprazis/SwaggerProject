using Microsoft.AspNetCore.Mvc;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]   
        public IActionResult GetHealth()
        {
            return Ok(new
            {
                status = "Swagger-Project-Healthy",
                timestamp = DateTime.Now,
                Version = "1.0.0",
                Environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"),
                MemoryUsage = GC.GetTotalMemory(false),
                MachineName = Environment.MachineName,
                ProcessorCount=Environment.ProcessorCount}
            );
        }
    }
}
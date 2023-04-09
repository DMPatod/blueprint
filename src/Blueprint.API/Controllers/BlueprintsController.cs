using Microsoft.AspNetCore.Mvc;

namespace Blueprint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlueprintsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Blueprint Controller");
        }
    }
}

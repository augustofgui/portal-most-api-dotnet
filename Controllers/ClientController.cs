using Microsoft.AspNetCore.Mvc;

namespace PortalMost_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {   
        [HttpGet]
        public IActionResult Get()
        { 
            return Ok("Bao dms");
        }
    }
}

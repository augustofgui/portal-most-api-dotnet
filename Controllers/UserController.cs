using System;
using Microsoft.AspNetCore.Mvc;

namespace PortalMost_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                throw new Exception("Testando");
            }
            catch (Exception ex)
            {
                
                return BadRequest($"Erro: {ex.Message}");
            }
        }   
    }
}

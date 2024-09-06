using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        PassKeyVerifier _passKeyVerifier;
        public AdminController(PassKeyVerifier passKeyVerifier)
        {
            _passKeyVerifier = passKeyVerifier;
        }


        [HttpGet("{adminPassKey}")]
        public async Task<IActionResult> GetAdmin(string? adminPassKey)
        {
            if (!_passKeyVerifier.RequestIsAdmin(HttpContext)) { return Unauthorized(); }
            return Ok("You are an admin");
        }
    }
}

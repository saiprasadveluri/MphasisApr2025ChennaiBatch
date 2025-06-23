using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            if (login.Email == "admin@example.com" && login.Password == "password")
            {
                return Ok(new { Token = "dummy-jwt-token" });
            }
            return Unauthorized("Invalid credentials");
        }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}

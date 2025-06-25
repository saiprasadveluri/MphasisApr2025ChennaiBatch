using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using RideAggregatorApi.Models.DTO;



namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly RideDbContext _context;

        public AccountController(RideDbContext context)
        {
            _context = context;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            // Try Customer login first
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == login.Email && u.Password == login.Password);

            if (user != null)
            {
                return Ok(new AuthResponse
                {
                    Id = user.Id,
                    Role = user.Role,
                    Token = Guid.NewGuid().ToString() // Replace with real token in production
                });
            }

            // Try Driver login
            var driver = await _context.Drivers
                .FirstOrDefaultAsync(d => d.Email == login.Email && d.Password == login.Password);

            if (driver != null)
            {
                return Ok(new AuthResponse
                {
                    Id = driver.Id,
                    Role = "Driver",
                    Token = Guid.NewGuid().ToString()
                });
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

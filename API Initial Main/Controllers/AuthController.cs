using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly OPADBContext _context;

        public AuthController(OPADBContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == loginDto.Email && u.Password == loginDto.Password);

            if (user == null)
                return Unauthorized("Invalid email or password.");

            if (!user.IsAdmin)
                return Forbid("Access denied. Admins only.");

            return Ok(new
            {
                Message = "Login successful.",
                User = new
                {
                    user.UserId,
                    user.UserName,
                    user.Email,
                    user.IsAdmin
                }
            });
        }
    }
}

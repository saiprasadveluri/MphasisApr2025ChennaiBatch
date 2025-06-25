namespace RideAggregator.API.Controllers
using global::RideAggregator.core.Entities;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;
using System.Security.Cryptography;
using System.Text;
namespace RideAggregator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public AccountController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            var user = (await _userRepo.GetAllAsync())
                .FirstOrDefault(u => u.Email == login.Email);

            if (user == null || user.PasswordHash != ComputeSha256Hash(login.Password))
                return Unauthorized("Invalid credentials");

            return Ok(new { message = "Login successful", user.Email, user.Role });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            if ((await _userRepo.GetAllAsync()).Any(u => u.Email == model.Email))
                return BadRequest("Email already exists");

            var user = new User
            {
                Email = model.Email,
                PasswordHash = ComputeSha256Hash(model.Password),
                Role = "User"
            };

            await _userRepo.AddAsync(user);
            await _userRepo.SaveAsync();
            return Ok(new { message = "User registered successfully" });
        }

        private string ComputeSha256Hash(string raw)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
            return Convert.ToHexString(bytes);
        }
    }

    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class RegisterDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
} }
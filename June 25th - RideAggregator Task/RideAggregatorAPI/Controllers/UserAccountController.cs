using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/UserAccount")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly RideDbContext _context;

        public UserAccountController(RideDbContext context)
        {
            _context = context;
        }

        [HttpPost("Register")]
        public IActionResult Register(UserAccount user)
        {
            var existing = _context.UserAccounts.Find(user.Email);
            if (existing != null)
                return BadRequest("User already exists");

            _context.UserAccounts.Add(user);
            _context.SaveChanges();

            return Ok("User registered successfully");
        }

        [HttpPost("Login")]
        public IActionResult Login(UserAccount user)
        {
            var account = _context.UserAccounts
                .FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (account == null)
                return Unauthorized("Invalid email or password");

            return Ok("Login successful");
        }
    }
}

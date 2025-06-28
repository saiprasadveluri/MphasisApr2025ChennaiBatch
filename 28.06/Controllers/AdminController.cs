using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(AdminDTO dto)
            => Ok(await _service.RegisterAsync(dto));

        [HttpPost("login")]
        public async Task<IActionResult> Login(AdminDTO dto)
            => Ok(await _service.LoginAsync(dto));
    }
}

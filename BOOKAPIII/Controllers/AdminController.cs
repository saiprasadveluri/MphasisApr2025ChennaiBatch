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


        [HttpDelete("{adminId}")]
        public async Task<IActionResult> Delete(int adminId)
        {
            var deleted = await _service.DeleteAsync(adminId);
            return deleted ? NoContent() : NotFound();
        }
        [HttpPut("{adminId}")]
        public async Task<IActionResult> Update(int adminId, AdminDTO dto)
        {
            var updated = await _service.UpdateAsync(adminId, dto);
            return updated != null ? Ok(updated) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
    => Ok(await _service.GetAllAsync());


    }
}

using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _service;

        public TicketController(ITicketService service)
        {
            _service = service;
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
            => Ok(await _service.GetByUserIdAsync(userId));

        [HttpPost]
        public async Task<IActionResult> Create(TicketDTO dto)
            => Ok(await _service.CreateAsync(dto));
    }
}

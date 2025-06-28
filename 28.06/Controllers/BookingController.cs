using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Book(BookingDTO dto)
            => Ok(await _service.CreateAsync(dto));

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
            => Ok(await _service.GetByUserIdAsync(userId));

        [HttpPut("{id}/cancel")]
        public async Task<IActionResult> Cancel(int id)
        {
            await _service.CancelAsync(id);
            return NoContent();
        }

        [HttpPut("{id}/reschedule")]
        public async Task<IActionResult> Reschedule(int id, [FromBody] RescheduleDTO dto)
        {
            await _service.RescheduleAsync(id, dto.NewDate, dto.NewTime);
            return NoContent();
        }
    }
}

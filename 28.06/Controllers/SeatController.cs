using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _service;

        public SeatController(ISeatService service)
        {
            _service = service;
        }

        [HttpGet("theatre/{theatreId}")]
        public async Task<IActionResult> GetByTheatre(int theatreId)
            => Ok(await _service.GetByTheatreIdAsync(theatreId));

        [HttpPut("{seatId}/status")]
        public async Task<IActionResult> UpdateStatus(int seatId, [FromBody] string status)
        {
            await _service.UpdateSeatStatusAsync(seatId, status);
            return NoContent();
        }
    }
}

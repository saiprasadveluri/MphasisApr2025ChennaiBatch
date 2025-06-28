using Book.DTO;
using Book.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;



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
        [HttpPost]
        public async Task<IActionResult> CreateSeat([FromBody] SeatDTO seat)
        {
            var createdSeat = await _service.CreateAsync(seat);
            return CreatedAtAction(nameof(GetByTheatre), new { theatreId = createdSeat.TheatreId }, createdSeat);
        }
        [HttpDelete("{seatId}")]
        public async Task<IActionResult> Delete(int seatId)
        {
            await _service.DeleteAsync(seatId);
            return NoContent();
        }
    }
}

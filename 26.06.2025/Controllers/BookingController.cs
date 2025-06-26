using Microsoft.AspNetCore.Mvc;
using BookMyShowAPI.Interfaces;
using BookMyShowAPI.DTO;

namespace BookMyShowAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("book")]
        public async Task<IActionResult> Book(BookingRequestDto dto) =>
            Ok(await _bookingService.BookAsync(dto));

        [HttpPost("cancel/{id}")]
        public async Task<IActionResult> Cancel(int id) =>
            Ok(await _bookingService.CancelAsync(id));

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserBookings(int userId) =>
            Ok(await _bookingService.GetByUserAsync(userId));
    }
}
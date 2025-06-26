using BookMyShowAPI.DTO;
using BookMyShowAPI.Interfaces;
using BookMyShowApp.Models;
using BookMyShowAPI.Repository.Interfaces;
using BookMyShowAPI.Interfaces;
using BookMyShowAPI.Helper;

namespace BookMyShowAPI.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repo;

        public BookingService(IBookingRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult> BookAsync(BookingRequestDto dto)
        {
            var booking = new Booking
            {
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                TheatreId = dto.TheatreId,
                ShowTime = dto.ShowTime,
                Status = "Confirmed"
            };

            await _repo.AddAsync(booking);
            return ServiceResult.Success("Ticket booked");
        }

        public async Task<ServiceResult> CancelAsync(int id)
        {
            var result = await _repo.CancelBookingAsync(id);
            return result ? ServiceResult.Success("Canceled") : ServiceResult.Failure("Cancel failed");
        }

        public async Task<IEnumerable<Booking>> GetByUserAsync(int userId) =>
            await _repo.GetByUserIdAsync(userId);
    }
}

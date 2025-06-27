using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IBookingService
    {
        Task<BookingDTO> CreateAsync(BookingDTO dto);
        Task<IEnumerable<BookingDTO>> GetByUserIdAsync(int userId);
        Task CancelAsync(int bookingId);
        Task RescheduleAsync(int bookingId, DateTime newDate, TimeOnly newTime);
    }
}

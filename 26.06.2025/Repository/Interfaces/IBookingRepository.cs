using BookMyShowApp.Models;

namespace BookMyShowAPI.Repository.Interfaces
{
    public interface IBookingRepository
    {
        Task AddAsync(Booking booking);
        Task<bool> CancelBookingAsync(int bookingId);
        Task<IEnumerable<Booking>> GetByUserIdAsync(int userId);
    }
}

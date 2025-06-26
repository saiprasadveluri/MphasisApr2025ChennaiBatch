using BookMyShowAPI.DTO;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;

namespace BookMyShowAPI.Interfaces
{
    public interface IBookingService
    {
        Task<ServiceResult> BookAsync(BookingRequestDto dto);
        Task<ServiceResult> CancelAsync(int id);
        Task<IEnumerable<Booking>> GetByUserAsync(int userId);
    }
}

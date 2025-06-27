namespace Book.DataAccessLayer.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> CreateAsync(Booking booking);
        Task<IEnumerable<Booking>> GetByUserAsync(int userId);
        Task UpdateStatusAsync(int bookingId, string status);
        Task RescheduleAsync(int bookingId, DateTime newDate, TimeOnly newTime);
    }
}

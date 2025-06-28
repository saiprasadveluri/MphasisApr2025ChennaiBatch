using Book.Data.DB;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookMyShowDbContext _context;

        public BookingRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> CreateAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<IEnumerable<Booking>> GetByUserIdAsync(int userId)
        {
            return await _context.Bookings
                .Where(b => b.UserId == userId)
                .ToListAsync();
        }
        public async Task<IEnumerable<Booking>> GetByUserAsync(int userId)
        {
            return await _context.Bookings.Where(b => b.UserId == userId).ToListAsync();
        }

        public async Task UpdateStatusAsync(int bookingId, string status)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null)
            {
                booking.Status = status;
                await _context.SaveChangesAsync();
            }
        }

        public async Task RescheduleAsync(int bookingId, DateTime newDate, TimeOnly newTime)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null)
            {
                booking.BookingDate = newDate;
                //booking.BookingTime = newTime;
                await _context.SaveChangesAsync();
            }
        }

    }
}

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
    }
}

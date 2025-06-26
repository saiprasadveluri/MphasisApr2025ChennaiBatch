using BookMyShowAPI.Data;
using BookMyShowAPI.Repository.Interfaces;
using BookMyShowApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowAPI.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;
        public BookingRepository(AppDbContext context) => _context = context;

        public async Task AddAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CancelBookingAsync(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking == null) return false;

            booking.Status = "Cancelled";
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Booking>> GetByUserIdAsync(int userId)
        {
            return await _context.Bookings
                .Include(b => b.Movie)
                .Include(b => b.Theatre)
                .Where(b => b.UserId == userId)
                .ToListAsync();
        }
    }
}

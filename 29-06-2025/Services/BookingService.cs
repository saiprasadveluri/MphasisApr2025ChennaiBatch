using Book.Data.DB;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class BookingService: BookMyShowDbContext
    {
        private readonly BookMyShowDbContext _context;

        public BookingService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {

        }

        public async Task<Booking> CreateAsync(Booking booking)
        {
            _context.Bookings.Add(booking); // Uses _context to access the Bookings DbSet and add a new booking
            await _context.SaveChangesAsync(); // Uses _context to save changes to the database
            return booking;
        }

        public async Task<IEnumerable<Booking>> GetByUserIdAsync(int userId)
        {
            
            return await _context.Bookings
                .Where(b => b.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetByUserAsync(int userId) // Duplicate of GetByUserIdAsync
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
                                               
                await _context.SaveChangesAsync(); 
            }
        }


    }
}

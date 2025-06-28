using Book.Data;
using Book.Data.DB;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class SeatRepository : ISeatRepository
    {
        private readonly BookMyShowDbContext _context;

        public SeatRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Seat>> GetByTheatreIdAsync(int theatreId)
        {
            return await _context.Seats
                .Where(seat => seat.TheatreId == theatreId)
                .ToListAsync();
        }

        public async Task UpdateSeatStatusAsync(int seatId, string status)
        {
            var seat = await _context.Seats.FindAsync(seatId);
            if (seat != null)
            {
                seat.Status = status;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Seat> CreateAsync(Seat seat)
        {
            _context.Seats.Add(seat);
            await _context.SaveChangesAsync();
            return seat;
        }

        public async Task DeleteAsync(int seatId)
        {
            var seat = await _context.Seats.FindAsync(seatId);
            if (seat != null)
            {
                _context.Seats.Remove(seat);
                await _context.SaveChangesAsync();
            }
        }

    }
}

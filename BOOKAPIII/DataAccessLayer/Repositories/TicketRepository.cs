using Book.Data;
using Book.Data.DB;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly BookMyShowDbContext _context;

        public TicketRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetByUserIdAsync(int userId)
        {
            return await _context.Tickets
                .Where(t => t.UserId == userId)
                .ToListAsync();
        }

        public async Task<Ticket> CreateAsync(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }
        public async Task DeleteAsync(int ticketId)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Ticket> UpdateAsync(int ticketId, Ticket updatedTicket)
        {
            var existing = await _context.Tickets
                .Include(t => t.Seats)
                .FirstOrDefaultAsync(t => t.TicketId == ticketId);

            if (existing == null) return null;

            existing.MovieId = updatedTicket.MovieId;
            existing.TheaterId = updatedTicket.TheaterId;
            existing.ShowId = updatedTicket.ShowId;
            existing.TicketDate = updatedTicket.TicketDate;

         
            existing.Seats.Clear();

            foreach (var seat in updatedTicket.Seats)
            {
                var trackedSeat = await _context.Seats.FindAsync(seat.SeatId);
                if (trackedSeat != null)
                    existing.Seats.Add(trackedSeat);
            }

            await _context.SaveChangesAsync();
            return existing;
        }


    }

}

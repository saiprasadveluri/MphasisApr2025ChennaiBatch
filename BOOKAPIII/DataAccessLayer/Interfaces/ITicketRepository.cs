using Book.Data;
using Book.DTO;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetByUserIdAsync(int userId);
        Task<Ticket> CreateAsync(Ticket ticket);
        Task DeleteAsync(int ticketId);
        Task<Ticket> UpdateAsync(int ticketId, Ticket updatedTicket);
      


    }
}

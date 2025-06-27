using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetByUserIdAsync(int userId);
        Task<Ticket> CreateAsync(Ticket ticket);
    }
}

using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ITicketService
    {
        Task<IEnumerable<TicketDTO>> GetByUserIdAsync(int userId);
        Task<TicketDTO> CreateAsync(TicketDTO dto);
    }
}

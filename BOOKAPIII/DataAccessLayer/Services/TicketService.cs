using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _repo;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TicketDTO>> GetByUserIdAsync(int userId)
            => _mapper.Map<IEnumerable<TicketDTO>>(await _repo.GetByUserIdAsync(userId));

        public async Task<TicketDTO> CreateAsync(TicketDTO dto)
        {
            var entity = _mapper.Map<Ticket>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<TicketDTO>(created);
        }
        public async Task DeleteAsync(int ticketId)
        {
            await _repo.DeleteAsync(ticketId);
        }
        public async Task<TicketDTO> UpdateAsync(int ticketId, TicketDTO dto)
        {
            var entity = _mapper.Map<Ticket>(dto);
            var updated = await _repo.UpdateAsync(ticketId, entity);
            return updated != null ? _mapper.Map<TicketDTO>(updated) : null;
        }

    }
}

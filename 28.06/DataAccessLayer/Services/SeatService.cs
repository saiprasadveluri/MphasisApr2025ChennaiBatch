using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _repo;
        private readonly IMapper _mapper;

        public SeatService(ISeatRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SeatDTO>> GetByTheatreIdAsync(int theatreId)
            => _mapper.Map<IEnumerable<SeatDTO>>(await _repo.GetByTheatreIdAsync(theatreId));

        public async Task UpdateSeatStatusAsync(int seatId, string status)
            => await _repo.UpdateSeatStatusAsync(seatId, status);
    }
}

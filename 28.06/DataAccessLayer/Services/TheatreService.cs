using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class TheatreService : ITheatreService
    {
        private readonly ITheatreRepository _repo;
        private readonly IMapper _mapper;

        public TheatreService(ITheatreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TheatreDTO>> GetByCityIdAsync(int cityId)
            => _mapper.Map<IEnumerable<TheatreDTO>>(await _repo.GetByCityIdAsync(cityId));

        public async Task<TheatreDTO> CreateAsync(TheatreDTO dto)
        {
            var entity = _mapper.Map<Theatre>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<TheatreDTO>(created);
        }
    }
}

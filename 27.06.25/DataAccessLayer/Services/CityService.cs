using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{

    public class CityService : ICityService
    {
        private readonly ICityRepository _repo;
        private readonly IMapper _mapper;

        public CityService(ICityRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityDTO>> GetAllAsync()
            => _mapper.Map<IEnumerable<CityDTO>>(await _repo.GetAllAsync());

        public async Task<CityDTO> CreateAsync(CityDTO dto)
        {
            var entity = _mapper.Map<City>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<CityDTO>(created);
        }
    }
}

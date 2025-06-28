using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repo;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreDTO>> GetAllAsync()
            => _mapper.Map<IEnumerable<GenreDTO>>(await _repo.GetAllAsync());

        public async Task<GenreDTO> CreateAsync(GenreDTO dto)
        {
            var entity = _mapper.Map<Genre>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<GenreDTO>(created);
        }
    }
}

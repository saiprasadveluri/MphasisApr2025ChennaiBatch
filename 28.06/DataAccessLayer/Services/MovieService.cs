using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MovieDTO>> GetAllAsync()
            => _mapper.Map<IEnumerable<MovieDTO>>(await _repo.GetAllAsync());

        public async Task<MovieDTO> GetByIdAsync(int id)
            => _mapper.Map<MovieDTO>(await _repo.GetByIdAsync(id));

        public async Task<MovieDTO> CreateAsync(MovieDTO dto)
        {
            var entity = _mapper.Map<Movie>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<MovieDTO>(created);
        }

        public async Task UpdateAsync(int id, MovieDTO dto)
        {
            var entity = _mapper.Map<Movie>(dto);
            entity.MovieId = id;
            await _repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
            => await _repo.DeleteAsync(id);
    }
}

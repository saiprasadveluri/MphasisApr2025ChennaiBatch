using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository _repo;
        private readonly IMapper _mapper;

        public ShowService(IShowRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ShowDTO>> GetByMovieIdAsync(int movieId)
            => _mapper.Map<IEnumerable<ShowDTO>>(await _repo.GetByMovieIdAsync(movieId));

        public async Task<ShowDTO> AddAsync(ShowDTO dto)
        {
            var entity = _mapper.Map<Show>(dto);
            var created = await _repo.AddAsync(entity);
            return _mapper.Map<ShowDTO>(created);
        }
        public async Task DeleteAsync(int showId)
        {
            await _repo.DeleteAsync(showId);
        }
        public async Task<ShowDTO> UpdateAsync(int showId, ShowDTO dto)
        {
            var entity = _mapper.Map<Show>(dto);
            var updated = await _repo.UpdateAsync(showId, entity);
            return updated != null ? _mapper.Map<ShowDTO>(updated) : null;
        }


    }
}

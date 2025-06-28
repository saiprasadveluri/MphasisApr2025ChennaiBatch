using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repo;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReviewDTO>> GetByMovieAsync(int movieId)
            => _mapper.Map<IEnumerable<ReviewDTO>>(await _repo.GetByMovieAsync(movieId));

        public async Task<ReviewDTO> AddAsync(ReviewDTO dto)
        {
            var entity = _mapper.Map<Review>(dto);
            var result = await _repo.AddAsync(entity);
            return _mapper.Map<ReviewDTO>(result);
        }

        public async Task DeleteAsync(int commentId)
            => await _repo.DeleteAsync(commentId);

        public async Task<ReviewDTO> UpdateAsync(int commentId, ReviewDTO dto)
        {
            var entity = _mapper.Map<Review>(dto);
            var updated = await _repo.UpdateAsync(commentId, entity);
            return updated != null ? _mapper.Map<ReviewDTO>(updated) : null;
        }

    }
}

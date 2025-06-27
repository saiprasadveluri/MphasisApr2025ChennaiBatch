using Book.DTO;

namespace Book.Services.Interfaces
{
   
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDTO>> GetByMovieAsync(int movieId);
        Task<ReviewDTO> AddAsync(ReviewDTO dto);
        Task DeleteAsync(int commentId);
    }
}

using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Review>> GetByMovieAsync(int movieId);
        Task<Review> AddAsync(Review review);
        Task DeleteAsync(int commentId);
    }
}

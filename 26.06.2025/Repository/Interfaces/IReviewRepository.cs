using BookMyShowApp.Models;

namespace BookMyShowAPI.Repository.Interfaces
{
    public interface IReviewRepository
    {
        Task AddRatingAsync(Rating rating);
        Task AddReviewAsync(Review review);
        Task AddCommentAsync(Comment comment);
        Task<IEnumerable<Review>> GetByMovieIdAsync(int movieId);
    }
}

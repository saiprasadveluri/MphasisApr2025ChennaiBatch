using BookMyShowAPI.DTO;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;

namespace BookMyShowAPI.Interfaces
{
    public interface IReviewService
    {
        Task<ServiceResult> AddRatingAsync(RatingDto dto);
        Task<ServiceResult> AddReviewAsync(ReviewDto dto);
        Task<ServiceResult> AddCommentAsync(CommentDto dto);
        Task<IEnumerable<Review>> GetReviewsByMovieAsync(int movieId);
    }
}

using BookMyShowAPI.DTO;
using BookMyShowAPI.Interfaces;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;
using BookMyShowAPI.Repository.Interfaces;

namespace BookMyShowAPI.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repo;

        public ReviewService(IReviewRepository repo)
        {
            _repo = repo;
        }

        public async Task<ServiceResult> AddRatingAsync(RatingDto dto)
        {
            var rating = new Rating
            {
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                Stars = dto.Stars
            };
            await _repo.AddRatingAsync(rating);
            return ServiceResult.Success("Rated");
        }

        public async Task<ServiceResult> AddReviewAsync(ReviewDto dto)
        {
            var review = new Review
            {
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                ReviewText = dto.ReviewText
            };
            await _repo.AddReviewAsync(review);
            return ServiceResult.Success("Review submitted");
        }

        public async Task<ServiceResult> AddCommentAsync(CommentDto dto)
        {
            var comment = new Comment
            {
                UserId = dto.UserId,
                MovieId = dto.MovieId,
                CommentText = dto.CommentText
            };
            await _repo.AddCommentAsync(comment);
            return ServiceResult.Success("Comment posted");
        }

        public async Task<IEnumerable<Review>> GetReviewsByMovieAsync(int movieId) =>
            await _repo.GetByMovieIdAsync(movieId);
    }
}

using Book.Data; // For the Review entity
using Book.Data.DB; // For BookMyShowDbContext
using Book.DTO; // For ReviewDTO
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class ReviewService : BookMyShowDbContext
    {
        public ReviewService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
        }
        public async Task<List<ReviewDTO>> GetAllReviewsAsync()
        {
            return await this.Reviews
                             .Select(r => new ReviewDTO
                             {
                                 CommentId = r.CommentId,
                                 Rating = r.Rating,
                                 CommentText = r.CommentText,
                                 DatePosted = r.DatePosted,
                                 UserId = r.UserId,
                                 MovieId = r.MovieId,
                                 Timings = r.Timings
                             })
                             .ToListAsync();
        }
        public async Task<ReviewDTO> GetReviewByIdAsync(int id)
        {
            var review = await this.Reviews.FindAsync(id);

            if (review == null)
            {
                return null;
            }

            return new ReviewDTO
            {
                CommentId = review.CommentId,
                Rating = review.Rating,
                CommentText = review.CommentText,
                DatePosted = review.DatePosted,
                UserId = review.UserId,
                MovieId = review.MovieId,
                Timings = review.Timings
            };
        }
        public async Task<List<ReviewDTO>> GetReviewsByMovieIdAsync(int movieId)
        {
            return await this.Reviews
                             .Where(r => r.MovieId == movieId)
                             .Select(r => new ReviewDTO
                             {
                                 CommentId = r.CommentId,
                                 Rating = r.Rating,
                                 CommentText = r.CommentText,
                                 DatePosted = r.DatePosted,
                                 UserId = r.UserId,
                                 MovieId = r.MovieId,
                                 Timings = r.Timings
                             })
                             .ToListAsync();
        }


        // ****Create Operation 
        public async Task<ReviewDTO> CreateReviewAsync(ReviewDTO reviewCreate)
        {
            
            if (reviewCreate.Rating < 1 || reviewCreate.Rating > 5)
            {
                throw new ArgumentException("Rating must be between 1 and 5.", nameof(reviewCreate.Rating));
            }
            if (reviewCreate.UserId <= 0)
            {
                throw new ArgumentException("Invalid UserId.", nameof(reviewCreate.UserId));
            }
            if (reviewCreate.MovieId <= 0)
            {
                throw new ArgumentException("Invalid MovieId.", nameof(reviewCreate.MovieId));
            }

            var review = new Review
            {
                
                Rating = (int)reviewCreate.Rating,
                CommentText = reviewCreate.CommentText,
                DatePosted = DateTime.UtcNow, 
                UserId = reviewCreate.UserId,
                MovieId = reviewCreate.MovieId,
                Timings = reviewCreate.Timings 
            };

            this.Reviews.Add(review);
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new ReviewDTO
                {
                    CommentId = review.CommentId, // ID will be populated after SaveChangesAsync
                    Rating = review.Rating,
                    CommentText = review.CommentText,
                    DatePosted = review.DatePosted,
                    UserId = review.UserId,
                    MovieId = review.MovieId,
                    Timings = review.Timings
                };
            }
            return null;
        }

        // ***********Update
        public async Task<ReviewDTO> UpdateReviewAsync(int id, ReviewDTO reviewUpdate)
        {
            var existingReview = await this.Reviews.FindAsync(id);

            if (existingReview == null)
            {
                return null;
            }

            if (reviewUpdate.Rating < 1 || reviewUpdate.Rating > 5)
            {
                throw new ArgumentException("Rating must be between 1 and 5 for update.", nameof(reviewUpdate.Rating));
            }

            existingReview.Rating = (int)reviewUpdate.Rating;
            existingReview.CommentText = reviewUpdate.CommentText;
            existingReview.Timings = reviewUpdate.Timings;

            this.Entry(existingReview).State = EntityState.Modified;
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new ReviewDTO
                {
                    CommentId = existingReview.CommentId,
                    Rating = existingReview.Rating,
                    CommentText = existingReview.CommentText,
                    DatePosted = existingReview.DatePosted,
                    UserId = existingReview.UserId,
                    MovieId = existingReview.MovieId,
                    Timings = existingReview.Timings
                };
            }
            return null; // No changes saved (e.g., no actual change or database error)
        }

        //******Delete
        public async Task<bool> DeleteReviewAsync(int id)
        {
            var reviewToDelete = await this.Reviews.FindAsync(id);

            if (reviewToDelete == null)
            {
                return false; // Review not found
            }

            this.Reviews.Remove(reviewToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}
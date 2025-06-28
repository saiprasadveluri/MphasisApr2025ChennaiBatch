using Book.Data;
using Book.Data.DB;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly BookMyShowDbContext _context;

        public ReviewRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Review>> GetByMovieAsync(int movieId)
        {
            return await _context.Reviews
                .Where(r => r.MovieId == movieId)
                .ToListAsync();
        }

        public async Task<Review> AddAsync(Review review)
        {
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }

        public async Task DeleteAsync(int commentId)
        {
            var review = await _context.Reviews.FindAsync(commentId);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Review> UpdateAsync(int commentId, Review updatedReview)
        {
            var existing = await _context.Reviews.FindAsync(commentId);
            if (existing == null) return null;

            
            existing.Rating = updatedReview.Rating;
           

            await _context.SaveChangesAsync();
            return existing;
        }

    }
}

using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Book.Data.DB;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly BookMyShowDbContext _context;

        public ShowRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Show>> GetByMovieIdAsync(int movieId)
        {
            return await _context.Shows
                .Where(s => s.MovieId == movieId)
                .ToListAsync();
        }

        public async Task<Show> AddAsync(Show show)
        {
            _context.Shows.Add(show);
            await _context.SaveChangesAsync();
            return show;
        }
        public async Task DeleteAsync(int showId)
        {
            var show = await _context.Shows.FindAsync(showId);
            if (show != null)
            {
                _context.Shows.Remove(show);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Show> UpdateAsync(int showId, Show updatedShow)
        {
            var existing = await _context.Shows.FindAsync(showId);
            if (existing == null) return null;

            // Update fields
            existing.MovieId = updatedShow.MovieId;
            existing.TheatreId = updatedShow.TheatreId;
            existing.ShowDate = updatedShow.ShowDate;
            existing.ShowTime = updatedShow.ShowTime;
            existing.Price = updatedShow.Price;

            await _context.SaveChangesAsync();
            return existing;
        }

    }
}

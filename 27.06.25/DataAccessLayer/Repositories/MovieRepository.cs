using Book.Data.DB;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Book.Data;

namespace Book.DataAccessLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly BookMyShowDbContext _context;

        public MovieRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetByTheatreIdAsync(int theatreId)
        {
            return await _context.Movies
                .Where(m => m.TheatreId == theatreId)
                .ToListAsync();
        }

        public async Task<Movie> GetByIdAsync(int movieId)
        {
            return await _context.Movies.FindAsync(movieId);
        }
    }
}

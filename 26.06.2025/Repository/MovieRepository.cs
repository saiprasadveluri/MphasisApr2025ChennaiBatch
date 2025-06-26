using BookMyShowAPI.Data;
using BookMyShowAPI.Repository.Interfaces;
using BookMyShowApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowAPI.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Movie>> GetAllAsync() => await _context.Movies.ToListAsync();
        public async Task<Movie> GetByIdAsync(int id) => await _context.Movies.FindAsync(id);
        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}

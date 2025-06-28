using Book.Data.DB;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class TheatreRepository : ITheatreRepository
    {
        private readonly BookMyShowDbContext _context;

        public TheatreRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Theatre>> GetByCityIdAsync(int cityId)
        {
            return await _context.Theatres
                .Where(t => t.CityId == cityId)
                .ToListAsync();
        }

        public async Task<Theatre> CreateAsync(Theatre theatre)
        {
            _context.Theatres.Add(theatre);
            await _context.SaveChangesAsync();
            return theatre;
        }

        public async Task<bool> ExistsAsync(int theatreId)
        {
            return await _context.Theatres.AnyAsync(t => t.TheatreId == theatreId);
        }
        public async Task<bool> DeleteAsync(int theatreId)
        {
            var theatre = await _context.Theatres.FindAsync(theatreId);
            if (theatre == null) return false;

            _context.Theatres.Remove(theatre);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Theatre> UpdateAsync(int theatreId, Theatre updatedTheatre)
        {
            var existing = await _context.Theatres.FindAsync(theatreId);
            if (existing == null) return null;

            existing.TheatreName = updatedTheatre.TheatreName;
            existing.CityId = updatedTheatre.CityId;
            existing.Location = updatedTheatre.Location;
            existing.Address = updatedTheatre.Address;
            existing.Capacity = updatedTheatre.Capacity;
            existing.ScreenCount = updatedTheatre.ScreenCount;
            // Add any other fields you wish to support updating

            await _context.SaveChangesAsync();
            return existing;
        }

    }
}

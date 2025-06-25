using RideAggregatorAPP.Data;
using RideAggregatorAPP.Models;

using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPP.Services.Service
{
    public class LocationService : ILocationService
    {
        private readonly RideDbContext _context;
        public LocationService(RideDbContext context) => _context = context;

        public async Task<List<Location>> GetAllAsync() => await _context.Locations.ToListAsync();

        public async Task<Location?> GetByIdAsync(int id) => await _context.Locations.FindAsync(id);

        public async Task<Location> CreateAsync(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return location;
        }

        public async Task<Location> UpdateAsync(int id, Location location)
        {
            var existing = await _context.Locations.FindAsync(id);
            if (existing == null) return null!;
            existing.Name = location.Name;
            existing.Latitude = location.Latitude;
            existing.Longitude = location.Longitude;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task DeleteAsync(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();
            }
        }
    }


}

using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorApi.Services.Service
{
    public class RideService : IRideService
    {
        private readonly RideDbContext _context;
        public RideService(RideDbContext context) => _context = context;

        public async Task<List<Ride>> GetAllAsync() => await _context.Rides.ToListAsync();

        public async Task<Ride?> GetByIdAsync(int id) => await _context.Rides.FindAsync(id);

        public async Task<List<Ride>> GetByCustomerIdAsync(int customerId) =>
            await _context.Rides.Where(r => r.CustomerId == customerId).ToListAsync();

        public async Task<List<Ride>> GetByDriverIdAsync(int driverId) =>
            await _context.Rides.Where(r => r.DriverId == driverId).ToListAsync();
    }

}
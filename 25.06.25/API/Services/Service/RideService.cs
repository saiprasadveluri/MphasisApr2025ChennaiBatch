using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;
using RideAggregatorApi.Services.Service;

namespace RideAggregatorApi.Services.Service
{
    public class RideService : IRideService
    {
        private readonly RideDbContext _context;
        public RideService(RideDbContext context) => _context = context;

        public async Task<List<RentalsRide>> GetAllAsync() => await _context.RentalsRides.ToListAsync();

        public async Task<RentalsRide?> GetByIdAsync(int id) => await _context.RentalsRides.FindAsync(id);

        public async Task<List<RentalsRide>> GetByCustomerIdAsync(int customerId) =>
            await _context.RentalsRides.Where(r => r.CustomerId == customerId).ToListAsync();

        public async Task<List<RentalsRide>> GetByDriverIdAsync(int driverId) =>
           await _context.RentalsRides.Where(r => r.DriverId == driverId).Cast<RentalsRide>().ToListAsync();

        //    public async Task<List<Ride>> GetByDriverIdAsync(int driverId) =>
        //await _context.RentalsRides
        //    .Where(r => r.DriverId == driverId)
        //    .Cast<Ride>()
        //    .ToListAsync();

    }


}

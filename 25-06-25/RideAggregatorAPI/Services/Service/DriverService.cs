using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;


namespace RideAggregatorApi.Services.Service
{
    public class DriverService : IDriverService
    {
        private readonly RideDbContext _context;
        public DriverService(RideDbContext context) => _context = context;

        public async Task<List<Driver>> GetAllAsync() => await _context.Drivers.ToListAsync();

        public async Task<Driver> GetByIdAsync(int id) => await _context.Drivers.FindAsync(id);

        public async Task<Driver> CreateAsync(Driver driver)
        {
            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver> UpdateAsync(int id, Driver updatedDriver)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null) return null;

            driver.Name = updatedDriver.Name;
            driver.LicenseNumber = updatedDriver.LicenseNumber;
            driver.VehicleDetails = updatedDriver.VehicleDetails;

            await _context.SaveChangesAsync();
            return driver;
        }

        public async Task DeleteAsync(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                await _context.SaveChangesAsync();
            }
        }
    }

}
using Microsoft.AspNetCore.Mvc;
using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalsRideController : ControllerBase
    {
        private readonly RideDbContext _context;
        public RentalsRideController(RideDbContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> Create(RentalsRide ride)
        {
            ride.CreatedAt = DateTime.UtcNow;
            ride.BillAmount = ride.MinimumFare + (decimal)ride.TollFees;
            _context.RentalsRides.Add(ride);
            await _context.SaveChangesAsync();
            return Ok(ride);
        }

        [HttpGet("by-driver/{driverId}")]
        public async Task<IActionResult> GetByDriver(int driverId) =>
            Ok(await _context.RentalsRides.Where(r => r.DriverId == driverId).ToListAsync());
    }

}
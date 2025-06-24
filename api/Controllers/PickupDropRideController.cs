using Microsoft.AspNetCore.Mvc;
using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PickupDropRideController : ControllerBase
    {
        private readonly RideDbContext _context;
        public PickupDropRideController(RideDbContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> Create(PickupDropRide ride)
        {
            ride.CreatedAt = DateTime.UtcNow;
            ride.BillAmount = (decimal)ride.DistanceKm * ride.RatePerKm;
            _context.PickupDropRides.Add(ride);
            await _context.SaveChangesAsync();
            return Ok(ride);
        }

        [HttpGet("by-customer/{customerId}")]
        public async Task<IActionResult> GetByCustomer(int customerId) =>
            Ok(await _context.PickupDropRides.Where(r => r.CustomerId == customerId).ToListAsync());
    }

}

using Microsoft.AspNetCore.Mvc;
using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using RideAggregatorApi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalsRideController : ControllerBase
    {
        private readonly RideDbContext _context;

        public RentalsRideController(RideDbContext context)
        {
            _context = context;
        }

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
        public async Task<IActionResult> GetByDriver(int driverId)
        {
            try
            {
                var rides = await _context.RentalsRides
                    .Where(r => r.DriverId == driverId)
                    .ToListAsync();

                return Ok(rides);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"API error: {ex.Message}");
            }
        }

        [HttpPost("complete")]
        public async Task<IActionResult> CompleteRide([FromBody] int rideId)
        {
            var ride = await _context.RentalsRides.FindAsync(rideId);
            if (ride == null) return NotFound();

            ride.IsCompleted = true;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("payment")]
        public async Task<IActionResult> ConfirmPayment([FromBody] PaymentDto payment)
        {
            var ride = await _context.RentalsRides.FindAsync(payment.RideId);
            if (ride == null) return NotFound();

            ride.PaymentMethod = payment.PaymentMethod;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("rate")]
        public async Task<IActionResult> RateDriver([FromBody] RatingDto rating)
        {
            var ride = await _context.RentalsRides.FindAsync(rating.RideId);
            if (ride == null) return NotFound();

            ride.Rating = rating.Rating;
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("accept")]
        public async Task<IActionResult> AcceptRide([FromBody] int rideId)
        {
            var ride = await _context.RentalsRides.FindAsync(rideId);
            if (ride == null) return NotFound();

            ride.IsAccepted = true;
            ride.AcceptedAt = DateTime.UtcNow;
            ride.EstimatedDistance = "2.4 km";
            ride.EstimatedTime = "6 mins";

            await _context.SaveChangesAsync();

            return Ok(ride);
        }

        [HttpGet("{rideId}")]
        public async Task<IActionResult> GetRideStatus(int rideId)
        {
            var ride = await _context.RentalsRides.FindAsync(rideId);
            if (ride == null) return NotFound();

            return Ok(new
            {
                ride.IsAccepted,
                ride.AcceptedAt,
                ride.EstimatedDistance,
                ride.EstimatedTime,
                ride.IsCompleted,
                ride.PaymentMethod,
                ride.Rating
            });
        }
    }
}

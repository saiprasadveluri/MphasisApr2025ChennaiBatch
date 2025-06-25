using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/RentalsRide")]
    [ApiController]
    public class RentalsRideController : ControllerBase
    {
        private readonly RideDbContext _context;

        public RentalsRideController(RideDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var rides = _context.RentalsRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .ToList();

            return Ok(rides);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ride = _context.RentalsRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .FirstOrDefault(r => r.Id == id);

            if (ride == null)
                return NotFound();

            return Ok(ride);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RentalsRide ride)
        {
            _context.RentalsRides.Add(ride);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = ride.Id }, ride);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RentalsRide ride)
        {
            var existing = _context.RentalsRides.Find(id);
            if (existing == null)
                return NotFound();

            existing.CustomerId = ride.CustomerId;
            existing.DriverId = ride.DriverId;
            existing.StartDate = ride.StartDate;
            existing.HiredDays = ride.HiredDays;
            existing.Traveldistance = ride.Traveldistance;
            existing.TollFees = ride.TollFees;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ride = _context.RentalsRides.Find(id);
            if (ride == null)
                return NotFound();

            _context.RentalsRides.Remove(ride);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

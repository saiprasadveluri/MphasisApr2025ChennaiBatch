using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/PickupDropRide")]
    [ApiController]
    public class PickupDropRideController : ControllerBase
    {
        private readonly RideDbContext _context;

        public PickupDropRideController(RideDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var rides = _context.PickupDropRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .Include(r => r.SourceLocation)
                .Include(r => r.DestinationLocation)
                .ToList();

            return Ok(rides);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ride = _context.PickupDropRides
                .Include(r => r.Customer)
                .Include(r => r.Driver)
                .Include(r => r.SourceLocation)
                .Include(r => r.DestinationLocation)
                .FirstOrDefault(r => r.Id == id);

            if (ride == null)
                return NotFound();

            return Ok(ride);
        }

        [HttpPost]
        public IActionResult Create(PickupDropRide ride)
        {
            _context.PickupDropRides.Add(ride);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = ride.Id }, ride);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, PickupDropRide ride)
        {
            var existing = _context.PickupDropRides.Find(id);
            if (existing == null)
                return NotFound();

            existing.CustomerId = ride.CustomerId;
            existing.DriverId = ride.DriverId;
            existing.SourceLocationId = ride.SourceLocationId;
            existing.DestinationLocationId = ride.DestinationLocationId;
            existing.StartTime = ride.StartTime;
            existing.EndTime = ride.EndTime;
            existing.KmsTravelled = ride.KmsTravelled;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var ride = _context.PickupDropRides.Find(id);
            if (ride == null)
                return NotFound();

            _context.PickupDropRides.Remove(ride);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

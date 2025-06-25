using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;
namespace RideAggregator.API.Controllers
{
    public class PickUpDrop : Controller
    {
        private readonly IPickupDropRideRepository _rideRepo;

        public PickupDropRideController(IPickupDropRideRepository rideRepo)
        {
            _rideRepo = rideRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PickupDropRide>>> GetAll()
        {
            var rides = await _rideRepo.GetAllAsync();
            return Ok(rides);
        }

        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<PickupDropRide>>> GetByCustomerId(int customerId)
        {
            var rides = await _rideRepo.GetAllAsync();
            return Ok(rides.Where(r => r.CustomerId == customerId));
        }

        [HttpGet("driver/{driverId}")]
        public async Task<ActionResult<IEnumerable<PickupDropRide>>> GetByDriverId(int driverId)
        {
            var rides = await _rideRepo.GetAllAsync();
            return Ok(rides.Where(r => r.DriverId == driverId));
        }

        [HttpPost]
        public async Task<ActionResult> Create(PickupDropRide ride)
        {
            ride.StartTime = DateTime.Now; // Optional default
            await _rideRepo.AddAsync(ride);
            await _rideRepo.SaveAsync();
            return CreatedAtAction(nameof(GetAll), new { id = ride.Id }, ride);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, PickupDropRide updatedRide)
        {
            var existing = await _rideRepo.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.CustomerId = updatedRide.CustomerId;
            existing.DriverId = updatedRide.DriverId;
            existing.SourceLocationId = updatedRide.SourceLocationId;
            existing.DestinationLocationId = updatedRide.DestinationLocationId;
            existing.StartTime = updatedRide.StartTime;
            existing.EndTime = updatedRide.EndTime;
            existing.KmsTravelled = updatedRide.KmsTravelled;

            _rideRepo.Update(existing);
            await _rideRepo.SaveAsync();
            return NoContent();
        }
    }
}

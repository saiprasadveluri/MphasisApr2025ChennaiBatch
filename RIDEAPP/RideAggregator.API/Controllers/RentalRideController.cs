using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;

namespace RideAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRideController : ControllerBase
    {
        private readonly IRentalRideRepository _rentalRepo;

        public RentalRideController(IRentalRideRepository rentalRepo)
        {
            _rentalRepo = rentalRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentalRide>>> GetAll()
        {
            var rides = await _rentalRepo.GetAllAsync();
            return Ok(rides);
        }

        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<RentalRide>>> GetByCustomerId(int customerId)
        {
            var rides = await _rentalRepo.GetAllAsync();
            return Ok(rides.Where(r => r.CustomerId == customerId));
        }

        [HttpGet("driver/{driverId}")]
        public async Task<ActionResult<IEnumerable<RentalRide>>> GetByDriverId(int driverId)
        {
            var rides = await _rentalRepo.GetAllAsync();
            return Ok(rides.Where(r => r.DriverId == driverId));
        }

        [HttpPost]
        public async Task<ActionResult> Create(RentalRide ride)
        {
            ride.StartDate = DateTime.Now; // optional default
            await _rentalRepo.AddAsync(ride);
            await _rentalRepo.SaveAsync();
            return CreatedAtAction(nameof(GetAll), new { id = ride.Id }, ride);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, RentalRide updatedRide)
        {
            var existing = await _rentalRepo.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.CustomerId = updatedRide.CustomerId;
            existing.DriverId = updatedRide.DriverId;
            existing.StartDate = updatedRide.StartDate;
            existing.HiredDays = updatedRide.HiredDays;
            existing.TravelDistance = updatedRide.TravelDistance;
            existing.TollFees = updatedRide.TollFees;

            _rentalRepo.Update(existing);
            await _rentalRepo.SaveAsync();
            return NoContent();
        }
    }
}

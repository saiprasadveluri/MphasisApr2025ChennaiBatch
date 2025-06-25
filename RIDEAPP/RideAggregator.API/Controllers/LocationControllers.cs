using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;

namespace RideAggregator.API.Controllers
{
    public class LocationControllers : Controller
    {
        private readonly ILocationRepository _locationRepo;

        public LocationController(ILocationRepository locationRepo)
        {
            _locationRepo = locationRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetAll()
        {
            var locations = await _locationRepo.GetAllAsync();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetById(int id)
        {
            var location = await _locationRepo.GetByIdAsync(id);
            if (location == null)
                return NotFound();

            return Ok(location);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Location location)
        {
            await _locationRepo.AddAsync(location);
            await _locationRepo.SaveAsync();
            return CreatedAtAction(nameof(GetById), new { id = location.Id }, location);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Location updatedLocation)
        {
            var existing = await _locationRepo.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.Name = updatedLocation.Name;
            existing.Latitude = updatedLocation.Latitude;
            existing.Longitude = updatedLocation.Longitude;

            _locationRepo.Update(existing);
            await _locationRepo.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var location = await _locationRepo.GetByIdAsync(id);
            if (location == null)
                return NotFound();

            _locationRepo.Delete(location);
            await _locationRepo.SaveAsync();
            return NoContent();
        }
    }
}

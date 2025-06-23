using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public readonly RideDbContext _context;

        public LocationController(RideDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLocations()
        {
            var locations = _context.Locations.ToList();
            if(locations == null || !locations.Any())
            {
                return NotFound();
            }
            else
            {
                return Ok(locations);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetLocation(int id)
        {
            var location = _context.Locations.SingleOrDefault(x => x.Id == id);
            if(location == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(location);
            }
        }

        [HttpPost]
        public IActionResult AddLocation(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetLocation), new {id = location.Id},location);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            var location = _context.Locations.SingleOrDefault(x=>x.Id == id);
            if(location == null)
            {
                return NotFound();
            }
            else
            {
                _context.Locations.Remove(location);
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult PutLocation(int Id, Location location)
        {
            if(Id != location.Id)
            {
                return BadRequest();
            }
            _context.Entry(location).State = EntityState.Modified;
        }
    }
}

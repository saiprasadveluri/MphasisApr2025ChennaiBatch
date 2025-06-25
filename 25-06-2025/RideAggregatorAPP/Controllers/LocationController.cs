using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPP.Data;
using RideAggregatorAPP.Models;
using Microsoft.EntityFrameworkCore; 

namespace RideAggregatorAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly RideDbContext _context;
        public LocationController(RideDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _context.Locations.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return Ok(location);
        }
    }

}

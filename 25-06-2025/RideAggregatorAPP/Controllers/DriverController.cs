using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPP.Data;
using RideAggregatorAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly RideDbContext _context;
        public DriverController(RideDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _context.Drivers.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Create(Driver driver)
        {
            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();
            return Ok(driver);
        }
    }

}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/Driver")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        public readonly RideDbContext _context;

        public DriverController(RideDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDrivers()
        {
            var drivers = _context.Drivers.ToList();
            if (drivers == null || !drivers.Any())
            {
                return NotFound();
            }
            else
            {
                return Ok(drivers);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDriver(int id)
        {
            var drivers = _context.Drivers.SingleOrDefault(x => x.Id == id);
            if (drivers == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(drivers);
            }
        }

        [HttpPost]
        public IActionResult AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetDriver), new { id = driver.Id }, driver);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDriver(int id)
        {
            var driver = _context.Drivers.SingleOrDefault(x => x.Id == id);
            if (driver == null)
            {
                return NotFound();
            }
            else
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut("{id}")]
        public void UpdateDriver(int id, Driver driver)
        {
            var existingdriver = _context.Drivers.Where(l => l.Id == id).FirstOrDefault();
            if (existingdriver != null)
            {
                existingdriver.Name = driver.Name;
                existingdriver.Phone = driver.Phone;
                _context.SaveChanges();
            }
        }
    }
}

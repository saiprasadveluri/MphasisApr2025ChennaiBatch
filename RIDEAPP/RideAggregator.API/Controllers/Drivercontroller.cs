using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;

namespace RideAggregator.API.Controllers
{
    public class Drivercontroller : Controller
    {
        public DriverController(IDriverRepository driverRepo)
        {
            _driverRepo = driverRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Driver>>> GetAll()
        {
            var drivers = await _driverRepo.GetAllAsync();
            return Ok(drivers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetById(int id)
        {
            var driver = await _driverRepo.GetByIdAsync(id);
            if (driver == null)
                return NotFound();

            return Ok(driver);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Driver driver)
        {
            await _driverRepo.AddAsync(driver);
            await _driverRepo.SaveAsync();
            return CreatedAtAction(nameof(GetById), new { id = driver.Id }, driver);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Driver updatedDriver)
        {
            var existing = await _driverRepo.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.FullName = updatedDriver.FullName;
            existing.PhoneNumber = updatedDriver.PhoneNumber;
            existing.LicenseNumber = updatedDriver.LicenseNumber;

            _driverRepo.Update(existing);
            await _driverRepo.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var driver = await _driverRepo.GetByIdAsync(id);
            if (driver == null)
                return NotFound();

            _driverRepo.Delete(driver);
            await _driverRepo.SaveAsync();
            return NoContent();
        }
    }
}

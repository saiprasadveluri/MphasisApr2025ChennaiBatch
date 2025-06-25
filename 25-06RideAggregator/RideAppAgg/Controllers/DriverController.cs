using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        DataAccess db;
        public DriverController(DataAccess dataAccess)
        {
            db = dataAccess;
        }
        
        [HttpGet]
        public ActionResult<List<Driver>> GetAllDrivers()
        {
            List<Driver> drivers = db.GetAllDrivers();
            return Ok(drivers);
        }
        [HttpGet("id")]
        public ActionResult<Driver> GetDriverById(int id)
        {
            Driver driver = db.GetDriverById(id);
            if (driver == null)
            {
                return NotFound($"Driver with ID {id} not found.");
            }
            return Ok(driver);
        }
        [HttpPost]
        public ActionResult<Driver> AddDriver(Driver driver)
        {
            db.AddDriver(driver);
            return Ok(driver);
        }
        [HttpPost("id")]
        public ActionResult<Driver> UpdateDriver(int id, Driver driver)
        {
            db.UpdateDriver(id, driver);
            return Ok(driver);
        }
        [HttpDelete("id")]
        public ActionResult DeleteDriver(int id)
        {
            db.DeleteDriver(id);
            return Ok($"Driver with ID {id} deleted successfully.");
        }
    }
}

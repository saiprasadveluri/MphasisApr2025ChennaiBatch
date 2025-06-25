using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiderApp.DataAccess;
using RiderApp.DTO;

namespace RiderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        DbAccess Dbaccess;

        public DriverController(DbAccess dba)
        {
            Dbaccess = dba;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var drivers = Dbaccess.GetAllDrivers();
            return Ok(new { Data = drivers });
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var driver = Dbaccess.GetDriverById(id);
            if (driver != null)
            {
                return Ok(new { Data = driver });
            }
            else
            {
                return NotFound(new { Data = "Driver not found" });
            }
        }

        [HttpPost]
        public ActionResult AddDriver(DriverDTO inp)
        {
            bool status = Dbaccess.AddDriver(inp);
            if (status)
            {
                return Ok(new { Data = "Successfully added driver" });
            }
            else
            {
                return BadRequest(new { Data = "Failed to add driver" });
            }
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDriver(Guid id, DriverDTO updatedDriver)
        {
            if (id != updatedDriver.DriverId)
            {
                return BadRequest(new { Data = "ID mismatch" });
            }

            bool status = Dbaccess.UpdateDriver(updatedDriver);
            if (status)
            {
                return Ok(new { Data = "Successfully updated driver" });
            }
            else
            {
                return NotFound(new { Data = "Driver not found" });
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDriver(Guid id)
        {
            bool status = Dbaccess.DeleteDriverById(id);
            if (status)
            {
                return Ok(new { Data = "Successfully deleted driver" });
            }
            else
            {
                return NotFound(new { Data = "Driver not found" });
            }
        }
    }
}

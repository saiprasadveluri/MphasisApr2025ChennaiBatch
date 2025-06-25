using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
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
        [HttpPost]
        public ActionResult AddDriver([FromBody] DriverDTO dto)
        {
            bool status = Dbaccess.AddDriver(dto);
            return Ok(new { Message = "Driver added successfully", Status = status });
        }

        // GET: api/Driver
        [HttpGet]
        public ActionResult GetAllDrivers()
        {
            var drivers = Dbaccess.GetAllDrivers();
            return Ok(new { Data = drivers });
        }

        // GET: api/Driver/{id}
        [HttpGet("{id}")]
        public ActionResult GetDriverById(Guid id)
        {
            var driver = Dbaccess.GetDriverById(id);
            if (driver == null)
                return NotFound(new { Message = "Driver not found" });

            return Ok(new { Data = driver });
        }

        // PUT: api/Driver/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateDriver(Guid id, [FromBody] DriverDTO dto)
        {
            bool updated = Dbaccess.UpdateDriver(id, dto);
            if (!updated)
                return NotFound(new { Message = "Driver not found" });

            return Ok(new { Message = "Driver updated successfully" });
        }

        // DELETE: api/Driver/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteDriver(Guid id)
        {
            bool deleted = Dbaccess.DeleteDriver(id);
            if (!deleted)
                return NotFound(new { Message = "Driver not found" });

            return Ok(new { Message = "Driver deleted successfully" });
        }
    }
}

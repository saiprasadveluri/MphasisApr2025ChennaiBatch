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
        DbAccess _dbAccess;
        public DriverController(DbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }
        [HttpGet]
        public ActionResult<DriverDTO> GetALl()
        {
            List<DriverDTO> lst = _dbAccess.GetAllDrivers();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult<DriverDTO> GetById(Guid id)
        {
            DriverDTO obj = _dbAccess.GetDriverById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
        [HttpPost]
        public ActionResult AddDriver(DriverDTO inp)
        {
            bool Status = _dbAccess.AddDriver(inp);
            return Ok(new { Data = "Success om adding driver" });
        }
        [HttpPut("id")]
        public ActionResult UpdateDriver(Guid id, DriverDTO inp)
        {
            bool Status = _dbAccess.UpdateDriver(id, inp);
            if (Status)
            {
                return Ok(new { Data = "Driver successfully updated" });
            }
            else
            {
                return Ok(new { Data = "Error in updating Driver" });
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteDriver(Guid id)
        {
            bool Status = _dbAccess.DeleteDriver(id);
            if (Status)
            {
                return Ok(new { Data = "Driver successfully deleted" });
            }
            else
            {
                return Ok(new { Data = "Error in deleting Driver" });
            }
        }
    }
}

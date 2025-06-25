using Microsoft.AspNetCore.Mvc;
using RideAggrigationAPI.DataAccess;
using RideAggrigationAPI.DTO;

namespace RideAggrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly DbAccess _db;

        public DriverController(DbAccess db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _db.GetAllDrivers();
            return Ok(new { Data = data });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var driver = _db.GetDriverById(id);
            if (driver == null) return NotFound();
            return Ok(new { Data = driver });
        }

        [HttpPost]
        public IActionResult Add(DriverAddDTO input)
        {
            bool status = _db.AddDriver(input);
            return Ok(new { Data = status ? "Driver Added" : "Error" });
        }
    }
}

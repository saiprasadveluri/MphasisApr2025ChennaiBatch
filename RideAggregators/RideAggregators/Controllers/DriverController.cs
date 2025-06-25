using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregators.DataAccess;
using RideAggregators.DTO;

namespace RideAggregators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        public DbAccess dbAccess;

        public DriverController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddDriver(DriverDTO data)
        {
            bool status = dbAccess.AddDrivers(data);
            return Ok(new { data1 = "user added successfully" });
        }
        [HttpGet]

        public IActionResult GetAllDrivers()
        {
            List<DriverDTO> DriverData = dbAccess.GetAllDrivers();
            return Ok(new { data = DriverData });
        }
    }
}


   
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
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
            bool status = dbAccess.AddDriver(data);
            return Ok(new { result = status });
        }
        [HttpGet]
        public IActionResult GetAllDrivers()
        {
            List<DriverDTO> driveList = dbAccess.GetAllDrivers();
            return Ok(new { result = driveList });
        }
    }
}

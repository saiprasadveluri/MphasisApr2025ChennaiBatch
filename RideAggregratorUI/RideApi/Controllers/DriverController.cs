using Microsoft.AspNetCore.Mvc;
using RideApi.DataAccess;
using RideApi.DTO;

namespace RideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : Controller
    {
        DbAccess dbaccess;
        public DriverController(DbAccess db)
        {
            dbaccess = db;
        }
        [HttpPost]
        public IActionResult AddDriver(DriverDTO data)
        {
            bool status = dbaccess.AddDriver(data);
            return Ok(new { Data1 = "Driver added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllDrivers()
        {
            List<DriverDTO> DriverData = dbaccess.GetAllDrivers();
            return Ok(new { data = DriverData });
        }
    }
}

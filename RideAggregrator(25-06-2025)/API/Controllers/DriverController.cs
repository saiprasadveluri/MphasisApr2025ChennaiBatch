using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggerator.DTO;
using RideAggregatorAPI.DataAccess;

namespace RideAggerator.Controllers
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
        public IActionResult AddDriver(DriverDataDTO data)
        {
            bool status = Dbaccess.AddDriver(data);
            return Ok(new { data1 = "Driver added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllDrivers()
        {
            List<DriverDataDTO> DriverData = Dbaccess.GetAllDriverData();
            return Ok(new { data = DriverData });
        }
    }
}

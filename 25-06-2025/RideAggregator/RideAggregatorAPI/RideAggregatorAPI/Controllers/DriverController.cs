using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccessLayer;
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
            public IActionResult AddDriver(DriverDTO data)
            {
                bool status = Dbaccess.AddDriver(data);
                return Ok(new { Data = "Driver Added Successfully" });

            }
            [HttpGet]
           
            public IActionResult GetAllDrivers(DriverDTO data)
            {
                List<DriverDTO> drivers = Dbaccess.GetAllDrivers();
                return Ok(new { Data = drivers });
            }

        }
    }


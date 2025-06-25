using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.DTO;

namespace RideAggregateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : Controller
    {
        DBAccess Dbaccess;
        public DriverController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAllDriver()
        {
            List<DriversDTO> lst = Dbaccess.GetAllDrivers();
            return Ok(new { Data = lst });
        }
        
        [HttpPost]
        public ActionResult AddDriver(DriversDTO inp)
        {
            bool Status = Dbaccess.AddDriver(inp);
            return Ok(new { Data = "Success in Adding Driver" });
        }
    }
}

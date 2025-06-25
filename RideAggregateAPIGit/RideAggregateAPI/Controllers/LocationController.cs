using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.DTO;
using RideAggregateAPI.DataAccess;
namespace RideAggregateAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LocationController : Controller
    {

        DBAccess Dbaccess;
        public LocationController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAllLocations()
        {
            List<LocationDTO> lst = Dbaccess.GetAllLocations();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            LocationDTO obj = Dbaccess.GetLocationById(id);
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
        public ActionResult AddLocation(LocationDTO inp)
        {
            bool Status = Dbaccess.AddLocation(inp);
            return Ok(new { Data = "Success in Adding location" });
        }
    }
}

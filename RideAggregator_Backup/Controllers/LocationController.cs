using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.Data;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DbAccess Dbaccess;
        public LocationController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<LocationDTO> lst = Dbaccess.GetAllLocations();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            LocationDTO obj= Dbaccess.GetLocationById(id);
            if (obj != null)
            {
                return Ok(new {Data= obj}); 
            }
             else
            {
                return NotFound(new { Data = "Error" });
            }
        }
        [HttpPost]
        public ActionResult AddLocation(LocationDTO inp)
        {
            bool Status=Dbaccess.AddLocation(inp);
            return Ok(new { Data = "Success in Adding location" });
        }
    }
}

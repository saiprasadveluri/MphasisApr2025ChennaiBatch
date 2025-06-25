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

        [HttpPut]
        public ActionResult UpdateLocation(LocationDTO inp)
        {
            bool Status = Dbaccess.UpdateLocation(inp);
            if (Status)
                return Ok(new { Data = "Location updated successfully" });
            else
                return NotFound(new { Data = "Location not found" });



        }

        
        [HttpPut("{id}")]
        public ActionResult UpdateLocation(Guid id, LocationDTO inp)
        {
         
            inp.Id = id;

            bool status = Dbaccess.UpdateLocationById(inp);

            if (status)
                return Ok(new { Data = "Location updated successfully" });
            else
                return NotFound(new { Data = "Location not found" });
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLocation(Guid id)
        {
            bool status = Dbaccess.DeleteLocationById(id);

            if (status)
                return Ok(new { Data = "Location deleted successfully" });
            else
                return NotFound(new { Data = "Location not found" });
        }
    }
}
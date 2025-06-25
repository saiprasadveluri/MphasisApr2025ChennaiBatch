using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DbAccess _dbAccess;
        public LocationController(DbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }
        [HttpGet]
        public ActionResult<LocationDTO> GetAll()
        {
            List<LocationDTO> lst = _dbAccess.GetAllLocations();
            return Ok(new {Data = lst});
        }
        [HttpGet("id")]
        public ActionResult<LocationDTO> GetById(Guid id)
        {
            LocationDTO obj = _dbAccess.GetLocationById(id);
            if(obj != null)
            {
                return Ok(new {Data = obj});  
            }
            else
            {
                return NotFound(new {Data = "Error"});
            }

        }
        [HttpPut("id")]
        public ActionResult UpdateLocation( Guid id, LocationDTO inp )
        {
            bool Status = _dbAccess.UpdateLocation(id, inp);
            if (Status)
            {
                return Ok(new { Data = "Location successfully updated" });
            }
            else
            {
                return NotFound(new { Data = "Error in updating location" });
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteLocation( Guid id )
        {
            bool Status = _dbAccess.DeleteLocation(id);
            if (Status)
            {
                return Ok(new { Data = "Location successfully deleted" });
            }
            else
            {
                return Ok(new { Data = "Error in deleting location" });
            }
        }
        [HttpPost]
        public ActionResult AddLocation(LocationDTO inp)
        {
            bool Status = _dbAccess.AddLocation(inp);
            return Ok(new { Data = "Success in Adding location"});
        } 
    }
}

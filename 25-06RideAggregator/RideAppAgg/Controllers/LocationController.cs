using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DataAccess db;

        public LocationController(DataAccess dataAccess)
        {
            db = dataAccess;
        }

        [HttpGet]
        public ActionResult<Location> GetAllLocations()
        {
            // This method will return all locations
            // Implementation will be added later
            List<Location> locations = db.GetAllLocations();
            return Ok(locations);
        }

        [HttpGet("id")]
        public ActionResult<Location> GetLocationById(int id)
        {
           
            Location location = db.GetLocationById(id);
            if (location == null)
            {
                return NotFound($"Location with ID {id} not found.");
            }
            return Ok(location);
        }
        [HttpPost]

        public ActionResult<Location> AddLocation(Location location)
        {
            db.AddLocation(location);
            return Ok(location);

        }

        [HttpPost("id")]

        public ActionResult<Location> UpdateLocation(int id, Location location)
        {
            db.UpdateLocation(id, location);
            return Ok(location);
        }

        [HttpDelete("id")]

        public ActionResult DeleteLocation(int id)
        {
            db.DeleteLocation(id);
            return Ok($"Location with ID {id} deleted successfully.");
        }


    }
}

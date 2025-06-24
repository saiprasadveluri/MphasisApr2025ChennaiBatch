using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using RideAppApi.DataAccess;

namespace RideAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DataAccess dataAccess;
        public LocationController(DataAccess da)
        {
            this.dataAccess = da;
        }
        [HttpGet]
        public ActionResult GetAllLoc()
        {
            List<Location> l = dataAccess.GetAllLocations();
            return Ok(new {Data = l});
        }

        [HttpGet("Id")]
        public ActionResult GetId(int Id)
        {
            Location l = dataAccess.GetLocation(Id);
            if (l == null)
            {
                return NotFound();
            }
            return Ok(l);
        }

        [HttpPost]
        public ActionResult AddLoc(Location l)
        {
            dataAccess.AddLocation(l);
            return Ok(l);
        }

        [HttpPost("id")]
        public ActionResult UpdateLoc(int id ,Location l)
        {
            dataAccess.UpdateLocation(id,l);
            return Ok(l);
        }

        [HttpDelete("id")]
        public ActionResult DeleteLoc(int id,Location location)
        {
            dataAccess.DeleteLocation(id,location);
            return Ok(location);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        DataAccess db;
        public RideController(DataAccess dataAccess)
        {
            db = dataAccess;
        }
        [HttpGet]
        public ActionResult<List<Ride>> GetAllRides()
        {
            List<Ride> rides = db.GetAllRides();
            return Ok(rides);
        }
        [HttpGet("id")]
        public ActionResult<Ride> GetRideById(int id)
        {
            Ride ride = db.GetRideById(id);
            if (ride == null)
            {
                return NotFound($"Ride with ID {id} not found.");
            }
            return Ok(ride);
        }
        [HttpPost]
        public ActionResult<Ride> AddRide(Ride ride)
        {
            db.AddRide(ride);
            return Ok(ride);
        }
        [HttpPost("id")]
        public ActionResult<Ride> UpdateRide(int id, Ride ride)
        {
            db.UpdateRide(id, ride);
            return Ok(ride);
        }
        [HttpDelete("id")]
        public ActionResult DeleteRide(int id)
        {
            db.DeleteRide(id);
            return Ok($"Ride with ID {id} deleted successfully.");
        }
    }
}

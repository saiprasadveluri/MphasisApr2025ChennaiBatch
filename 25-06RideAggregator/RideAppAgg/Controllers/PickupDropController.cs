using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupDropController : ControllerBase
    {
        DataAccess db;

        public PickupDropController(DataAccess dataAccess)
        {
            db = dataAccess;
        }


        [HttpGet]
        public ActionResult<List<PickupDrop>> GetAllPickupDrops()
        {
            List<PickupDrop> pickupDrops = db.GetAllPickupDrops();
            return Ok(pickupDrops);
        }

        [HttpGet("id")]
        public ActionResult<PickupDrop> GetPickupDropById(int id)
        {
            PickupDrop pickupDrop = db.GetPickupDropById(id);
            if (pickupDrop == null)
            {
                return NotFound($"Pickup/Drop with ID {id} not found.");
            }
            return Ok(pickupDrop);
        }

        [HttpPost]
        public ActionResult<PickupDrop> AddPickupDrop(PickupDrop pickupDrop)
        {
            db.AddPickupDrop(pickupDrop);
            return Ok(pickupDrop);
        }

        [HttpPost("id")]
        public ActionResult<PickupDrop> UpdatePickupDrop(int id, PickupDrop pickupDrop)
        {
            db.UpdatePickupDrop(id, pickupDrop);
            return Ok(pickupDrop);
        }

        [HttpDelete("id")]
        public ActionResult DeletePickupDrop(int id)
        {
            db.DeletePickupDrop(id);
            return Ok($"Pickup/Drop with ID {id} deleted successfully.");
        }   
    }
}

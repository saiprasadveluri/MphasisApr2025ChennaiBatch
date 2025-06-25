using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregators.DataAccess;
using RideAggregators.DTO;

namespace RideAggregators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupRideController : ControllerBase
    {
        public DbAccess dbAccess;

        public PickupRideController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddPickupRide(PickupRideDTO data)
        {
            bool status = dbAccess.AddPickupRide(data);
            return Ok(new { data1 = "Pickup Rides added successfully" });
        }
        [HttpGet]

        public IActionResult GetAllPickupRide()
        {
            List<PickupRideDTO> PickUpRideData = dbAccess.GetAllPickupRide();
            return Ok(new { data = PickUpRideData });
        }
    }
}
   

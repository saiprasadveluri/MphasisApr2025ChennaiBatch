using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccessLayer;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupRideController : ControllerBase
    {
        DbAccess Dbaccess;
        public PickupRideController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpPost]
        public IActionResult AddPickupRide(PickupRideDTO data)
        {
            bool status = Dbaccess.AddPickupRide(data);
            return Ok(new { Data = "PickupRide Added Successfully" });

        }
        [HttpGet]

        public IActionResult GetAllPickupRides(PickupRideDTO data)
        {
            List<PickupRideDTO> pickuprides = Dbaccess.GetAllPickupRides();
            return Ok(new { Data = pickuprides });
        }

    }
}

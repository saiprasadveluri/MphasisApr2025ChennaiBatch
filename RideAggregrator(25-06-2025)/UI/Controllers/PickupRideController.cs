using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggerator.DTO;
using RideAggregatorAPI.DataAccess;

namespace RideAggerator.Controllers
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
        public IActionResult AddPickup(PickupRideDTO data)
        {
            bool status = Dbaccess.AddPickup(data);
            return Ok(new { data3 = "pickup added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllPickup()
        {
            List<PickupRideDTO> pickupList = Dbaccess.GetAllPickupRide();
            return Ok(pickupList);
        }
    }
}

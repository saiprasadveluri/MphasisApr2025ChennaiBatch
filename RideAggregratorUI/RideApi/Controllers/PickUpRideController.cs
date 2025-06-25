using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideApi.DataAccess;
using RideApi.DTO;

namespace RideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickUpRideController : ControllerBase
    {
        DbAccess dbaccess;
        public PickUpRideController(DbAccess db)
        {
            dbaccess = db;
        }
        [HttpPost]
        public IActionResult AddPickUp(PickUpRidesDTO data)
        {
            bool status = dbaccess.AddPickUp(data);
            return Ok(new { data = "Pickup added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllPickUpRides()
        {
            List<PickUpRidesDTO> PickupRide = dbaccess.GetAllPickUpRides();
            return Ok(new { data = PickupRide });
        }
    }
}

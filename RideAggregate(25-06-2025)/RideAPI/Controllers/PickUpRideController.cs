using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickUpRideController : ControllerBase
    {
        public DbAccess dbAccess;
        public PickUpRideController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddPickUp(PickUpRideDTO data)
        {
            bool status = dbAccess.AddPickUp(data);
            return Ok(new { result = status });
        }
        [HttpGet]
        public IActionResult GetAllPickUp()
        {
            List<PickUpRideDTO> pickList = dbAccess.GetAllPickUpRide();
            return Ok(new { result = pickList });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RideAggrigationAPI.DataAccess;
using RideAggrigationAPI.DTO;

namespace RideAggrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupDropController : ControllerBase
    {
        private readonly DbAccess _db;

        public PickupDropController(DbAccess db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllPicupDrops()
        {
            var data = _db.GetAllPickupDrops();
            return Ok(new { Data = data });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RideAggrigationAPI.DataAccess;
using RideAggrigationAPI.DTO;

namespace RideAggrigationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly DbAccess _db;

        public RentalController(DbAccess db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _db.GetAllRentals();
            return Ok(new { Data = data });
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRideController : ControllerBase
    {
        public DbAccess dbAccess;
        public RentalRideController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddRental(RentalRideDTO data)
        {
            bool status = dbAccess.AddRental(data);
            return Ok(new { result = status });
        }
        [HttpGet]
        public IActionResult GetAllRental()
        {
            List<RentalRideDTO> rentList = dbAccess.GetAllRental();
            return Ok(new { result = rentList });
        }
    }
}

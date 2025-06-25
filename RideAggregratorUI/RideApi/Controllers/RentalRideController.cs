using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideApi.DataAccess;
using RideApi.DTO;

namespace RideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRideController : ControllerBase
    {
        DbAccess dbaccess;
    
     public RentalRideController(DbAccess db)
        {
            dbaccess = db;
        }
        [HttpPost]
        public IActionResult AddRental(RentalRideDTO data)
        {
            bool status = dbaccess.AddRental(data);
            return Ok(new { data = "Rentalride added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllrentalRides()
        {
            List<RentalRideDTO> RentalRides = dbaccess.GetAllrentalRides();
            return Ok(new { data = RentalRides });
        }
    }
}

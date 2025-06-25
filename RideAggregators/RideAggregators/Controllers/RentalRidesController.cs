using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregators.DataAccess;
using RideAggregators.DTO;

namespace RideAggregators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRidesController : ControllerBase
    {
        public DbAccess dbAccess;

        public RentalRidesController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddRentalRides(RentalRidesDTO data)
        {
            bool status = dbAccess.AddRentalRide(data);
            return Ok(new { data1 = "Rental Rides added successfully" });
        }
        [HttpGet]

        public IActionResult GetAllRentalRides()
        {
            List<RentalRidesDTO> RentalRideData = dbAccess.GetAllRentalRides();
            return Ok(new { data = RentalRideData });
        }
    }
}


   
   

   

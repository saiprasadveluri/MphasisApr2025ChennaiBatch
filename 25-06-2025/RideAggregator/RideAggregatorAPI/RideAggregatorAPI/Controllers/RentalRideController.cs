using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccessLayer;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRideController : ControllerBase
    {
        DbAccess Dbaccess;
   
    
        public RentalRideController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpPost]
        public IActionResult AddRentalRide(RentalRideDTO data)
        {
            bool status = Dbaccess.AddRentalRide(data);
            return Ok(new { Data = "RentalRide Added Successfully" });

        }
        [HttpGet]
        public IActionResult GetAllRentalRides(RentalRideDTO data)
        {
            List<RentalRideDTO> users = Dbaccess.GetAllRentalRides();
            return Ok(new { data = users });
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggerator.DTO;
using RideAggregatorAPI.DataAccess;

namespace RideAggerator.Controllers
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
        public IActionResult AddRental(RentalRideDTO data)
        {
            bool status = Dbaccess.AddRental(data);
            return Ok(new { result = status });
        }
        [HttpGet]
        public IActionResult GetAllRental()
        {
            List<RentalRideDTO> RentalList = Dbaccess.GetAllRentalRide();
            return Ok(RentalList);
        }
    }
}

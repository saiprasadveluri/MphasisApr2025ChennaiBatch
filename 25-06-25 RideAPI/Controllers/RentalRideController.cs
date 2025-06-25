using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
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
        public IActionResult Add(RentalRideDTO dto)
        {
            bool result = Dbaccess.AddRentalRide(dto);
            return result ? Ok("Rental ride added successfully") : BadRequest("Failed to add ride");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var rides = Dbaccess.GetAllRentalRides();
            return Ok(rides);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var ride = Dbaccess.GetRentalRideById(id);
            return ride != null ? Ok(ride) : NotFound("Ride not found");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, RentalRideDTO dto)
        {
            bool result = Dbaccess.UpdateRentalRide(id, dto);
            return result ? Ok("Ride updated") : NotFound("Ride not found");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = Dbaccess.DeleteRentalRide(id);
            return result ? Ok("Ride deleted") : NotFound("Ride not found");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickupDropRideController : ControllerBase
    {
        DbAccess Dbaccess;
        public PickupDropRideController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        
        [HttpPost]
        public IActionResult Add(PickupDropRideDTO dto)
        {
            var result = Dbaccess.AddPickupDropRide(dto);
            return result ? Ok("Ride added successfully.") : BadRequest("Failed to add ride.");
        }

        // READ ALL
        [HttpGet]
        public IActionResult GetAll()
        {
            var rides = Dbaccess.GetAllPickupDropRides();
            return Ok(rides);
        }

        // READ BY ID
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var ride = Dbaccess.GetPickupDropRideById(id);
            return ride == null ? NotFound("Ride not found.") : Ok(ride);
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, PickupDropRideDTO dto)
        {
            var updated = Dbaccess.UpdatePickupDropRide(id, dto);
            return updated ? Ok("Ride updated successfully.") : NotFound("Ride not found.");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var deleted = Dbaccess.DeletePickupDropRide(id);
            return deleted ? Ok("Ride deleted successfully.") : NotFound("Ride not found.");
        }
    }
}

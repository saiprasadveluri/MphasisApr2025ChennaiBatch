using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideAggregatorAPI.Data.DBContext;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DataAccess data;
        private readonly RideDBContext _context;

        public LocationController(DataAccess _data)
        {
            data = _data;
        }
        [HttpGet]
        public IActionResult GetAllLocations()
        {

            var locations = data.GetAllLocations();
            return Ok(locations);
        }
        [HttpGet("{id}")]
        public IActionResult GetLocationById(Guid id)
        {
            var location=data.GetLocationByID(id);
            if(location == null) 
                return NotFound("Loaction not found");
            return Ok(location);
        }
        [HttpPost]
        public IActionResult AddLocations(LocationDTO dTO)
        {
            if (string.IsNullOrEmpty(data.Name))
              return BadRequest("Location name is required");
            var db = new DataAccess(_context);
            bool result = data.AddLocations(dTO);
            if (result)
                return Ok("Location added succesfully");
            else
                return StatusCode(500, "an error while adding locations");

        }
}
}

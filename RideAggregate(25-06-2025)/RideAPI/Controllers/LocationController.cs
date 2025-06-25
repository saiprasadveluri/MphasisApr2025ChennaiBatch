using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public DbAccess dbAccess;
        public LocationController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public ActionResult AddLocation(LocationDTO inp)
        {
            bool Status = dbAccess.AddLocation(inp);
            return Ok(new { Data = "Success in Adding location" });
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<LocationDTO> lst = dbAccess.GetAllLocations();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            LocationDTO obj = dbAccess.GetLocationById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
    }
}

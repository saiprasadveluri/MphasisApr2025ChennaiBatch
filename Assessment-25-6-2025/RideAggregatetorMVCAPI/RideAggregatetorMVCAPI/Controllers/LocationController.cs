using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        DataAccessLayer data;
        public LocationController(DataAccessLayer dbaccess) { 
            data= dbaccess;
        }
        [HttpPost]
        public ActionResult AddLocation(LocationDTO inp)
        {
            bool Status = data.AddLocation(inp);
            return Ok(new { Data = "Success in Adding location" });
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            List<LocationDTO> lst = data.GetAllLocations();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            LocationDTO obj = data.GetLocationById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
        //[HttpGet("delete")]
        //public ActionResult DeleteLocationById(Guid id)
        //{
        //    LocationDTO obj= data.GetLocationById(id);
        //   bool Status=data.RemoveLocation(id);
        //    return Ok("Location Deleted SuccessFully");
        //}
    }
}

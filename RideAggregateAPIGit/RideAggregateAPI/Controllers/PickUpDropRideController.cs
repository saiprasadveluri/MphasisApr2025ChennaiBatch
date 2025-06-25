using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.Data;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.DTO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace RideAggregateAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PickUpDropRideController : Controller
    {
        DBAccess Dbaccess;
        public PickUpDropRideController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAllRides()
        {
            List<PickUpDropRideDTO> lst = Dbaccess.GetAllRides();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetRideById(long id)
        {
            List<PickUpDropRideDTO> obj = Dbaccess.GetRideById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }

        [HttpPost]
        public ActionResult AddNewRide(PickUpDropRideDTO inp)
        {
            bool Status = Dbaccess.AddNewRide(inp);
            return Ok(new { Data = "Success in Adding a New Ride" });

        }
    }
        
}

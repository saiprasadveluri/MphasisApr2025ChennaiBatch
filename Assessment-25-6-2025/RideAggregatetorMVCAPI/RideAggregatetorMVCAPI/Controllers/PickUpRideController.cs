using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PickUpRideController : ControllerBase
    {
        DataAccessLayer data;
        public PickUpRideController(DataAccessLayer dbaccess)
        {
            data = dbaccess;
        }
        [HttpPost]
        public ActionResult AddPickUpRide(PickUpRideDTO inp)
        {
            bool Status = data.AddPickUpRide(inp);
            return Ok(new { Data = "Success in Adding Pickupride" });
        }
    }
}

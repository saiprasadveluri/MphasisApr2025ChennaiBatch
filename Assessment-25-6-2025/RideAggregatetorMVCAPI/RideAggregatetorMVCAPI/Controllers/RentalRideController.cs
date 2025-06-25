using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRideController : ControllerBase
    {
        DataAccessLayer data;
        public RentalRideController(DataAccessLayer dbaccess)
        {
            data = dbaccess;
        }
        [HttpPost]
        public ActionResult AddRentalRide(RentalRideDTO inp)
        {
            bool Status = data.AddRentalRide(inp);
            return Ok(new { Data = "Success in Adding  rentalride" });
        }
    }
}

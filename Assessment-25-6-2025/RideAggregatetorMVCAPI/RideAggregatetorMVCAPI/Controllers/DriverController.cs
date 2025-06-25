using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        DataAccessLayer data;
        public DriverController(DataAccessLayer dbaccess)
        {
            data = dbaccess;
        }
        [HttpPost]
        public ActionResult AddDriver(DriverDTO inp)
        {
            bool Status = data.AddDriver(inp);
            return Ok(new { Data = "Success in Adding driver" });
        }
        public ActionResult GetAll()
        {
            List<DriverDTO> lst = data.GetAllDrivers();
            return Ok(new { Data = lst });
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        DataAccess _dataAccess;
        public DriverController(DataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }
        [HttpGet]
        public ActionResult<Driver> GetDriversAll()
        {
            List<Driver> drivers = _dataAccess.GetAllDriver();
            return Ok(new { Data = drivers });
        }

        [HttpPost]
        public ActionResult AddDrivers(Driver driver)
        {
          
                if (driver != null)
                {
                    _dataAccess.AddDriver(driver);
                    return Ok(driver);
                }
                else
                {
                    return Ok("Please Add Input!!");
                }
  
        }
        [HttpPost("id")]
        public ActionResult UpdateDriver(int id, Driver driver)
        {
            try
            {
                if (driver != null && id != 0)
                {
                    _dataAccess.UpdateDrivers(id, driver);
                    return Ok(driver);
                }
                else
                {
                    return Ok("Please Add Input then it will Update!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteDriver(int id)
        {
            try
            {
                if (id != 0)
                {
                    _dataAccess.DeleteDriver(id);
                    return Ok();
                }
                else
                {
                    return Ok("Please Provide an id then it will Delete!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}

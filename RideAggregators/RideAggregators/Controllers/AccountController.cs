using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregators.DataAccess;
using RideAggregators.DTO;

namespace RideAggregators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        DbAccess dbAccess;

        public AccountController(DbAccess db)
        {
            dbAccess= db;
        }
        [HttpPost]
        public IActionResult AddUser(UserDataDTO data)
        {
            bool status = dbAccess .AddUser(data);
            return Ok(new { data = "user addded successfully" });
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserDataDTO> userData = dbAccess.GetAllUserData();
            return Ok(new { Data = userData });  
        }
    }
}

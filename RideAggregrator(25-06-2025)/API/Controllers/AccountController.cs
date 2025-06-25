using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggerator.DTO;
using RideAggregatorAPI.DataAccess;

namespace RideAggerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        DbAccess Dbaccess;
        public AccountController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpPost]
        public IActionResult AddUser(UserDataDTO data)
        {
            bool status = Dbaccess.AddUser(data);
            return Ok(new { data = "user added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserDataDTO> UserData = Dbaccess.GetAllUserData();
            return Ok(new {data=UserData});
        }
    }
}

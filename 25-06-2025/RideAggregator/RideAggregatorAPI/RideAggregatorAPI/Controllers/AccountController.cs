using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccessLayer;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
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
        public IActionResult AddUser(UserDTO data)
        {
            bool status = Dbaccess.AddUser(data);
            return Ok(new { Data = "User Added Successfully" });

        }
        [HttpGet]
        public IActionResult GetAllUsers(UserDTO data)
        {
            List<UserDTO> users = Dbaccess.GetAllUsers();
            return Ok(new {data= users});
        }

    }
}

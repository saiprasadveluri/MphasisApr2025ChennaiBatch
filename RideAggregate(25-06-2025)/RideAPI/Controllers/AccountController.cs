using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public DbAccess dbAccess;
        public AccountController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddUser(UserDataDTO data)
        {
            bool status = dbAccess.AddUser(data);
            return Ok(new {data="user added successfully"});
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserDataDTO> userData = dbAccess.GetAllUserData();
            return Ok(new { data = userData });
        }
    }
}

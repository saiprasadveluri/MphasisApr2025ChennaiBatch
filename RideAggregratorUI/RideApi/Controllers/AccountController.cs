using Microsoft.AspNetCore.Mvc;
using RideApi.DataAccess;
using RideApi.DTO;

namespace RideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        DbAccess dbaccess;
        public AccountController (DbAccess db)
        {
            dbaccess = db;
        }
        [HttpPost]
        public IActionResult AddUser(UserDataDTO data)
        {
            bool status = dbaccess.AddUser(data);
            return Ok(new { data = "User added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            List<UserDataDTO> userData = dbaccess.GetAllUserData();
            return Ok(new {data = userData});   
        }
    }
}

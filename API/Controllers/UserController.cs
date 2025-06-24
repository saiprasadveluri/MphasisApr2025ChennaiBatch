using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RideAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DataAccess _dataAccess;
        public UserController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;   
        }
        [HttpGet]
        public ActionResult<User> GetUsers()
        {
            List<User> users = _dataAccess.GetAllUsers();
            return Ok(new { Data = users });
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            try
            {
                if (user != null)
                {
                    _dataAccess.AddUsers(user);
                    return Ok(user);
                }
                else
                {
                    return Ok("Please Add Input!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpPost("id")]
        public ActionResult UpdateUser(int id,User user)
        {
            try
            {
                if (user != null && id != 0)
                {
                    _dataAccess.UpdateUsers(id,user);
                    return Ok(user);
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
        public ActionResult DeleteUser(int id)
        {
            try
            {
                if (id != 0)
                {
                    _dataAccess.DeleteUser(id);
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

using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.DTO;

namespace RideAggregateAPI.Controllers
{
    public class RentalsRideController : Controller
    {
        DBAccess Dbaccess;
        public RentalsRideController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        //[HttpGet]
        //public ActionResult GetAllOrders()
        //{
        //    List<UserDTO> lst = Dbaccess.GetAllOrders();
        //    return Ok(new { Data = lst });
        //}

        //[HttpPost]
        //public ActionResult AddUser(UserDTO inp)
        //{
        //    bool Status = Dbaccess.AddNewUser(inp);
        //    return Ok(new { Data = "Success in Adding User" });

        //}
    }
}

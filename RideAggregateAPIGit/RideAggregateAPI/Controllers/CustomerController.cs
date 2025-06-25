using Microsoft.AspNetCore.Mvc;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.DTO;

namespace RideAggregateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        DBAccess Dbaccess;
        public CustomerController(DBAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpGet]
        public ActionResult GetAllRides()
        {
            List<CustomerDTO> lst = Dbaccess.GetAllCustomers();
            return Ok(new { Data = lst });
        }

        [HttpPost]
        public ActionResult AddCustomer(CustomerDTO inp)
        {
            bool Status = Dbaccess.AddCustomer(inp);
            return Ok(new { Data = "Success in Adding Customer" });

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RideApi.DataAccess;
using RideApi.DTO;

namespace RideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        DbAccess dbaccess;
        public CustomerController(DbAccess db)
        {
            dbaccess = db;
        }
        [HttpPost]
        public IActionResult AddCustomer(CustomerDTO data)
        {
            bool status = dbaccess.AddCustomer(data);
            return Ok(new { data = "Customer added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            List<CustomerDTO> CustomerData = dbaccess.GetAllCustomers();
            return Ok(new { Data = CustomerData });
        }
    }
}

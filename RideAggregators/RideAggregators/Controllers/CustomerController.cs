using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregators.DataAccess;
using RideAggregators.DTO;

namespace RideAggregators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public DbAccess dbAccess;

        public CustomerController(DbAccess db)
        {
            dbAccess = db;
        }
        [HttpPost]
        public IActionResult AddCustomer(CustomerDTO data)
        {
            bool status = dbAccess.AddCustomer(data);
            return Ok(new { data1 = "customer added successfully" });
        }
        [HttpGet]

        public IActionResult GetAllCustomers()
        {
            List<CustomerDTO> CustomerData = dbAccess.GetAllCustomers();
            return Ok(new { data = CustomerData });
        }
    }
}


   
   

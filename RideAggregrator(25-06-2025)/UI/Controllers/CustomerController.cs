using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggerator.DTO;
using RideAggregatorAPI.DataAccess;

namespace RideAggerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DbAccess Dbaccess;
        public CustomerController(DbAccess dba)
        {
            Dbaccess = dba;
        }
        [HttpPost]
        public IActionResult AddCustomer(CustomerDataDTO data)
        {
            bool status = Dbaccess.AddCustomer(data);
            return Ok(new { data2 = "Customer added Successfully" });
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            List<CustomerDataDTO> CustomerData = Dbaccess.GetAllCustomerData();
            return Ok(new { data = CustomerData });
        }
    }
}

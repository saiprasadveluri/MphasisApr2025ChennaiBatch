using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccessLayer;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
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
        public IActionResult AddCustomer(CustomerDTO data)
        {
            bool status = Dbaccess.AddCustomer(data);
            return Ok(new { Data = "Customer Added Successfully" });

        }
        [HttpGet]

        public IActionResult GetAllCustomers(CustomerDTO data)
        {
            List<CustomerDTO> customers = Dbaccess.GetAllCustomers();
            return Ok(new { Data = customers });
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAPI.DataAccessLayer;
using RideAPI.DTO;

namespace RideAPI.Controllers
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
            return Ok(new { result = status });
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            List<CustomerDTO> custList=dbAccess.GetAllCustomers();
            return Ok(new {result=custList});
        }
    }
}

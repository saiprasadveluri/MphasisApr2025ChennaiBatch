using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppAgg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DataAccess db;
        public CustomerController(DataAccess dataAccess)
        {
            db = dataAccess;
        }
        [HttpGet]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            List<Customer> customers = db.GetAllCustomers();
            return Ok(customers);
        }
        [HttpGet("id")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            Customer customer = db.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound($"Customer with ID {id} not found.");
            }
            return Ok(customer);
        }
        [HttpPost]
        public ActionResult<Customer> AddCustomer(Customer customer)
        {
            db.AddCustomer(customer);
            return Ok(customer);
        }
        [HttpPost("id")]
        public ActionResult<Customer> UpdateCustomer(int id, Customer customer)
        {
            db.UpdateCustomer(id, customer);
            return Ok(customer);
        }
        [HttpDelete("id")]
        public ActionResult DeleteCustomer(int id)
        {
            db.DeleteCustomer(id);
            return Ok($"Customer with ID {id} deleted successfully.");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiderApp.DataAccess;
using RiderApp.DTO;

namespace RiderApp.Controllers
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
        [HttpGet]
        public ActionResult GetAll()
        {
            List<CustomerDTO> lst = Dbaccess.GetAllCustomer();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            CustomerDTO obj = Dbaccess.GetCustomerById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(Guid id)
        {
            bool status = Dbaccess.DeleteCustomerById(id);
            if (status)
            {
                return Ok(new { Data = "Successfully deleted customer" });
            }
            else
            {
                return NotFound(new { Data = "Customer not found" });
            }
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(Guid id, CustomerDTO updatedCustomer)
        {
            if (id != updatedCustomer.CustId)
            {
                return BadRequest(new { Data = "ID mismatch" });
            }

            bool status = Dbaccess.UpdateCustomer(updatedCustomer);
            if (status)
            {
                return Ok(new { Data = "Successfully updated customer" });
            }
            else
            {
                return NotFound(new { Data = "Customer not found" });
            }
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerDTO inp)
        {
            bool Status = Dbaccess.AddCustomer(inp);
            return Ok(new { Data = "Success in Adding customer" });
        }
    }
}

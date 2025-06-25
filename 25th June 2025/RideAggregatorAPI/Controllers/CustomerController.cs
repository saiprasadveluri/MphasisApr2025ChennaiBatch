using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPI.DataAccess;
using RideAggregatorAPI.DTO;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DbAccess _dbAccess;
        public CustomerController(DbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }
        [HttpGet]
        public ActionResult<CustomerDTO> GetALl()
        {
            List<CustomerDTO> lst = _dbAccess.GetAllCustomer();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult<CustomerDTO> GetById(Guid id)
        {
            CustomerDTO obj = _dbAccess.GetCustomerById(id);
            if (obj != null)
            {
                return Ok(new {Data = obj});
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerDTO inp)
        {
            bool Status = _dbAccess.AddCustomer(inp);
            return Ok(new { Data = "Success om adding customer" });
        }
        [HttpPut("id")]
        public ActionResult UpdateCustomer(Guid id, CustomerDTO inp)
        {
            bool Status = _dbAccess.UpdateCustomer(id, inp);
            if (Status)
            {
                return Ok(new { Data = "Customer successfully updated" });
            }
            else
            {
                return Ok(new { Data = "Error in updating customer" });
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteCustomer(Guid id)
        {
            bool Status = _dbAccess.DeleteCustomer(id);
            if (Status)
            {
                return Ok(new { Data = "Customer successfully deleted" });
            }
            else
            {
                return Ok(new { Data = "Error in deleting Customer" });
            }
        }
    }
}

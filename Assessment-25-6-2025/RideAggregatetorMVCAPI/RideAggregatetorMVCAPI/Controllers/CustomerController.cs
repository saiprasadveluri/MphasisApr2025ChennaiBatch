using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DataDTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RideAggregatetorMVCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DataAccessLayer data;
        public CustomerController(DataAccessLayer dbaccess)
        {
            data = dbaccess;
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerDTO inp)
        {
            bool Status = data.AddCustomer(inp);
            return Ok(new { Data = "Success in Adding customer" });
        }
        public ActionResult GetAll()
        {
            List<CustomerDTO> lst = data.GetAllCustomers();
            return Ok(new { Data = lst });
        }
        [HttpGet("{id}")]
        public ActionResult GetCById(Guid id)
        {
            CustomerDTO obj = data.GetCustById(id);
            if (obj != null)
            {
                return Ok(new { Data = obj });
            }
            else
            {
                return NotFound(new { Data = "Error" });
            }
        }
    }
}

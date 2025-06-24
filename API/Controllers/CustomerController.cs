using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RideAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DataAccess _dataAccess;
        public CustomerController(DataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }
        [HttpGet]
        public ActionResult<Customer> GetCustomer()
        {
            List<Customer> customers = _dataAccess.GetAllCustomerList();
            return Ok(new {Data = customers});
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            try
            {
                if (customer != null)
                {
                    _dataAccess.AddCustomer(customer);
                    return Ok(customer);
                }
                else
                {
                    return Ok("Please Add Input!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpPost("id")]
        public ActionResult UpdateCustomer(int id, Customer customer)
        {
            try
            {
                if (customer != null && id != 0)
                {
                    _dataAccess.UpdateCustomers(id,customer);
                    return Ok(customer);
                }
                else
                {
                    return Ok("Please Add Input then it will Update!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpDelete("id")]
        public ActionResult DeleteCustomer(int id)
        {
            try
            {
                if (id != 0)
                {
                    _dataAccess.DeleteCustomers(id);
                    return Ok();
                }
                else
                {
                    return Ok("Please Provide an id then it will Delete!!");
                }
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}

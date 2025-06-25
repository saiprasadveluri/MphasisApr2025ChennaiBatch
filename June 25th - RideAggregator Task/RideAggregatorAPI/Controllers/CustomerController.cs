using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideAggregator.API.Data;
using RideAggregatorCore.Models;

namespace RideAggregatorAPI.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly RideDbContext _context;

        public CustomerController(RideDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();
            if (customers == null || !customers.Any())
            {
                return NotFound();
            }
            else
            {
                return Ok(customers);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(customer);
            }
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut("{id}")]
        public void UpdateCustomer(int id, Customer customer)
        {
            var existingcust = _context.Customers.Where(l => l.Id == id).FirstOrDefault();
            if (existingcust != null)
            {
                existingcust.Name = customer.Name;
                existingcust.Email = customer.Email;
                _context.SaveChanges();
            }
        }
    }
}

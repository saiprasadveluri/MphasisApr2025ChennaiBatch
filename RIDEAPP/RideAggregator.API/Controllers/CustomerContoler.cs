using Microsoft.AspNetCore.Mvc;
using RideAggregator.core.Entities;
using RideAggregator.core.Entities;
using RideAggregator.core.Interfaces;

namespace RideAggregator.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IcustomerRepository _customerRepo;

        public CustomerController(IcustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetAll()
        {
            var customers = await _customerRepo.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetById(int id)
        {
            var customer = await _customerRepo.GetByIdAsync(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Customer customer)
        {
            await _customerRepo.AddAsync(customer);
            await _customerRepo.SaveAsync();
            return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Customer updatedCustomer)
        {
            var existing = await _customerRepo.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.FullName = updatedCustomer.FullName;
            existing.Email = updatedCustomer.Email;
            existing.PhoneNumber = updatedCustomer.PhoneNumber;

            _customerRepo.Update(existing);
            await _customerRepo.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var customer = await _customerRepo.GetByIdAsync(id);
            if (customer == null)
                return NotFound();

            _customerRepo.Delete(customer);
            await _customerRepo.SaveAsync();
            return NoContent();
        }
    }
}
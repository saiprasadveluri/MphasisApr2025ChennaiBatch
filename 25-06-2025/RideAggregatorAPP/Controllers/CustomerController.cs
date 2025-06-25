using Microsoft.AspNetCore.Mvc;
using RideAggregatorAPP.Data;
using RideAggregatorAPP.Models;
using RideAggregatorAPP.Services;
using Microsoft.EntityFrameworkCore;

namespace RideAggregatorAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer) =>
            Ok(await _service.CreateAsync(customer));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Customer customer) =>
            Ok(await _service.UpdateAsync(id, customer));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }



}

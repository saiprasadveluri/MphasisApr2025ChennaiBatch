using RideAggregatorApi.Data;
using RideAggregatorApi.Models;
using Microsoft.EntityFrameworkCore;


namespace RideAggregatorApi.Services.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly RideDbContext _context;
        public CustomerService(RideDbContext context) => _context = context;

        public async Task<List<Customer>> GetAllAsync() => await _context.Customers.ToListAsync();

        public async Task<Customer> GetByIdAsync(int id) =>
            await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);

        public async Task<Customer> CreateAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateAsync(int id, Customer updatedCustomer)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return null;

            customer.Name = updatedCustomer.Name;
            customer.Email = updatedCustomer.Email;
            customer.Phone = updatedCustomer.Phone;

            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}

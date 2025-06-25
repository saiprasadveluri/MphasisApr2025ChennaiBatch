using RideAggregatorApi.Models;
using Microsoft.Extensions.DependencyInjection;


namespace RideAggregatorApi.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> CreateAsync(Customer customer);
        Task<Customer> UpdateAsync(int id, Customer updatedCustomer);
        Task DeleteAsync(int id);
    }
}

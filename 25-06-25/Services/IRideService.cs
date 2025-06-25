using RideAggregatorApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace RideAggregatorApi.Services
{
    public interface IRideService
    {
        Task<List<Ride>> GetAllAsync();
        Task<Ride?> GetByIdAsync(int id);
        Task<List<Ride>> GetByCustomerIdAsync(int customerId);
        Task<List<Ride>> GetByDriverIdAsync(int driverId);
    }

}
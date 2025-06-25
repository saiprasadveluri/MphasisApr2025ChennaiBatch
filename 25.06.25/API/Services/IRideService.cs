using RideAggregatorApi.Models;
using Microsoft.Extensions.DependencyInjection;

namespace RideAggregatorApi.Services
{
    public interface IRideService
    {
        Task<List<RentalsRide>> GetAllAsync();
        Task<RentalsRide?> GetByIdAsync(int id);
        Task<List<RentalsRide>> GetByCustomerIdAsync(int customerId);
        Task<List<RentalsRide>> GetByDriverIdAsync(int driverId);

    }

}

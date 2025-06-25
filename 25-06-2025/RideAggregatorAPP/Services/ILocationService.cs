using RideAggregatorAPP.Models;
using Microsoft.Extensions.DependencyInjection;

namespace RideAggregatorAPP.Services
{
    public interface ILocationService
    {
        Task<List<Location>> GetAllAsync();
        Task<Location?> GetByIdAsync(int id);
        Task<Location> CreateAsync(Location location);
        Task<Location> UpdateAsync(int id, Location location);
        Task DeleteAsync(int id);
    }
}

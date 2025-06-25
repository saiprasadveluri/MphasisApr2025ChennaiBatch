using RideAggregatorAPP.Models;
using Microsoft.EntityFrameworkCore;


namespace RideAggregatorAPP.Services
{
    public interface IDriverService
    {
        Task<List<Driver>> GetAllAsync();
        Task<Driver?> GetByIdAsync(int id);
        Task<Driver> CreateAsync(Driver driver);
        Task<Driver> UpdateAsync(int id, Driver driver);
        Task DeleteAsync(int id);
    }
}

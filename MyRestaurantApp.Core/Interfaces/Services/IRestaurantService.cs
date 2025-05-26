using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Core.Models;

namespace MyRestaurantApp.Core.Interfaces.Services
{
    public interface IRestaurantService
    {
        Task<Restaurant> AddRestaurantAsync(Restaurant newRestaurant);
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        Task<Restaurant> GetRestaurantByIdAsync(Guid restaurantId);
        Task UpdateRestaurantAsync(Restaurant updatedRestaurant);
        Task DeleteRestaurantAsync(Guid restaurantId);
        Task<IEnumerable<Restaurant>> GetRestaurantsByOwnerAsync(Guid ownerUId);
        Task<IEnumerable<Restaurant>> SearchRestaurantsAsync(string searchTerm);
    }
}

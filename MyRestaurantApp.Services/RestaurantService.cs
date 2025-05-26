using MyRestaurantApp.Core.Interfaces.Services;
using MyRestaurantApp.Core.Interfaces;
using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<Restaurant> AddRestaurantAsync(Restaurant newRestaurant)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(newRestaurant.Name) || string.IsNullOrWhiteSpace(newRestaurant.Location))
            {
                throw new ArgumentException("Restaurant name and location cannot be empty.");
            }
            if (newRestaurant.MinOrderValue < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum order value cannot be negative.");
            }

            // Check for duplicate restaurant names (optional, depends on business rule)
            var existingRestaurants = await _restaurantRepository.GetAllAsync();
            if (existingRestaurants.Any(r => r.Name.Equals(newRestaurant.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ApplicationException($"A restaurant named '{newRestaurant.Name}' already exists.");
            }

            await _restaurantRepository.AddAsync(newRestaurant);
            return newRestaurant;
        }

        public Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync()
        {
            return _restaurantRepository.GetAllAsync();
        }

        public Task<Restaurant> GetRestaurantByIdAsync(Guid restaurantId)
        {
            return _restaurantRepository.GetByIdAsync(restaurantId);
        }

        public async Task UpdateRestaurantAsync(Restaurant updatedRestaurant)
        {
            if (string.IsNullOrWhiteSpace(updatedRestaurant.Name) || string.IsNullOrWhiteSpace(updatedRestaurant.Location))
            {
                throw new ArgumentException("Restaurant name and location cannot be empty.");
            }
            if (updatedRestaurant.MinOrderValue < 0)
            {
                throw new ArgumentOutOfRangeException("Minimum order value cannot be negative.");
            }

            var existingRestaurant = await _restaurantRepository.GetByIdAsync(updatedRestaurant.RId);
            if (existingRestaurant == null)
            {
                throw new KeyNotFoundException($"Restaurant with ID {updatedRestaurant.RId} not found.");
            }

            // You might add logic here to prevent changing owner etc.
            await _restaurantRepository.UpdateAsync(updatedRestaurant);
        }

        public async Task DeleteRestaurantAsync(Guid restaurantId)
        {
            var existingRestaurant = await _restaurantRepository.GetByIdAsync(restaurantId);
            if (existingRestaurant == null)
            {
                throw new KeyNotFoundException($"Restaurant with ID {restaurantId} not found for deletion.");
            }
            // In a real app, you'd also delete associated menu items, orders etc., or soft-delete.
            await _restaurantRepository.DeleteAsync(restaurantId);
        }

        public Task<IEnumerable<Restaurant>> GetRestaurantsByOwnerAsync(Guid ownerUId)
        {
            return _restaurantRepository.GetRestaurantsByOwnerIdAsync(ownerUId);
        }

        public async Task<IEnumerable<Restaurant>> SearchRestaurantsAsync(string searchTerm)
        {
            var allRestaurants = await _restaurantRepository.GetAllAsync();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return allRestaurants;
            }

            return allRestaurants.Where(r => r.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                                        r.Location.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }
    }
}
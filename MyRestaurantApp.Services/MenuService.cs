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
    public class MenuService : IMenuService
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IRestaurantRepository _restaurantRepository; // To validate restaurant exists

        public MenuService(IMenuItemRepository menuItemRepository, IRestaurantRepository restaurantRepository)
        {
            _menuItemRepository = menuItemRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<MenuItem> AddMenuItemAsync(MenuItem newMenuItem)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(newMenuItem.DishName) || newMenuItem.Price <= 0)
            {
                throw new ArgumentException("Dish name cannot be empty and price must be positive.");
            }

            // Ensure the restaurant exists
            var restaurant = await _restaurantRepository.GetByIdAsync(newMenuItem.RestaurantRId);
            if (restaurant == null)
            {
                throw new KeyNotFoundException($"Restaurant with ID {newMenuItem.RestaurantRId} not found.");
            }

            await _menuItemRepository.AddAsync(newMenuItem);
            return newMenuItem;
        }

        public Task<IEnumerable<MenuItem>> GetMenuItemsByRestaurantAsync(Guid restaurantId)
        {
            return _menuItemRepository.GetMenuItemsByRestaurantIdAsync(restaurantId);
        }

        public Task<MenuItem> GetMenuItemByIdAsync(Guid menuItemId)
        {
            return _menuItemRepository.GetByIdAsync(menuItemId);
        }

        public async Task UpdateMenuItemAsync(MenuItem updatedMenuItem)
        {
            if (string.IsNullOrWhiteSpace(updatedMenuItem.DishName) || updatedMenuItem.Price <= 0)
            {
                throw new ArgumentException("Dish name cannot be empty and price must be positive.");
            }

            var existingMenuItem = await _menuItemRepository.GetByIdAsync(updatedMenuItem.MId);
            if (existingMenuItem == null)
            {
                throw new KeyNotFoundException($"Menu item with ID {updatedMenuItem.MId} not found.");
            }

            // Ensure the restaurant still exists
            var restaurant = await _restaurantRepository.GetByIdAsync(updatedMenuItem.RestaurantRId);
            if (restaurant == null)
            {
                throw new KeyNotFoundException($"Restaurant with ID {updatedMenuItem.RestaurantRId} not found for menu item update.");
            }

            await _menuItemRepository.UpdateAsync(updatedMenuItem);
        }

        public async Task DeleteMenuItemAsync(Guid menuItemId)
        {
            var existingMenuItem = await _menuItemRepository.GetByIdAsync(menuItemId);
            if (existingMenuItem == null)
            {
                throw new KeyNotFoundException($"Menu item with ID {menuItemId} not found for deletion.");
            }
            await _menuItemRepository.DeleteAsync(menuItemId);
        }

        public async Task<IEnumerable<MenuItem>> SearchMenuItemsAsync(Guid restaurantId, string searchTerm)
        {
            var menuItems = await _menuItemRepository.GetMenuItemsByRestaurantIdAsync(restaurantId);
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return menuItems;
            }

            return menuItems.Where(mi => mi.DishName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
        }
    }
}
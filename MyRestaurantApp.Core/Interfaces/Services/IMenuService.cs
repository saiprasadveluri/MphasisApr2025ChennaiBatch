using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Core.Models;

namespace MyRestaurantApp.Core.Interfaces.Services
{
    public interface IMenuService
    {
        Task<MenuItem> AddMenuItemAsync(MenuItem newMenuItem);
        Task<IEnumerable<MenuItem>> GetMenuItemsByRestaurantAsync(Guid restaurantId);
        Task<MenuItem> GetMenuItemByIdAsync(Guid menuItemId);
        Task UpdateMenuItemAsync(MenuItem updatedMenuItem);
        Task DeleteMenuItemAsync(Guid menuItemId);
        Task<IEnumerable<MenuItem>> SearchMenuItemsAsync(Guid restaurantId, string searchTerm);
       // Task <MenuItem> FilterMenuItemsAsync(Guid restaurantId, string searchTerm,string dishType);

    }
}

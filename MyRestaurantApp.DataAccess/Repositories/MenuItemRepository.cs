using MyRestaurantApp.Core.Models;
using MyRestaurantApp.DataAccess.Repositoires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Core.Interfaces;

namespace MyRestaurantApp.DataAccess.Repositories
{
    public class MenuItemRepository : BaseRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository() : base(InMemoryDatabase.MenuItems) { }

        public Task<IEnumerable<MenuItem>> GetMenuItemsByRestaurantIdAsync(Guid restaurantRId)
        {
            return Task.FromResult(_data.Where(mi => mi.RestaurantRId == restaurantRId).AsEnumerable());
        }
    }
}

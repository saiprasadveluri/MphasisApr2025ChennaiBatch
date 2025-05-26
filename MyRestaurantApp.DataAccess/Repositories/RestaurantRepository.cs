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
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository() : base(InMemoryDatabase.Restaurants) { }

        public Task<IEnumerable<Restaurant>> GetRestaurantsByOwnerIdAsync(Guid ownerUId)
        {
            return Task.FromResult(_data.Where(r => r.OwnerUId == ownerUId).AsEnumerable());
        }
    }
}

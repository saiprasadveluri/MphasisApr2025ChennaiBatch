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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository() : base(InMemoryDatabase.Orders) { }

        public Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(Guid customerUId)
        {
            return Task.FromResult(_data.Where(o => o.CustomerUId == customerUId).AsEnumerable());
        }

        public Task<IEnumerable<Order>> GetOrdersByRestaurantIdAsync(Guid restaurantRId)
        {
            return Task.FromResult(_data.Where(o => o.RestaurantRId == restaurantRId).AsEnumerable());
        }
    }
}

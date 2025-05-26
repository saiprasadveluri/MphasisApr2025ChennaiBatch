using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(Guid customerUId);
        Task<IEnumerable<Order>> GetOrdersByRestaurantIdAsync(Guid restaurantRId);
    }
}

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
    public class OrderLineItemRepository : BaseRepository<OrderLineItem>, IOrderLineItemRepository
    {
        public OrderLineItemRepository() : base(InMemoryDatabase.OrderLineItems) { }

        public Task<IEnumerable<OrderLineItem>> GetLineItemsByOrderIdAsync(Guid orderOId)
        {
            return Task.FromResult(_data.Where(oli => oli.OId == orderOId).AsEnumerable());
        }
    }
}

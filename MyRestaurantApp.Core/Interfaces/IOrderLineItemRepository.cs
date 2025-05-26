using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces
{
    public interface IOrderLineItemRepository : IRepository<OrderLineItem>
    {
        Task<IEnumerable<OrderLineItem>> GetLineItemsByOrderIdAsync(Guid orderOId);
    }
}

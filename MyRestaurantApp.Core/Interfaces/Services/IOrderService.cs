using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces.Services
{
    public interface IOrderService
    {
        Task<Order> PlaceOrderAsync(Guid customerUId, Guid restaurantRId, List<OrderLineItem> lineItems, string couponCode = null);
        Task<IEnumerable<Order>> GetCustomerOrdersAsync(Guid customerUId);
        Task<IEnumerable<Order>> GetRestaurantOrdersAsync(Guid restaurantRId);
        Task<Order> GetOrderByIdAsync(Guid orderId);
        Task UpdateOrderStatusAsync(Guid orderId, OrderStatus newStatus);
        Task<Order> ApplyCouponToOrderAsync(Guid orderId, string couponCode); // For applying coupon after creation
    }
}

using MyRestaurantApp.Core.Interfaces.Services;
using MyRestaurantApp.Core.Interfaces;
using MyRestaurantApp.Core.Models;
using MyRestaurantApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderLineItemRepository _orderLineItemRepository;
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IUserRepository _userRepository; 
        private readonly IRestaurantRepository _restaurantRepository; 
        private readonly ICouponService _couponService; 
        public OrderService(
            IOrderRepository orderRepository,
            IOrderLineItemRepository orderLineItemRepository,
            IMenuItemRepository menuItemRepository,
            IUserRepository userRepository,
            IRestaurantRepository restaurantRepository,
            ICouponService couponService) 
        {
            _orderRepository = orderRepository;
            _orderLineItemRepository = orderLineItemRepository;
            _menuItemRepository = menuItemRepository;
            _userRepository = userRepository;
            _restaurantRepository = restaurantRepository;
            _couponService = couponService;
        }

        public async Task<Order> PlaceOrderAsync(Guid customerUId, Guid restaurantRId, List<OrderLineItem> lineItems, string couponCode = null)
        {
            if (!lineItems.Any())
            {
                throw new ArgumentException("Order must contain at least one item.");
            }

            var customer = await _userRepository.GetByIdAsync(customerUId);
            if (customer == null)
            {
                throw new KeyNotFoundException("Customer not found.");
            }

            var restaurant = await _restaurantRepository.GetByIdAsync(restaurantRId);
            if (restaurant == null)
            {
                throw new KeyNotFoundException("Restaurant not found.");
            }

            var newOrder = new Order
            {
                CustomerUId = customerUId,
                RestaurantRId = restaurantRId,
                Status = OrderStatus.Pending,
                OrderLineItems = new List<OrderLineItem>()
            };

            decimal totalOrderPrice = 0;
            foreach (var item in lineItems)
            {
                var menuItem = await _menuItemRepository.GetByIdAsync(item.MId);
                if (menuItem == null || menuItem.RestaurantRId != restaurantRId)
                {
                    throw new ArgumentException($"Menu item {item.MId} not found or does not belong to the specified restaurant.");
                }
                if (menuItem.AvailableQuantity < item.Quantity)
                {
                    throw new InvalidOperationException($"Not enough quantity for {menuItem.DishName}. Available: {menuItem.AvailableQuantity}");
                }

                item.OId = newOrder.OId;
                item.UnitPriceAtOrder = menuItem.Price;
                item.ValueForUnitAtOrder = menuItem.ValueForUnit;
                item.UnitsAtOrder = menuItem.Units;

                newOrder.OrderLineItems.Add(item);
                totalOrderPrice += item.Quantity * item.UnitPriceAtOrder;

       
                menuItem.AvailableQuantity -= item.Quantity;
                await _menuItemRepository.UpdateAsync(menuItem);
            }

            newOrder.TotalPrice = totalOrderPrice;

     
            if (!string.IsNullOrWhiteSpace(couponCode))
            {
                await ApplyCouponToOrderAsync(newOrder.OId, couponCode); 
            }

            await _orderRepository.AddAsync(newOrder);
            foreach (var item in newOrder.OrderLineItems)
            {
                await _orderLineItemRepository.AddAsync(item);
            }

            return newOrder;
        }

        public async Task<IEnumerable<Order>> GetCustomerOrdersAsync(Guid customerUId)
        {
            var orders = (await _orderRepository.GetOrdersByCustomerIdAsync(customerUId)).ToList();
            await PopulateOrderDetails(orders);
            return orders;
        }

        public async Task<IEnumerable<Order>> GetRestaurantOrdersAsync(Guid restaurantRId)
        {
            var orders = (await _orderRepository.GetOrdersByRestaurantIdAsync(restaurantRId)).ToList();
            await PopulateOrderDetails(orders);
            return orders;
        }

        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order != null)
            {
          
                order.OrderLineItems = (await _orderLineItemRepository.GetLineItemsByOrderIdAsync(order.OId)).ToList();
                foreach (var item in order.OrderLineItems)
                {
                    var menuItem = await _menuItemRepository.GetByIdAsync(item.MId);
           
                }
            }
            return order;
        }

        public async Task UpdateOrderStatusAsync(Guid orderId, OrderStatus newStatus)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new KeyNotFoundException($"Order with ID {orderId} not found.");
            }

          
            if (newStatus < order.Status) 
            {
                throw new InvalidOperationException($"Cannot change order status from {order.Status} to {newStatus}.");
            }

            order.Status = newStatus;
            await _orderRepository.UpdateAsync(order);
        }

        public async Task<Order> ApplyCouponToOrderAsync(Guid orderId, string couponCode)
        {
            if (string.IsNullOrWhiteSpace(couponCode))
            {
                throw new ArgumentException("Coupon code cannot be empty.");
            }

            var order = await GetOrderByIdAsync(orderId); 
            if (order == null)
            {
                throw new KeyNotFoundException($"Order with ID {orderId} not found.");
            }

            if (!string.IsNullOrWhiteSpace(order.AppliedCouponCode))
            {
                throw new InvalidOperationException($"Coupon '{order.AppliedCouponCode}' already applied to this order.");
            }

            var isValidCoupon = await _couponService.IsCouponValidAsync(couponCode, order.TotalPrice);
            if (!isValidCoupon)
            {
                throw new InvalidOperationException($"Coupon '{couponCode}' is not valid for this order or has expired.");
            }

            var coupon = await _couponService.GetCouponByCodeAsync(couponCode);
            if (coupon == null)
            {
                throw new KeyNotFoundException($"Coupon with code '{couponCode}' not found.");
            }

            decimal discountAmount = order.TotalPrice * (coupon.DiscountPercentage / 100M);
            order.AppliedDiscountAmount = discountAmount;
            order.AppliedCouponCode = couponCode;
            order.TotalPrice -= discountAmount;

            await _orderRepository.UpdateAsync(order);
            return order;
        }

        private async Task PopulateOrderDetails(List<Order> orders)
        {
            foreach (var order in orders)
            {
 
                order.OrderLineItems = (await _orderLineItemRepository.GetLineItemsByOrderIdAsync(order.OId)).ToList();

 
                order.CustomerUId = (await _userRepository.GetByIdAsync(order.CustomerUId))?.UId ?? Guid.Empty;
                order.RestaurantRId = (await _restaurantRepository.GetByIdAsync(order.RestaurantRId))?.RId ?? Guid.Empty; 

                 foreach (var lineItem in order.OrderLineItems)
                 {
                 var menuItem = await _menuItemRepository.GetByIdAsync(lineItem.MId);
              
                 }
            }
        }
    }
}
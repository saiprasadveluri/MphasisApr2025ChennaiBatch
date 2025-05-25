using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FoodDeliveryApp.Models
{
    public enum OrderStatus
    {
        Placed,
        Preparing,
        OnTheWay,
        Delivered
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; } = 0;
        public OrderStatus Status { get; set; } = OrderStatus.Placed;
    }

    public class OrderItem
    {
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_App.Entity;

namespace Food_App.Entity
{
    public class User
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
    }

    public class Restaurant
    {
        public int RId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal MinOrderValue { get; set; }
        public User Owner { get; set; }
    }

    public class MenuItem
    {
        public int MId { get; set; }
        public string DishName { get; set; }
        public string DishType { get; set; }
        public decimal UnitPrice { get; set; }
        public int ValueForUnit { get; set; }
        public string Units { get; set; }
        public int AvailableQuantity { get; set; } = 10;
        public Restaurant Restaurant { get; set; }
    }

    public class Order
    {
        public int OId { get; set; }
        public User Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<OrderLineItem> Items { get; set; } = new List<OrderLineItem>();
        public decimal Total { get; set; }
        public decimal CouponDiscount { get; set; }
        public string Status { get; set; } = "Pending";
    }

    public class OrderLineItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
    }
}

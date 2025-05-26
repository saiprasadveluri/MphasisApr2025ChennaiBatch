
using MyRestaurantApp.Core; 
using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyRestaurantApp.DataAccess.Repositoires
{
    public static class InMemoryDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
        public static List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public static List<Order> Orders { get; set; } = new List<Order>();
        public static List<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();
        public static List<CouponInfo> Coupons { get; set; } = new List<CouponInfo>();

        static InMemoryDatabase()
        {
            SeedData();
        }

        private static void SeedData()
        {
            // Clear existing data before seeding (important if called multiple times in tests)
            Users.Clear();
            Restaurants.Clear();
            MenuItems.Clear();
            Orders.Clear();
            OrderLineItems.Clear();
            Coupons.Clear();

            // Seed Users
            var adminUser = new User { DisplayName = "Admin User", Email = "admin@example.com", PasswordHash = "adminpass", Role = UserRole.Admin, Location = "Admin HQ" };
            var owner1 = new User { DisplayName = "Owner One", Email = "owner1@example.com", PasswordHash = "owner1pass", Role = UserRole.RestaurantOwner, Location = "Cityville" };
            var owner2 = new User { DisplayName = "Owner Two", Email = "owner2@example.com", PasswordHash = "owner2pass", Role = UserRole.RestaurantOwner, Location = "Townsville" };
            var appUser1 = new User { DisplayName = "Rajeev User", Email = "rajeev@example.com", PasswordHash = "rajeevpass", Role = UserRole.AppUser, Location = "Chennai" };
            var appUser2 = new User { DisplayName = "Priya User", Email = "priya@example.com", PasswordHash = "priya@123", Role = UserRole.AppUser, Location = "Chennai" };

            Users.AddRange(new[] { adminUser, owner1, owner2, appUser1, appUser2 });

            // Seed Restaurants
            var restaurant1 = new Restaurant { Name = "Tasty Bites", Location = "Chennai", MinOrderValue = 50.00M, OwnerUId = owner1.UId };
            var restaurant2 = new Restaurant { Name = "Curry Hub", Location = "Chennai", MinOrderValue = 75.00M, OwnerUId = owner1.UId };
            var restaurant3 = new Restaurant { Name = "Pizza Place", Location = "Bengaluru", MinOrderValue = 100.00M, OwnerUId = owner2.UId };

            Restaurants.AddRange(new[] { restaurant1, restaurant2, restaurant3 });

            // Seed Menu Items for Tasty Bites
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant1.RId, DishName = "Veg Biryani", DishType = DishType.Veg, Price = 180.00M, ValueForUnit = 1, Units = "plate", AvailableQuantity = 50 });
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant1.RId, DishName = "Chicken Curry", DishType = DishType.NonVeg, Price = 250.00M, ValueForUnit = 1, Units = "serving", AvailableQuantity = 30 });
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant1.RId, DishName = "Paneer Butter Masala", DishType = DishType.Veg, Price = 220.00M, ValueForUnit = 1, Units = "serving", AvailableQuantity = 40 });
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant1.RId, DishName = "Naan", DishType = DishType.Veg, Price = 40.00M, ValueForUnit = 1, Units = "each", AvailableQuantity = 100 });

            // Seed Menu Items for Curry Hub
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant2.RId, DishName = "Mutton Biryani", DishType = DishType.NonVeg, Price = 320.00M, ValueForUnit = 1, Units = "plate", AvailableQuantity = 25 });
            MenuItems.Add(new MenuItem { RestaurantRId = restaurant2.RId, DishName = "Fish Fry", DishType = DishType.NonVeg, Price = 180.00M, ValueForUnit = 1, Units = "piece", AvailableQuantity = 35 });

            // Seed Coupons
            Coupons.Add(new CouponInfo { CouponCode = "FIRSTORDER10", DiscountPercentage = 10, MinOrderValueRequired = 100, ExpiryDate = DateTime.Now.AddMonths(3), IsActive = true });
            Coupons.Add(new CouponInfo { CouponCode = "FREEDELIVERY", DiscountPercentage = 100, MinOrderValueRequired = 200, ExpiryDate = DateTime.Now.AddMonths(1), IsActive = true });

            // Seed a sample order (optional, for testing)
            var sampleOrder = new Order
            {
                CustomerUId = appUser1.UId,
                RestaurantRId = restaurant1.RId,
                Status = OrderStatus.Pending,
                TotalPrice = 0 // Will be calculated by service
            };
            sampleOrder.OrderLineItems.Add(new OrderLineItem
            {
                MId = MenuItems.First(mi => mi.DishName == "Veg Biryani").MId,
                Quantity = 1,
                UnitPriceAtOrder = MenuItems.First(mi => mi.DishName == "Veg Biryani").Price,
                ValueForUnitAtOrder = MenuItems.First(mi => mi.DishName == "Veg Biryani").ValueForUnit,
                UnitsAtOrder = MenuItems.First(mi => mi.DishName == "Veg Biryani").Units
            });
            sampleOrder.OrderLineItems.Add(new OrderLineItem
            {
                MId = MenuItems.First(mi => mi.DishName == "Naan").MId,
                Quantity = 2,
                UnitPriceAtOrder = MenuItems.First(mi => mi.DishName == "Naan").Price,
                ValueForUnitAtOrder = MenuItems.First(mi => mi.DishName == "Naan").ValueForUnit,
                UnitsAtOrder = MenuItems.First(mi => mi.DishName == "Naan").Units
            });
            sampleOrder.TotalPrice = sampleOrder.OrderLineItems.Sum(li => li.Quantity * li.UnitPriceAtOrder);
            Orders.Add(sampleOrder);
            OrderLineItems.AddRange(sampleOrder.OrderLineItems);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
    public enum DishType
    {
        Veg,
        NonVeg,
        Jain
    }

    public enum UnitType
    {
        Grams,
        Milliliters,
        Meters
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DishType DishType { get; set; }
        public decimal Price { get; set; }
        public int ValuePerUnit { get; set; }
        public UnitType Unit { get; set; }
        public int AvailableQuantity { get; set; } = 10;
        public int RestaurantId { get; set; }
    }
}
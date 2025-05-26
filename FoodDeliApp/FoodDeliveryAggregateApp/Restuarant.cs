using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    [Serializable]
    public class Restuarant
    {
        public string RestaurantName { get; set; }
        public List<MenuItem> MenuList { get; set; } = new List<MenuItem>();
        public Users RestOwner { get; set; }
        public Location RestLocation { get; set; }
        public Restuarant()
        {

        }
        public Restuarant(string name, Users restOwner, Location  restLocation)
        {
            RestaurantName = name;
            RestOwner = restOwner;
            RestLocation = restLocation;
        }

        public bool AddMenuItem(MenuItem item)
        {
            MenuItem menu = MenuList.Find(m => m.Name == item.Name);
            if (menu != null)
            {
                MenuList.Add(item);
                return true;
            }
            return false;
        }
    }
}


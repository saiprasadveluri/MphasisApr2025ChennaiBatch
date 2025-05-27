using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp2.Classes
{
    public class Restaurant
    {
        public string RestaurantName { get; set; }
        public List<MenuItem> MenuList { get; set; } = new List<MenuItem>();
        public Users RestOwner { get; set; }
        public Locations RestLocation { get; set; }
        public Restaurant()
        {

        }
        public Restaurant(string name, Users restOwner, Locations restLocation)
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

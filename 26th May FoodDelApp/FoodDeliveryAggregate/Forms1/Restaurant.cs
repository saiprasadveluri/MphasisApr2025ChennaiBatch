using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregate
{
    public class Restaurant
    {
        public int RestId { get; set; }
        public string RestName { get; set; }
        public List<Menu> MenuList { get; set; } = new List<Menu>();
        public Users RestOwner { get; set; }
        public Location RLocation { get; set; }
        public Restaurant()
        {

        }
        public Restaurant(string name, Users restOwner, Location restLocation)
        {
            RestName = name;
            RestOwner = restOwner;
            RLocation = restLocation;
        }

        public bool AddMenuItem(Menu item)
        {
            Menu menu = MenuList.Find(m => m.Name == item.Name);
            if (menu != null)
            {
                MenuList.Add(item);
                return true;
            }
            return false;
        }
    }
}

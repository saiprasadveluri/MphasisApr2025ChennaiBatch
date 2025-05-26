using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodDelForms.Lists
{
    public class Orders
    {
        public Restaurant Restaurant { get; set; }
        public List<OrderMenuEntry> OrderedMenuItem { get; set; }
        public Users OrderBy { get; set; }
        public Orders(Restaurant restaurant, List<OrderMenuEntry> orderedMenuItem, Users orderBy)
        {
            Restaurant = restaurant;
            OrderedMenuItem = orderedMenuItem;
            OrderBy = orderBy;
        }

    }
}
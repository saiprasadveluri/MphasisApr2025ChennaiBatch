using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodDeliveryAggregate.Lists
{
    public class Menu
    { 
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodTypeEnum FoodType { get; set; }
        public double UnitPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp2.Classes
{
    public class MenuItem
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodTypeEnum FoodType { get; set; }
        public double UnitPrice { get; set; }
    }
}

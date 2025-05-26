using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FoodApplication.FoodEnum;

namespace FoodApplication
{
    
    
        public class MenuItem
        {
            public int MenuId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public FoodEnum FoodType { get; set; }
            public double UnitPrice { get; set; }
        }
    }

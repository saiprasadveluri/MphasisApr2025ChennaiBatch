using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDelAPP.Models
{
    public class Restaurant
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal MinimumOrderValue { get; set; }
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        public override string ToString() => Name;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DishType { get; set; }
        public int Avileqty {  get; set; }
        public int RestaurantId {  get; set; }
    }
}

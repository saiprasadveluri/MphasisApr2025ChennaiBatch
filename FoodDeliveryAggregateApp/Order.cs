using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    public class Order
    {
        public User Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Orderitem> Items { get; set; }

        public Order(User customer,Restaurant restaurant, List<Orderitem> Items)
        {
            Customer = customer;
            Restaurant = restaurant;
            this.Items = Items;

        }

    }



    }

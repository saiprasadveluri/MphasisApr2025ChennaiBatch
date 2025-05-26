using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core
{
     public enum  OrderStatus
    {
        Pending,
        Confirmed,
        Preparing,
        ReadyForDelivery,
        OutForDelivery,
        Delivered,
        Cancelled

    }
}

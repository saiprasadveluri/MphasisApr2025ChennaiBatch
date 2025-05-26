using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
    public class Order
    {
        public Guid OId { get; set; }
        public Guid CustomerUId { get; set; }
        public Guid RestaurantRId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal AppliedDiscountAmount { get; set; } // If a coupon was used
        public string AppliedCouponCode { get; set; } // For reference
        public List<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

        public Order()
        {
            OId = Guid.NewGuid();
            OrderDate = DateTime.Now;
            Status = OrderStatus.Pending;
            AppliedDiscountAmount = 0;
        }
    }
}

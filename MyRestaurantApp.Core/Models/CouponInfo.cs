using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
    public class CouponInfo
    {
        public Guid CId { get; set; }
        public string CouponCode { get; set; } // e.g., "SAVE10", "FREEDELIVERY"
        public decimal DiscountPercentage { get; set; } // e.g., 10 for 10%
        public decimal? MinOrderValueRequired { get; set; } // Nullable, if no min order value
        public DateTime? ExpiryDate { get; set; } // Nullable, if no expiry
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }

        public CouponInfo()
        {
            CId = Guid.NewGuid();
            IsActive = true;
            DateCreated = DateTime.Now;
        }
    }
}

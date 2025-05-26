using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces.Services
{
    public interface ICouponService
    {
        Task<CouponInfo> AddCouponAsync(CouponInfo newCoupon);
        Task<IEnumerable<CouponInfo>> GetAllCouponsAsync();
        Task<CouponInfo> GetCouponByCodeAsync(string couponCode);
        Task UpdateCouponAsync(CouponInfo updatedCoupon);
        Task DeleteCouponAsync(Guid couponId);
        Task<bool> IsCouponValidAsync(string couponCode, decimal orderValue);
    }
}

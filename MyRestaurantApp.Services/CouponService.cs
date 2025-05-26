using MyRestaurantApp.Core.Interfaces.Services;
using MyRestaurantApp.Core.Interfaces;
using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Services
{
    public class CouponService : ICouponService
    {
        private readonly ICouponInfoRepository _couponInfoRepository;

        public CouponService(ICouponInfoRepository couponInfoRepository)
        {
            _couponInfoRepository = couponInfoRepository;
        }

        public async Task<CouponInfo> AddCouponAsync(CouponInfo newCoupon)
        {
            if (string.IsNullOrWhiteSpace(newCoupon.CouponCode))
            {
                throw new ArgumentException("Coupon code cannot be empty.");
            }
            if (newCoupon.DiscountPercentage <= 0 || newCoupon.DiscountPercentage > 100)
            {
                throw new ArgumentOutOfRangeException("Discount percentage must be between 1 and 100.");
            }

            var existingCoupon = await _couponInfoRepository.GetCouponByCodeAsync(newCoupon.CouponCode);
            if (existingCoupon != null)
            {
                throw new ApplicationException($"Coupon with code '{newCoupon.CouponCode}' already exists.");
            }

            await _couponInfoRepository.AddAsync(newCoupon);
            return newCoupon;
        }

        public Task<IEnumerable<CouponInfo>> GetAllCouponsAsync()
        {
            return _couponInfoRepository.GetAllAsync();
        }

        public Task<CouponInfo> GetCouponByCodeAsync(string couponCode)
        {
            return _couponInfoRepository.GetCouponByCodeAsync(couponCode);
        }

        public async Task UpdateCouponAsync(CouponInfo updatedCoupon)
        {
            if (string.IsNullOrWhiteSpace(updatedCoupon.CouponCode))
            {
                throw new ArgumentException("Coupon code cannot be empty.");
            }
            if (updatedCoupon.DiscountPercentage <= 0 || updatedCoupon.DiscountPercentage > 100)
            {
                throw new ArgumentOutOfRangeException("Discount percentage must be between 1 and 100.");
            }

            var existingCoupon = await _couponInfoRepository.GetByIdAsync(updatedCoupon.CId);
            if (existingCoupon == null)
            {
                throw new KeyNotFoundException($"Coupon with ID {updatedCoupon.CId} not found.");
            }

            if (!existingCoupon.CouponCode.Equals(updatedCoupon.CouponCode, StringComparison.OrdinalIgnoreCase))
            {
                var couponWithNewCode = await _couponInfoRepository.GetCouponByCodeAsync(updatedCoupon.CouponCode);
                if (couponWithNewCode != null)
                {
                    throw new ApplicationException($"A different coupon with code '{updatedCoupon.CouponCode}' already exists.");
                }
            }

            await _couponInfoRepository.UpdateAsync(updatedCoupon);
        }

        public async Task DeleteCouponAsync(Guid couponId)
        {
            var existingCoupon = await _couponInfoRepository.GetByIdAsync(couponId);
            if (existingCoupon == null)
            {
                throw new KeyNotFoundException($"Coupon with ID {couponId} not found for deletion.");
            }
            await _couponInfoRepository.DeleteAsync(couponId);
        }

        public async Task<bool> IsCouponValidAsync(string couponCode, decimal orderValue)
        {
            var coupon = await _couponInfoRepository.GetCouponByCodeAsync(couponCode);

            if (coupon == null || !coupon.IsActive)
            {
                return false;
            }

            if (coupon.ExpiryDate.HasValue && coupon.ExpiryDate.Value < DateTime.Now)
            {
                return false;
            }

            if (coupon.MinOrderValueRequired.HasValue && orderValue < coupon.MinOrderValueRequired.Value)
            {
                return false;
            }

            return true;
        }
    }
}
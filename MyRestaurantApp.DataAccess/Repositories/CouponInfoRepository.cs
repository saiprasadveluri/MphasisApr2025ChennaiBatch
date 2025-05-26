using MyRestaurantApp.Core.Models;
using MyRestaurantApp.DataAccess.Repositoires;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Core.Interfaces;

namespace MyRestaurantApp.DataAccess.Repositories
{
    public class CouponInfoRepository : BaseRepository<CouponInfo>, ICouponInfoRepository
    {
        public CouponInfoRepository() : base(InMemoryDatabase.Coupons) { }

        public Task<CouponInfo> GetCouponByCodeAsync(string code)
        {
            return Task.FromResult(_data.FirstOrDefault(c => c.CouponCode.Equals(code, System.StringComparison.OrdinalIgnoreCase)));
        }
    }
}

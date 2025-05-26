using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces
{
    public interface ICouponInfoRepository : IRepository<CouponInfo>
    {
        Task<CouponInfo> GetCouponByCodeAsync(string code);
    }
}

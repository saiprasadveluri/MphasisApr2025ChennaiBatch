using MyRestaurantApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetRestaurantsByOwnerIdAsync(Guid ownerUId);
    }
}

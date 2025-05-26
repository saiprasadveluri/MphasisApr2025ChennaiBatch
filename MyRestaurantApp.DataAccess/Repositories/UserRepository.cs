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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base(InMemoryDatabase.Users) { }

        public Task<User> GetUserByEmailAsync(string email)
        {
            return Task.FromResult(_data.FirstOrDefault(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase)));
        }
    }
}

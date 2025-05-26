using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Core.Models;

namespace MyRestaurantApp.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<User> RegisterUserAsync(string displayName, string email, string password, UserRole role, string location);
        Task<User> LoginAsync(string email, string password);   
    }
}

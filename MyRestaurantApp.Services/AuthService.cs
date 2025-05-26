using MyRestaurantApp.Core.Interfaces.Services;
using MyRestaurantApp.Core.Interfaces;
using MyRestaurantApp.Core.Models;
using MyRestaurantApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(string displayName, string email, string password, UserRole role, string location)
        {
            // Check if user with this email already exists
            var existingUser = await _userRepository.GetUserByEmailAsync(email);
            if (existingUser != null)
            {
                throw new ApplicationException("User with this email already exists.");
            }

            var newUser = new User
            {
                DisplayName = displayName,
                Email = email,
                PasswordHash = PasswordHasher.HashPassword(password), // Hash the password
                Role = role,
                Location = location
            };

            await _userRepository.AddAsync(newUser);
            return newUser;
        }

        public async Task<User> LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);

            if (user == null || !PasswordHasher.VerifyPassword(password, user.PasswordHash))
            {
                return null; // Login failed
            }

            return user; // Login successful
        }
    }
}

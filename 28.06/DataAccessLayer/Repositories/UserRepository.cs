using Book.Data.DB;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookMyShowDbContext _context;

        public UserRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserEmail == email);
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            
        }

        public async Task ChangePasswordAsync(int userId, string newPassword)
        {
            //var user = await _context.Users.FindAsync(userId);
            //if (user == null) return false;

            //user.Password = newPasswordHash;
            //await _context.SaveChangesAsync();
            //return true;
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                user.Password = newPassword;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ValidatePasswordAsync(int userId, string passwordHash)
        {
            var user = await _context.Users.FindAsync(userId);
            return user != null && user.Password== passwordHash;
        }

    }
}
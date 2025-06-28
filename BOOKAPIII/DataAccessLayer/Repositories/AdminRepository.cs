using Book.Data.DB;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccessLayer.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly BookMyShowDbContext _context;

        public AdminRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<Admin> CreateAsync(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
            return admin;
        }

        public async Task<Admin> GetByUsernameAsync(string username)
        {
            return await _context.Admins
                .FirstOrDefaultAsync(a => a.UserName == username);
        }

        public async Task<bool> DeleteAsync(int adminId)
        {
            var admin = await _context.Admins.FindAsync(adminId);
            if (admin == null) return false;

            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Admin> UpdateAsync(int adminId, Admin updatedAdmin)
        {
            var existing = await _context.Admins.FindAsync(adminId);
            if (existing == null) return null;

            existing.UserName = updatedAdmin.UserName;
            existing.Password = updatedAdmin.Password;

            await _context.SaveChangesAsync();
            return existing;
        }
        public async Task<IEnumerable<Admin>> GetAllAsync()
        {
            return await _context.Admins.ToListAsync();
        }


    }
}

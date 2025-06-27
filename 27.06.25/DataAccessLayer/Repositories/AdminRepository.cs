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
    }
}

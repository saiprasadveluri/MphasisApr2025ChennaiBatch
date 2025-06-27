using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAsync(Admin admin);
        Task<Admin> GetByUsernameAsync(string username);
    }
}

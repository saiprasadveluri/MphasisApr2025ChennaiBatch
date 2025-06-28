using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAsync(Admin admin);
        Task<Admin> GetByUsernameAsync(string username);
        Task<bool> DeleteAsync(int adminId);
        Task<Admin> UpdateAsync(int adminId, Admin updatedAdmin);

        Task<IEnumerable<Admin>> GetAllAsync();



    }
}

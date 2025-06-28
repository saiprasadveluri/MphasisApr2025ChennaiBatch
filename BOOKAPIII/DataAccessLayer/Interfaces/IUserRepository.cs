using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
        Task<User> CreateAsync(User user);
        Task UpdateAsync(User user);
        Task<bool> ValidatePasswordAsync(int userId, string currentPassword);
        Task ChangePasswordAsync(int userId, string newPassword);
        Task<bool> DeleteAsync(int userId);
        Task<IEnumerable<User>> GetAllAsync();


    }
}

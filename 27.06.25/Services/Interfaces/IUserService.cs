using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> RegisterAsync(UserDTO dto);
        Task<UserDTO> LoginAsync(LoginDTO dto);
        Task UpdateProfileAsync(int userId, UserDTO dto);
        Task ChangePasswordAsync(int userId, ChangePasswordDTO dto);
    }
}

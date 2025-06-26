using BookMyShowAPI.DTO;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;

namespace BookMyShowAPI.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResult> RegisterUserAsync(UserRegisterDto dto);
        Task<ServiceResult> LoginUserAsync(UserLoginDto dto);
        Task<ServiceResult> ResetPasswordAsync(ResetPasswordDto dto);
        Task<User> GetByEmailAsync(string email);
    }
}

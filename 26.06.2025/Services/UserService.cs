using BookMyShowAPI.DTO;
using BookMyShowAPI.Interfaces;
using BookMyShowApp.Models;
using Microsoft.AspNetCore.Identity;
using BookMyShowAPI.Repository.Interfaces;
using BookMyShowAPI.Helper;


namespace BookMyShowAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IOTPService _otpService;

        public UserService(IUserRepository repo, IOTPService otpService)
        {
            _repo = repo;
            _otpService = otpService;
        }

        public async Task<ServiceResult> RegisterUserAsync(UserRegisterDto dto)
        {
            var existing = await _repo.GetByEmailAsync(dto.Email);
            if (existing != null)
                return ServiceResult.Failure("Email already registered");

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password, // ideally, hash this
                City = dto.City
            };

            await _repo.AddAsync(user);
            return ServiceResult.Success("User registered");
        }

        public async Task<ServiceResult> LoginUserAsync(UserLoginDto dto)
        {
            var user = await _repo.GetByEmailAsync(dto.Email);
            if (user == null || user.Password != dto.Password)
                return ServiceResult.Failure("Invalid credentials");

            return ServiceResult.Success("Login successful");
        }

        public async Task<ServiceResult> ResetPasswordAsync(ResetPasswordDto dto)
        {
            var user = await _repo.GetByEmailAsync(dto.Email);
            if (user == null)
                return ServiceResult.Failure("Email not found");

            if (!_otpService.ValidateOtp(dto.Email, dto.Otp))
                return ServiceResult.Failure("Invalid OTP");

            user.Password = dto.NewPassword;
            await _repo.UpdateAsync(user);

            return ServiceResult.Success("Password updated");
        }

        public Task<User> GetByEmailAsync(string email) =>
            _repo.GetByEmailAsync(email);
    }
}

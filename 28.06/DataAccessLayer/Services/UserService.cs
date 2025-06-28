using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<UserDTO> RegisterAsync(UserDTO dto)
        {
            var user = _mapper.Map<User>(dto);
            return _mapper.Map<UserDTO>(await _repo.CreateAsync(user));
        }

        public async Task<UserDTO> LoginAsync(LoginDTO dto)
        {
            var user = await _repo.GetByUsernameAsync(dto.Username);
            return user != null && user.Password == dto.Password
                ? _mapper.Map<UserDTO>(user)
                : null;
        }

        public async Task UpdateProfileAsync(int userId, UserDTO dto)
        {
            var entity = _mapper.Map<User>(dto);
            entity.UserId = userId;
            await _repo.UpdateAsync(entity);
        }

        public async Task ChangePasswordAsync(int userId, ChangePasswordDTO dto)
        {
            var isValid = await _repo.ValidatePasswordAsync(userId, dto.CurrentPassword);
            if (!isValid) throw new Exception("Invalid current password");
            await _repo.ChangePasswordAsync(userId, dto.NewPassword);
        }
    }
}

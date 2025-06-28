using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repo;
        private readonly IMapper _mapper;

        public AdminService(IAdminRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<AdminDTO> RegisterAsync(AdminDTO dto)
        {
            var admin = _mapper.Map<Admin>(dto);
            return _mapper.Map<AdminDTO>(await _repo.CreateAsync(admin));
        }

        public async Task<AdminDTO> LoginAsync(AdminDTO dto)
        {
            var admin = await _repo.GetByUsernameAsync(dto.UserName);
            return (admin != null && admin.Password == dto.Password)
                ? _mapper.Map<AdminDTO>(admin)
                : null;
        }
        public async Task<bool> DeleteAsync(int adminId)
        {
            return await _repo.DeleteAsync(adminId);
        }

        public async Task<AdminDTO> UpdateAsync(int adminId, AdminDTO dto)
        {
            var admin = _mapper.Map<Admin>(dto);
            var updated = await _repo.UpdateAsync(adminId, admin);
            return updated != null ? _mapper.Map<AdminDTO>(updated) : null;
        }
        public async Task<IEnumerable<AdminDTO>> GetAllAsync()
        {
            var admins = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<AdminDTO>>(admins);
        }


    }
}

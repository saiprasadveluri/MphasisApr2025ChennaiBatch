using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IAdminService
    {
        Task<AdminDTO> RegisterAsync(AdminDTO adminDTO);
        Task<AdminDTO> LoginAsync(AdminDTO adminDTO);
        Task<bool> DeleteAsync(int adminId);
        Task<AdminDTO> UpdateAsync(int adminId, AdminDTO updatedDTO);
        Task<IEnumerable<AdminDTO>> GetAllAsync();




    }
}

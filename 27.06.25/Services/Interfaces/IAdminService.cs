using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IAdminService
    {
        Task<AdminDTO> RegisterAsync(AdminDTO adminDTO);
        Task<AdminDTO> LoginAsync(AdminDTO adminDTO);

    }
}

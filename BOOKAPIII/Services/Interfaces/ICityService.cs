using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetAllAsync();
        Task<CityDTO> CreateAsync(CityDTO dto);
        Task DeleteAsync(int cityId);
    }
}

using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ITheatreService
    {
        Task<IEnumerable<TheatreDTO>> GetByCityIdAsync(int cityId);
        Task<TheatreDTO> CreateAsync(TheatreDTO dto);
    }
}

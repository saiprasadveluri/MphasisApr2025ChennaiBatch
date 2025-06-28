using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ITheatreService
    {
        Task<IEnumerable<TheatreDTO>> GetByCityIdAsync(int cityId);
        Task<TheatreDTO> CreateAsync(TheatreDTO dto);
        Task<bool> DeleteAsync(int theatreId);
        Task<TheatreDTO> UpdateAsync(int theatreId, TheatreDTO dto);



    }
}

using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDTO>> GetAllAsync();
        Task<GenreDTO> CreateAsync(GenreDTO dto);
        Task DeleteAsync(int genreId);

    }
}

using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDTO>> GetAllAsync();
        Task<MovieDTO> GetByIdAsync(int id);
        Task<MovieDTO> CreateAsync(MovieDTO dto);
        Task UpdateAsync(int id, MovieDTO dto);
        Task DeleteAsync(int id);
    }
}

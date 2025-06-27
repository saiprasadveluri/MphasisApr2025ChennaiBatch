using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface IShowService
    {
        Task<IEnumerable<ShowDTO>> GetByMovieIdAsync(int movieId);
        Task<ShowDTO> AddAsync(ShowDTO dto);
    }
}

using BookMyShowAPI.DTO;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;

namespace BookMyShowAPI.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task<ServiceResult> CreateAsync(MovieDto dto);
        Task<ServiceResult> UpdateAsync(int id, MovieDto dto);
        Task<ServiceResult> DeleteAsync(int id);
    }
}

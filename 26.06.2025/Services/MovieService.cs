using BookMyShowAPI.DTO;
using BookMyShowAPI.Interfaces;
using BookMyShowApp.Models;
using BookMyShowAPI.Helper;
using BookMyShowAPI.Repository.Interfaces;

namespace BookMyShowAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repo;

        public MovieService(IMovieRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync() =>
            await _repo.GetAllAsync();

        public async Task<Movie> GetByIdAsync(int id) =>
            await _repo.GetByIdAsync(id);

        public async Task<ServiceResult> CreateAsync(MovieDto dto)
        {
            var movie = new Movie
            {
                Title = dto.Title,
                Description = dto.Description,
                Language = dto.Language,
                Genre = dto.Genre,
                ReleaseDate = dto.ReleaseDate
            };
            await _repo.AddAsync(movie);
            return ServiceResult.Success("Movie created");
        }

        public async Task<ServiceResult> UpdateAsync(int id, MovieDto dto)
        {
            var movie = await _repo.GetByIdAsync(id);
            if (movie == null)
                return ServiceResult.Failure("Not found");

            movie.Title = dto.Title;
            movie.Description = dto.Description;
            movie.Language = dto.Language;
            movie.Genre = dto.Genre;
            movie.ReleaseDate = dto.ReleaseDate;

            await _repo.UpdateAsync(movie);
            return ServiceResult.Success("Updated");
        }

        public async Task<ServiceResult> DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            return ServiceResult.Success("Deleted");
        }
    }
}

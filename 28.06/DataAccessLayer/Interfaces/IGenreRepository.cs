using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllAsync();
        Task<Genre> CreateAsync(Genre genre);
    }
}

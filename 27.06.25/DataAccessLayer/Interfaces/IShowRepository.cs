using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface IShowRepository
    {
        Task<IEnumerable<Show>> GetByMovieIdAsync(int movieId);
        Task<Show> AddAsync(Show show);
    }
}

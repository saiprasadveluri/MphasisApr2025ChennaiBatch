using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ITheatreRepository
    {
        Task<IEnumerable<Theatre>> GetByCityIdAsync(int cityId);
        Task<Theatre> CreateAsync(Theatre theatre);
    }
}

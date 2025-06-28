using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ITheatreRepository
    {
        Task<IEnumerable<Theatre>> GetByCityIdAsync(int cityId);
        Task<Theatre> CreateAsync(Theatre theatre);
        Task<bool> ExistsAsync(int theatreId);
        Task<bool> DeleteAsync(int theatreId);
        Task<Theatre> UpdateAsync(int theatreId, Theatre updatedTheatre);


    }
}

using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetAllAsync();
        Task<City> CreateAsync(City city);
    }
}

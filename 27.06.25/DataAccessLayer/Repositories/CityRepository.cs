using Book.Data.DB;
using Book.Data;
using Book.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Book.DataAccessLayer.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly BookMyShowDbContext _context;

        public CityRepository(BookMyShowDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAllAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _context.Cities.FindAsync(id);
        }
    }
}

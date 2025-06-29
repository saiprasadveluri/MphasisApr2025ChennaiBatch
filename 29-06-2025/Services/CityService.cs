using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class CityService: BookMyShowDbContext
    {
            public CityService(DbContextOptions<BookMyShowDbContext> options) : base(options)
            {
               
            }

            //*****Listing all Cities
            public async Task<List<CityDTO>> GetAllCitiesAsync()
            {
                return await this.Cities
                                     .Select(c => new CityDTO
                                     {
                                         CityId = c.CityId,
                                         CityName = c.CityName,
                                         State = c.State,
                                         Country = c.Country
                                     })
                                     .ToListAsync();
            }


            //***** getting City by ID
            public async Task<CityDTO> GetCityByIdAsync(int id)
            {
                var city = await this.Cities.FindAsync(id);

                if (city == null)
                {
                    return null;
                }

                return new CityDTO
                {
                    CityId = city.CityId,
                    CityName = city.CityName,
                    State = city.State,
                    Country = city.Country
                };
            }

            //**** Create new City
            public async Task<CityDTO> CreateCityAsync(CityDTO cityCreate)
            {
                var city = new City
                {
                    CityName = cityCreate.CityName,
                    State = cityCreate.State,
                    Country = cityCreate.Country
                };

                this.Cities.Add(city); // Access DbSet directly using 'this.Cities'
                int savedChanges = await this.SaveChangesAsync(); // Call base SaveChangesAsync

                if (savedChanges > 0)
                {
                    return new CityDTO
                    {
                        CityId = city.CityId,
                        CityName = city.CityName,
                        State = city.State,
                        Country = city.Country
                    };
                }
                return null;
            }

            //**** Delete City
            public async Task<bool> DeleteCityAsync(int id)
            {
                var cityToDelete = await this.Cities.FindAsync(id);

                if (cityToDelete == null)
                {
                    return false;
                }

                this.Cities.Remove(cityToDelete);
                int savedChanges = await this.SaveChangesAsync();

                return savedChanges > 0;
            }


        }
}

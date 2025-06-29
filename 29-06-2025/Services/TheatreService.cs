using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;
namespace Book.Services
{
    public class TheatreService : BookMyShowDbContext
    {
        public TheatreService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
        }
        //List 
        public async Task<List<TheatreDTO>> GetAllTheatresAsync()
        {
            return await this.Theatres
                             .Select(t => new TheatreDTO
                             {
                                 TheatreId = t.TheatreId,
                                 TheatreName = t.TheatreName,
                                 Location = t.Location,
                                 Address = t.Address,
                                 CityId = t.CityId,
                                 Capacity = t.Capacity,
                                 ScreenCount = t.ScreenCount
                             })
                             .ToListAsync();
        }
        //BY Id
        public async Task<TheatreDTO> GetTheatreByIdAsync(int id)
        {
            var theatre = await this.Theatres.FindAsync(id);

            if (theatre == null)
            {
                return null;
            }

            return new TheatreDTO
            {
                TheatreId = theatre.TheatreId,
                TheatreName = theatre.TheatreName,
                Location = theatre.Location,
                Address = theatre.Address,
                CityId = theatre.CityId,
                Capacity = theatre.Capacity,
                ScreenCount = theatre.ScreenCount
            };
        }
        //BY ID
        public async Task<List<TheatreDTO>> GetTheatresByCityIdAsync(int cityId)
        {
            return await this.Theatres
                             .Where(t => t.CityId == cityId)
                             .OrderBy(t => t.TheatreName)
                             .Select(t => new TheatreDTO
                             {
                                 TheatreId = t.TheatreId,
                                 TheatreName = t.TheatreName,
                                 Location = t.Location,
                                 Address = t.Address,
                                 CityId = t.CityId,
                                 Capacity = t.Capacity,
                                 ScreenCount = t.ScreenCount
                             })
                             .ToListAsync();
        }
        
        public async Task<TheatreDTO> CreateTheatreAsync(TheatreDTO theatreCreate)
        {
            if (string.IsNullOrWhiteSpace(theatreCreate.TheatreName))
            {
                throw new ArgumentException("TheatreName cannot be empty.", nameof(theatreCreate.TheatreName));
            }
            if (string.IsNullOrWhiteSpace(theatreCreate.Location))
            {
                throw new ArgumentException("Location cannot be empty.", nameof(theatreCreate.Location));
            }
            if (string.IsNullOrWhiteSpace(theatreCreate.Address))
            {
                throw new ArgumentException("Address cannot be empty.", nameof(theatreCreate.Address));
            }
            if (theatreCreate.CityId <= 0)
            {
                throw new ArgumentException("Invalid CityId.", nameof(theatreCreate.CityId));
            }
            if (theatreCreate.Capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative.", nameof(theatreCreate.Capacity));
            }
            if (theatreCreate.ScreenCount < 0)
            {
                throw new ArgumentException("ScreenCount cannot be negative.", nameof(theatreCreate.ScreenCount));
            }

            var cityExists = await this.Cities.AnyAsync(c => c.CityId == theatreCreate.CityId);
            if (!cityExists)
            {
                throw new InvalidOperationException($"City with ID {theatreCreate.CityId} not found.");
            }

            var existingTheatre = await this.Theatres
                                            .AnyAsync(t => t.TheatreName == theatreCreate.TheatreName &&
                                                           t.CityId == theatreCreate.CityId &&
                                                           t.Location == theatreCreate.Location);
            if (existingTheatre)
            {
                throw new InvalidOperationException($"A theatre with the name '{theatreCreate.TheatreName}' already exists in this city and location.");
            }

            var theatre = new Theatre
            {
                TheatreName = theatreCreate.TheatreName,
                Location = theatreCreate.Location,
                Address = theatreCreate.Address,
                CityId = theatreCreate.CityId,
                Capacity = theatreCreate.Capacity,
                ScreenCount = theatreCreate.ScreenCount
            };

            this.Theatres.Add(theatre);
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new TheatreDTO
                {
                    TheatreId = theatre.TheatreId,
                    TheatreName = theatre.TheatreName,
                    Location = theatre.Location,
                    Address = theatre.Address,
                    CityId = theatre.CityId,
                    Capacity = theatre.Capacity,
                    ScreenCount = theatre.ScreenCount
                };
            }
            return null;
        }

        public async Task<TheatreDTO> UpdateTheatreAsync(int id, TheatreDTO theatreUpdate)
        {
            var existingTheatre = await this.Theatres.FindAsync(id);

            if (existingTheatre == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(theatreUpdate.TheatreName))
            {
                throw new ArgumentException("TheatreName cannot be empty for update.", nameof(theatreUpdate.TheatreName));
            }
            if (string.IsNullOrWhiteSpace(theatreUpdate.Location))
            {
                throw new ArgumentException("Location cannot be empty for update.", nameof(theatreUpdate.Location));
            }
            if (string.IsNullOrWhiteSpace(theatreUpdate.Address))
            {
                throw new ArgumentException("Address cannot be empty for update.", nameof(theatreUpdate.Address));
            }
            if (theatreUpdate.CityId <= 0)
            {
                throw new ArgumentException("Invalid CityId for update.", nameof(theatreUpdate.CityId));
            }
            if (theatreUpdate.Capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative for update.", nameof(theatreUpdate.Capacity));
            }
            if (theatreUpdate.ScreenCount < 0)
            {
                throw new ArgumentException("ScreenCount cannot be negative for update.", nameof(theatreUpdate.ScreenCount));
            }

            if (existingTheatre.CityId != theatreUpdate.CityId)
            {
                var cityExists = await this.Cities.AnyAsync(c => c.CityId == theatreUpdate.CityId);
                if (!cityExists)
                {
                    throw new InvalidOperationException($"City with ID {theatreUpdate.CityId} not found for update.");
                }
            }

            var duplicateTheatre = await this.Theatres
                                             .AnyAsync(t => t.TheatreName == theatreUpdate.TheatreName &&
                                                            t.CityId == theatreUpdate.CityId &&
                                                            t.Location == theatreUpdate.Location &&
                                                            t.TheatreId != id);
            if (duplicateTheatre)
            {
                throw new InvalidOperationException($"Another theatre with the name '{theatreUpdate.TheatreName}' already exists in this city and location.");
            }

            existingTheatre.TheatreName = theatreUpdate.TheatreName;
            existingTheatre.Location = theatreUpdate.Location;
            existingTheatre.Address = theatreUpdate.Address;
            existingTheatre.CityId = theatreUpdate.CityId;
            existingTheatre.Capacity = theatreUpdate.Capacity;
            existingTheatre.ScreenCount = theatreUpdate.ScreenCount;

            this.Entry(existingTheatre).State = EntityState.Modified;
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new TheatreDTO
                {
                    TheatreId = existingTheatre.TheatreId,
                    TheatreName = existingTheatre.TheatreName,
                    Location = existingTheatre.Location,
                    Address = existingTheatre.Address,
                    CityId = existingTheatre.CityId,
                    Capacity = existingTheatre.Capacity,
                    ScreenCount = existingTheatre.ScreenCount
                };
            }
            return null;
        }

        public async Task<bool> DeleteTheatreAsync(int id)
        {
            var theatreToDelete = await this.Theatres.FindAsync(id);

            if (theatreToDelete == null)
            {
                return false;
            }

            var hasShows = await this.Shows.AnyAsync(s => s.TheatreId == id);
            if (hasShows)
            {
                throw new InvalidOperationException($"Cannot delete Theatre {id} as it has associated shows.");
            }

            var hasSeats = await this.Seats.AnyAsync(s => s.TheatreId == id);
            if (hasSeats)
            {
                throw new InvalidOperationException($"Cannot delete Theatre {id} as it has associated seats.");
            }

            this.Theatres.Remove(theatreToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}
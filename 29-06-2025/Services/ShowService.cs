using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class ShowService : BookMyShowDbContext
    {
        public ShowService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
        }

        public async Task<List<ShowDTO>> GetAllShowsAsync()
        {
            return await this.Shows
                             .Select(s => new ShowDTO
                             {
                                 ShowId = s.ShowId,
                                 ShowDate = s.ShowDate,
                                 ShowTime = s.ShowTime,
                                 AvailableSeates = s.AvailableSeates,
                                 Price = s.Price,
                                 TheatreId = s.TheatreId
                             })
                             .ToListAsync();
        }
        //** By Id
        public async Task<ShowDTO> GetShowByIdAsync(int id)
        {
            var show = await this.Shows.FindAsync(id);

            if (show == null)
            {
                return null;
            }

            return new ShowDTO
            {
                ShowId = show.ShowId,
                ShowDate = show.ShowDate,
                ShowTime = show.ShowTime,
                AvailableSeates = show.AvailableSeates,
                Price = show.Price,
                TheatreId = show.TheatreId
            };
        }

        //Theaters by Date 
        public async Task<List<ShowDTO>> GetShowsByTheatreAndDateAsync(int theatreId, DateTime? date = null)
        {
            var query = this.Shows.Where(s => s.TheatreId == theatreId);

            if (date.HasValue)
            {
                query = query.Where(s => s.ShowDate.Date == date.Value.Date);
            }

            return await query
                             .OrderBy(s => s.ShowDate)
                             .ThenBy(s => s.ShowTime)
                             .Select(s => new ShowDTO
                             {
                                 ShowId = s.ShowId,
                                 ShowDate = s.ShowDate,
                                 ShowTime = s.ShowTime,
                                 AvailableSeates = s.AvailableSeates,
                                 Price = s.Price,
                                 TheatreId = s.TheatreId
                             })
                             .ToListAsync();
        }


    
        public async Task<ShowDTO> UpdateShowAsync(int id, ShowDTO showUpdate)
        {
            var existingShow = await this.Shows.FindAsync(id);

            if (existingShow == null)
            {
                return null;
            }

            if (showUpdate.ShowDate == default(DateTime))
            {
                throw new ArgumentException("ShowDate cannot be default for update.", nameof(showUpdate.ShowDate));
            }
            if (showUpdate.AvailableSeates < 0)
            {
                throw new ArgumentException("AvailableSeats cannot be negative for update.", nameof(showUpdate.AvailableSeates));
            }
            if (showUpdate.Price < 0)
            {
                throw new ArgumentException("Price cannot be negative for update.", nameof(showUpdate.Price));
            }
            if (showUpdate.TheatreId <= 0)
            {
                throw new ArgumentException("Invalid TheatreId for update.", nameof(showUpdate.TheatreId));
            }

            if (existingShow.TheatreId != showUpdate.TheatreId)
            {
                var theatreExists = await this.Theatres.AnyAsync(t => t.TheatreId == showUpdate.TheatreId);
                if (!theatreExists) { throw new InvalidOperationException("Specified new TheatreId does not exist."); }
            }

            var duplicateShow = await this.Shows
                                          .AnyAsync(s => s.TheatreId == showUpdate.TheatreId &&
                                                         s.ShowDate == showUpdate.ShowDate &&
                                                         s.ShowTime == showUpdate.ShowTime &&
                                                         s.ShowId != id);
            if (duplicateShow)
            {
                throw new InvalidOperationException($"A show already exists for Theatre {showUpdate.TheatreId} at {showUpdate.ShowDate.ToShortDateString()} {showUpdate.ShowTime}.");
            }

            existingShow.ShowDate = showUpdate.ShowDate.Date;
            existingShow.ShowTime = showUpdate.ShowTime;
            existingShow.AvailableSeates = showUpdate.AvailableSeates;
            existingShow.Price = showUpdate.Price;
            existingShow.TheatreId = showUpdate.TheatreId;

            this.Entry(existingShow).State = EntityState.Modified;
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new ShowDTO
                {
                    ShowId = existingShow.ShowId,
                    ShowDate = existingShow.ShowDate,
                    ShowTime = existingShow.ShowTime,
                    AvailableSeates = existingShow.AvailableSeates,
                    Price = existingShow.Price,
                    TheatreId = existingShow.TheatreId
                };
            }
            return null;
        }

        //Delete Show
        public async Task<bool> DeleteShowAsync(int id)
        {
            var showToDelete = await this.Shows.FindAsync(id);

            if (showToDelete == null)
            {
                return false;
            }

            this.Shows.Remove(showToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}
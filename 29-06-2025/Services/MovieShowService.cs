using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;


namespace Book.Services
{
    public class MovieShowService // Make sure it does NOT inherit from BookMyShowDbContext
    {
        private readonly BookMyShowDbContext _context; // Inject DbContext

        public MovieShowService(BookMyShowDbContext context)
        {
            _context = context;
        }

        // --- READ Operations ---

        public async Task<List<MovieShowDTO>> GetAllMovieShowsIdOnlyAsync()
        {
            return await _context.MovieShows
                                 .Select(ms => new MovieShowDTO
                                 {
                                     MovieShowId = ms.MovieShowId,
                                     MovieId = ms.MovieId,
                                     ShowId = ms.ShowId,
                                     TheatreId = ms.TheatreId
                                 })
                                 .ToListAsync();
        }

        public async Task<MovieShowDTO> GetMovieShowIdOnlyByIdAsync(int id)
        {
            var movieShow = await _context.MovieShows
                                      .AsNoTracking() // Use AsNoTracking for read-only operations for performance
                                      .FirstOrDefaultAsync(ms => ms.MovieShowId == id);

            if (movieShow == null)
            {
                return null;
            }

            return new MovieShowDTO
            {
                MovieShowId = movieShow.MovieShowId,
                MovieId = movieShow.MovieId,
                ShowId = movieShow.ShowId,
                TheatreId = movieShow.TheatreId
            };
        }

        public async Task<List<MovieShowDTO>> GetMovieShowsIdOnlyByMovieIdAsync(int movieId)
        {
            return await _context.MovieShows
                                 .AsNoTracking()
                                 .Where(ms => ms.MovieId == movieId)
                                 .Select(ms => new MovieShowDTO
                                 {
                                     MovieShowId = ms.MovieShowId,
                                     MovieId = ms.MovieId,
                                     ShowId = ms.ShowId,
                                     TheatreId = ms.TheatreId
                                 })
                                 .ToListAsync();
        }


        public async Task<List<MovieShowDTO>> GetMovieShowsIdOnlyByShowIdAsync(int showId)
        {
            return await _context.MovieShows
                                 .AsNoTracking()
                                 .Where(ms => ms.ShowId == showId)
                                 .Select(ms => new MovieShowDTO
                                 {
                                     MovieShowId = ms.MovieShowId,
                                     MovieId = ms.MovieId,
                                     ShowId = ms.ShowId,
                                     TheatreId = ms.TheatreId
                                 })
                                 .ToListAsync();
        }

        // --- CREATE Operation ---
        public async Task<MovieShowDTO> CreateMovieShowAsync(MovieShowDTO movieShowCreateDto)
        {
            // Basic validation (more detailed validation can be in DTO annotations or a validator class)
            if (movieShowCreateDto == null)
            {
                throw new ArgumentNullException(nameof(movieShowCreateDto));
            }

            // Check if Movie, Show, and Theatre actually exist
            var movieExists = await _context.Movies.AnyAsync(m => m.MovieId == movieShowCreateDto.MovieId);
            if (!movieExists)
            {
                throw new InvalidOperationException($"Movie with ID {movieShowCreateDto.MovieId} not found.");
            }

            var showExists = await _context.Shows.AnyAsync(s => s.ShowId == movieShowCreateDto.ShowId);
            if (!showExists)
            {
                throw new InvalidOperationException($"Show with ID {movieShowCreateDto.ShowId} not found.");
            }

            var theatreExists = await _context.Theatres.AnyAsync(t => t.TheatreId == movieShowCreateDto.TheatreId);
            if (!theatreExists)
            {
                throw new InvalidOperationException($"Theatre with ID {movieShowCreateDto.TheatreId} not found.");
            }

            // Check for existing combination (unique constraint)
            var existingMovieShow = await _context.MovieShows
                                              .AnyAsync(ms => ms.MovieId == movieShowCreateDto.MovieId &&
                                                             ms.ShowId == movieShowCreateDto.ShowId &&
                                                             ms.TheatreId == movieShowCreateDto.TheatreId);
            if (existingMovieShow)
            {
                throw new InvalidOperationException("A movie show with this Movie, Show, and Theatre combination already exists.");
            }

            var movieShow = new MovieShow
            {
                MovieId = movieShowCreateDto.MovieId,
                ShowId = movieShowCreateDto.ShowId,
                TheatreId = movieShowCreateDto.TheatreId,
                
            };

            _context.MovieShows.Add(movieShow);
            await _context.SaveChangesAsync(); // Save to get the generated MovieShowId

            return new MovieShowDTO
            {
                MovieShowId = movieShow.MovieShowId, // Now populated
                MovieId = movieShow.MovieId,
                ShowId = movieShow.ShowId,
                TheatreId = movieShow.TheatreId
            };
        }

        // --- UPDATE Operation ---
        public async Task<MovieShowDTO> UpdateMovieShowAsync(int id, MovieShowDTO movieShowUpdateDto)
        {
            var existingMovieShow = await _context.MovieShows.FindAsync(id);

            if (existingMovieShow == null)
            {
                return null; // Not found
            }

            // Basic validation
            if (movieShowUpdateDto == null)
            {
                throw new ArgumentNullException(nameof(movieShowUpdateDto));
            }

            // Check if new Movie, Show, and Theatre IDs exist
            // Only re-check if the IDs are actually changing
            if (existingMovieShow.MovieId != movieShowUpdateDto.MovieId)
            {
                var movieExists = await _context.Movies.AnyAsync(m => m.MovieId == movieShowUpdateDto.MovieId);
                if (!movieExists)
                {
                    throw new InvalidOperationException($"Movie with ID {movieShowUpdateDto.MovieId} not found for update.");
                }
            }

            if (existingMovieShow.ShowId != movieShowUpdateDto.ShowId)
            {
                var showExists = await _context.Shows.AnyAsync(s => s.ShowId == movieShowUpdateDto.ShowId);
                if (!showExists)
                {
                    throw new InvalidOperationException($"Show with ID {movieShowUpdateDto.ShowId} not found for update.");
                }
            }

            if (existingMovieShow.TheatreId != movieShowUpdateDto.TheatreId)
            {
                var theatreExists = await _context.Theatres.AnyAsync(t => t.TheatreId == movieShowUpdateDto.TheatreId);
                if (!theatreExists)
                {
                    throw new InvalidOperationException($"Theatre with ID {movieShowUpdateDto.TheatreId} not found for update.");
                }
            }

            // Check for duplicate combination after update (excluding current record)
            var duplicateMovieShow = await _context.MovieShows
                                               .AnyAsync(ms => ms.MovieId == movieShowUpdateDto.MovieId &&
                                                              ms.ShowId == movieShowUpdateDto.ShowId &&
                                                              ms.TheatreId == movieShowUpdateDto.TheatreId &&
                                                              ms.MovieShowId != id); // Exclude the current record
            if (duplicateMovieShow)
            {
                throw new InvalidOperationException("Another movie show with this Movie, Show, and Theatre combination already exists.");
            }

            // Apply updates
            existingMovieShow.MovieId = movieShowUpdateDto.MovieId;
            existingMovieShow.ShowId = movieShowUpdateDto.ShowId;
            existingMovieShow.TheatreId = movieShowUpdateDto.TheatreId;
            

            await _context.SaveChangesAsync();

            return new MovieShowDTO
            {
                MovieShowId = existingMovieShow.MovieShowId,
                MovieId = existingMovieShow.MovieId,
                ShowId = existingMovieShow.ShowId,
                TheatreId = existingMovieShow.TheatreId
            };
        }

        // --- DELETE Operation ---
        public async Task<bool> DeleteMovieShowAsync(int id)
        {
            var movieShowToDelete = await _context.MovieShows.FindAsync(id);

            if (movieShowToDelete == null)
            {
                return false; // Not found
            }

            // Prevent deletion if associated with bookings (important for data integrity)
            var hasBookings = await _context.Bookings.AnyAsync(b => b.MovieShowId == id);
            if (hasBookings)
            {
                throw new InvalidOperationException($"Cannot delete MovieShow {id} as it has associated bookings. Please delete bookings first.");
            }

            _context.MovieShows.Remove(movieShowToDelete);
            int savedChanges = await _context.SaveChangesAsync();

            return savedChanges > 0;
        }
    }
}
using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class MovieService: BookMyShowDbContext
    {
        public MovieService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {

        }
        //**** list of movies
        public async Task<List<MovieDTO>> GetAllMoviesAsync()
        {
            return await this.Movies
                             .Select(m => new MovieDTO
                             {
                                 MovieId = m.MovieId,
                                 Title = m.Title,
                                 Description = m.Description,
                                 GenreId = m.GenreId,
                                 ReleaseDate = m.ReleaseDate
                             })
                             .ToListAsync();
        }

        //***By Id
        public async Task<MovieDTO> GetMovieByIdAsync(int id)
        {
            var movie = await this.Movies.FindAsync(id);

            if (movie == null)
            {
                return null;
            }

            return new MovieDTO
            {
                MovieId = movie.MovieId,
                Title = movie.Title,
                Description = movie.Description,
                GenreId = movie.GenreId,
                ReleaseDate = movie.ReleaseDate
            };
        }

        //******Create Operation
        public async Task<MovieDTO> CreateMovieAsync(MovieDTO movieCreate)
        {
           
            if (string.IsNullOrWhiteSpace(movieCreate.Title))
            {
                throw new ArgumentException("Movie title cannot be empty or whitespace.", nameof(movieCreate.Title));
            }
            if (movieCreate.GenreId <= 0) // Assuming GenreId must be a positive integer
            {
                throw new ArgumentException("Invalid GenreId.", nameof(movieCreate.GenreId));
            }
            var movie = new Movie
            {
                Title = movieCreate.Title,
                Description = movieCreate.Description,
                GenreId = movieCreate.GenreId,
                ReleaseDate = movieCreate.ReleaseDate
            };

            this.Movies.Add(movie);
            int savedChanges = await this.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new MovieDTO
                {
                    MovieId = movie.MovieId, 
                    Title = movie.Title,
                    Description = movie.Description,
                    GenreId = movie.GenreId,
                    ReleaseDate = movie.ReleaseDate
                };
            }
            return null;
        }

       
        //****Delete Operation

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movieToDelete = await this.Movies.FindAsync(id);

            if (movieToDelete == null)
            {
                return false; // Movie not found
            }

            this.Movies.Remove(movieToDelete);
            int savedChanges = await this.SaveChangesAsync();

            return savedChanges > 0;
        }

    }
}

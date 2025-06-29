using Book.Data;
using Book.Data.DB;
using Book.DTO;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class GenreService : BookMyShowDbContext
    {
        public GenreService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
            
        }

        // ***** Listing all Genres
        public async Task<List<GenreDTO>> GetAllGenresAsync()
        {
            return await this.Genres 
                             .Select(g => new GenreDTO
                             {
                                 GenreId = g.GenreId,
                                 GenreName = g.GenreName 
                             })
                             .ToListAsync();
        }

        // ***** Getting Genre by ID
        public async Task<GenreDTO> GetGenreByIdAsync(int id)
        {
            var genre = await this.Genres.FindAsync(id);

            if (genre == null)
            {
                return null; 
            }

            return new GenreDTO
            {
                GenreId = genre.GenreId,
                GenreName = genre.GenreName
            };
        }

        // **** Create new Genre
        public async Task<GenreDTO> CreateGenreAsync(GenreDTO genreCreate)
        {
            
            if (string.IsNullOrWhiteSpace(genreCreate.GenreName))
            {
                throw new ArgumentException("Genre name cannot be empty.");
            }

            var genre = new Genre
            {
                
                GenreName = genreCreate.GenreName
                
            };

            this.Genres.Add(genre); 
            int savedChanges = await this.SaveChangesAsync(); 

            if (savedChanges > 0)
            {
                
                return new GenreDTO
                {
                    GenreId = genre.GenreId, 
                    GenreName = genre.GenreName
                };
            }
            return null; 
        }


        // **** Delete Genre
        public async Task<bool> DeleteGenreAsync(int id)
        {
            var genreToDelete = await this.Genres.FindAsync(id);

            if (genreToDelete == null)
            {
                return false; 
            }

            this.Genres.Remove(genreToDelete); 
            int savedChanges = await this.SaveChangesAsync(); 

            return savedChanges > 0; 
        }
    }
}
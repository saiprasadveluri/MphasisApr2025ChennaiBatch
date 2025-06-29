using Book.Data; 
using Book.Data.DB; 
using Book.DTO;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class LanguageService : BookMyShowDbContext
    {
        public LanguageService(DbContextOptions<BookMyShowDbContext> options) : base(options)
        {
            
        }
        //** list of all Lnaguages
        public async Task<List<LanguageDTO>> GetAllLanguagesAsync()
        {
            return await this.Languages 
                             .Select(l => new LanguageDTO 
                             {
                                 LanguageId = l.LanguageId,
                                 LanguageName = l.LanguageName
                             })
                             .ToListAsync(); 
        }

       //**********by Id
        public async Task<LanguageDTO> GetLanguageByIdAsync(int id)
        {
            var language = await this.Languages.FindAsync(id); 

            if (language == null)
            {
                return null; 
            }

            return new LanguageDTO 
            {
                LanguageId = language.LanguageId,
                LanguageName = language.LanguageName
            };
        }

        //********* Create Operation
        public async Task<LanguageDTO> CreateLanguageAsync(LanguageDTO languageCreate)
        {

            if (string.IsNullOrWhiteSpace(languageCreate.LanguageName))
            {
                throw new ArgumentException("Language name cannot be empty.", nameof(languageCreate.LanguageName));
            }

            var language = new Language
            {
                LanguageName = languageCreate.LanguageName
            };

            this.Languages.Add(language); 
            int savedChanges = await this.SaveChangesAsync(); 

            if (savedChanges > 0)
            {
                return new LanguageDTO
                {
                    LanguageId = language.LanguageId,
                    LanguageName = language.LanguageName
                };
            }
            return null; 
        }

        //****Delete 
        public async Task<bool> DeleteLanguageAsync(int id)
        {
            var languageToDelete = await this.Languages.FindAsync(id); // Find the language entity to delete.

            if (languageToDelete == null)
            {
                return false; // Return false if the language was not found.
            }

            this.Languages.Remove(languageToDelete); // Mark the entity for removal.
            int savedChanges = await this.SaveChangesAsync(); // Persist the deletion to the database.

            return savedChanges > 0; // Return true if at least one record was affected (deleted).
        }
    }
}
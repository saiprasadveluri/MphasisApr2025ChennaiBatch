using Book.Data;

namespace Book.DataAccessLayer.Interfaces
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> GetAllAsync();
        Task<Language> CreateAsync(Language language);
    }
}

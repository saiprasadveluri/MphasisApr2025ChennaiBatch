using Book.DTO;

namespace Book.Services.Interfaces
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageDTO>> GetAllAsync();
        Task<LanguageDTO> CreateAsync(LanguageDTO dto);
        Task DeleteAsync(int languageId);

    }
}

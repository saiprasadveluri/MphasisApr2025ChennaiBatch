using Book.Data;
using Book.DTO;
using Book.Services.Interfaces;
using AutoMapper;
using Book.DataAccessLayer.Interfaces;

namespace Book.DataAccessLayer.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _repo;
        private readonly IMapper _mapper;

        public LanguageService(ILanguageRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LanguageDTO>> GetAllAsync()
            => _mapper.Map<IEnumerable<LanguageDTO>>(await _repo.GetAllAsync());

        public async Task<LanguageDTO> CreateAsync(LanguageDTO dto)
        {
            var entity = _mapper.Map<Language>(dto);
            var created = await _repo.CreateAsync(entity);
            return _mapper.Map<LanguageDTO>(created);
        }
    }
}

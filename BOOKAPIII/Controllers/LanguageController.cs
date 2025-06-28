using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService _service;

        public LanguageController(ILanguageService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(LanguageDTO dto)
            => Ok(await _service.CreateAsync(dto));


        [HttpDelete("{languageId}")]
        public async Task<IActionResult> Delete(int languageId)
        {
            await _service.DeleteAsync(languageId);
            return NoContent();
        }
    }
}

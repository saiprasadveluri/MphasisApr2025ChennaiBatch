using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TheatreController : ControllerBase
    {
        private readonly ITheatreService _service;

        public TheatreController(ITheatreService service)
        {
            _service = service;
        }

        [HttpGet("city/{cityId}")]
        public async Task<IActionResult> GetByCity(int cityId)
            => Ok(await _service.GetByCityIdAsync(cityId));

        [HttpPost]
        public async Task<IActionResult> Create(TheatreDTO dto)
            => Ok(await _service.CreateAsync(dto));
    }
}

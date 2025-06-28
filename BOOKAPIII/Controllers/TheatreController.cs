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


        [HttpDelete("{theatreId}")]
        public async Task<IActionResult> Delete(int theatreId)
        {
            var deleted = await _service.DeleteAsync(theatreId);
            return deleted ? NoContent() : NotFound();
        }
        [HttpPut("{theatreId}")]
        public async Task<IActionResult> Update(int theatreId, TheatreDTO dto)
        {
            var updated = await _service.UpdateAsync(theatreId, dto);
            return updated != null ? Ok(updated) : NotFound();
        }

    }
}

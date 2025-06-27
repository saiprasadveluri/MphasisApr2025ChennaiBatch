using Book.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShowController : ControllerBase
    {
        private readonly IShowService _service;

        public ShowController(IShowService service)
        {
            _service = service;
        }

        [HttpGet("movie/{movieId}")]
        public async Task<IActionResult> GetByMovie(int movieId)
            => Ok(await _service.GetByMovieIdAsync(movieId));

        [HttpPost]
        public async Task<IActionResult> Add(ShowDTO dto)
            => Ok(await _service.AddAsync(dto));
    }
}

using Microsoft.AspNetCore.Mvc;
using BookMyShowAPI.Interfaces;
using BookMyShowAPI.DTO;

namespace BookMyShowAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _movieService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) =>
            Ok(await _movieService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(MovieDto movie) =>
            Ok(await _movieService.CreateAsync(movie));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MovieDto movie) =>
            Ok(await _movieService.UpdateAsync(id, movie));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) =>
            Ok(await _movieService.DeleteAsync(id));
    }
}
using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;

namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewController(IReviewService service)
        {
            _service = service;
        }

        [HttpGet("movie/{movieId}")]
        public async Task<IActionResult> GetByMovie(int movieId)
            => Ok(await _service.GetByMovieAsync(movieId));

        [HttpPost]
        public async Task<IActionResult> Add(ReviewDTO dto)
            => Ok(await _service.AddAsync(dto));

        [HttpDelete("{commentId}")]
        public async Task<IActionResult> Delete(int commentId)
        {
            await _service.DeleteAsync(commentId);
            return NoContent();
        }
        [HttpPut("{commentId}")]
        public async Task<IActionResult> Update(int commentId, ReviewDTO dto)
        {
            var updated = await _service.UpdateAsync(commentId, dto);
            return updated != null ? Ok(updated) : NotFound();
        }

    }
}

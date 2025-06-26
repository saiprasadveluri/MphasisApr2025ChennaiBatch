using Microsoft.AspNetCore.Mvc;
using BookMyShowAPI.Interfaces;
using BookMyShowAPI.DTO;

namespace BookMyShowAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("rate")]
        public async Task<IActionResult> Rate(RatingDto dto) =>
            Ok(await _reviewService.AddRatingAsync(dto));

        [HttpPost("review")]
        public async Task<IActionResult> Review(ReviewDto dto) =>
            Ok(await _reviewService.AddReviewAsync(dto));

        [HttpPost("comment")]
        public async Task<IActionResult> Comment(CommentDto dto) =>
            Ok(await _reviewService.AddCommentAsync(dto));

        [HttpGet("movie/{movieId}")]
        public async Task<IActionResult> GetReviews(int movieId) =>
            Ok(await _reviewService.GetReviewsByMovieAsync(movieId));
    }
}
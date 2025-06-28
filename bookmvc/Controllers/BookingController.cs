using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class BookingController : Controller
    {
        private readonly HttpClient _client;

        public BookingController(IHttpClientFactory factory, IConfiguration config)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri(config["ApiBaseUrl"]);
        }

        public async Task<IActionResult> BookTicket()
        {
            ViewBag.Cities = await _client.GetFromJsonAsync<List<CityDTO>>("api/City");
            return View();
        }

        public async Task<JsonResult> GetTheatres(int cityId)
        {
            var result = await _client.GetFromJsonAsync<List<TheatreDTO>>($"api/Theatre/byCity/{cityId}");
            return Json(result);
        }

        public async Task<JsonResult> GetMovies(int theatreId)
        {
            var result = await _client.GetFromJsonAsync<List<MovieDTO>>($"api/Movie/byTheatre/{theatreId}");
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmBooking(BookingModel model)
        {
            await _client.PostAsJsonAsync("api/Booking", model);
            return RedirectToAction("MyBookings", "User");
        }
    }
}

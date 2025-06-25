using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;

namespace RideAggregatorMVC.Controllers
{
    public class LocationController : Controller
    {
        private readonly LocationService _locationService;

        public LocationController(LocationService locationService)
        {
            _locationService = locationService;
        }

        public async Task<IActionResult> Index()
        {
            var locations = await _locationService.GetAllAsync();
            return View(locations);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            if (!ModelState.IsValid)
                return View(location);

            await _locationService.CreateAsync(location);
            TempData["SuccessMessage"] = "Location added successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}

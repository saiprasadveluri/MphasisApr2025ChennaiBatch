using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregator.MVC.Controllers
{
    public class LocationController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public LocationController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var locations = await client.GetFromJsonAsync<List<Location>>("/api/Location");
            return View(locations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PostAsJsonAsync("/api/Location", location);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error adding location.";
            return View(location);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var location = await client.GetFromJsonAsync<Location>($"/api/Location/{id}");
            return View(location);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Location location)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PutAsJsonAsync($"/api/Location/{location.Id}", location);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error updating location.";
            return View(location);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.DeleteAsync($"/api/Location/{id}");
            return RedirectToAction("Index");
        }
    }
}
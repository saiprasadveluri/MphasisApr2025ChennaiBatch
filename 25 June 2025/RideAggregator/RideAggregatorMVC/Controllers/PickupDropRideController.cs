using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregator.MVC.Controllers
{
    public class PickupDropRideController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public PickupDropRideController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var pickupdroprides = await client.GetFromJsonAsync<List<PickupDropRide>>("/api/PickupDropRide");
            return View(pickupdroprides);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PickupDropRide pickupdropride)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PostAsJsonAsync("/api/PickupDropRide", pickupdropride);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error adding pickup drop ride.";
            return View(pickupdropride);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var pickupdropride = await client.GetFromJsonAsync<PickupDropRide>($"/api/PickupDropRide/{id}");
            return View(pickupdropride);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PickupDropRide pickupdropride)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PutAsJsonAsync($"/api/PickupDropRide/{pickupdropride.Id}", pickupdropride);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error updating pickup drop ride.";
            return View(pickupdropride);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.DeleteAsync($"/api/PickupDropRide/{id}");
            return RedirectToAction("Index");
        }
    }
}
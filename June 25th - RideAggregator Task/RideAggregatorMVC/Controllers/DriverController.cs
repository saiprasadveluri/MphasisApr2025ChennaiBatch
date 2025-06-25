using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregator.MVC.Controllers
{
    public class DriverController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public DriverController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var drivers = await client.GetFromJsonAsync<List<Driver>>("/api/Driver");
            return View(drivers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Driver driver)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PostAsJsonAsync("/api/Driver", driver);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error creating driver.";
            return View(driver);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var driver = await client.GetFromJsonAsync<Driver>($"/api/Driver/{id}");
            return View(driver);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Driver driver)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PutAsJsonAsync($"/api/Driver/{driver.Id}", driver);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error updating customer.";
            return View(driver);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.DeleteAsync($"/api/Driver/{id}");
            return RedirectToAction("Index");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace RideAggregator.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public CustomerController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var customers = await client.GetFromJsonAsync<List<Customer>>("/api/Customer");
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PostAsJsonAsync("/api/Customer", customer);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error creating customer.";
            return View(customer);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var customer = await client.GetFromJsonAsync<Customer>($"/api/Customer/{id}");
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.PutAsJsonAsync($"/api/Customer/{customer.Id}", customer);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Error updating customer.";
            return View(customer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _clientFactory.CreateClient("RideAPI");
            var response = await client.DeleteAsync($"/api/Customer/{id}");
            return RedirectToAction("Index");
        }
    }
}
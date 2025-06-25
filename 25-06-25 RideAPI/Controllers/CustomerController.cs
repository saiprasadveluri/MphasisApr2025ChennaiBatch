using Microsoft.AspNetCore.Mvc;
using RideAggregatorCore.LoginForm.Services;

namespace RideAggregatorCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApiClient _api;

        public CustomerController(ApiClient api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _api.GetAsync<List<Customer>>("Customer");
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            var result = await _api.PostAsync("Customer", customer);
            return result ? RedirectToAction("Index") : View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _api.GetAsync<Customer>($"Customer/{id}");
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            var result = await _api.PutAsync($"Customer/{customer.CustomerId}", customer);
            return result ? RedirectToAction("Index") : View(customer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _api.DeleteAsync($"Customer/{id}");
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

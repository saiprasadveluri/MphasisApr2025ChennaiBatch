using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;


namespace RideAggregatorMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _customerService.GetAllAsync();
            return View(customers);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (!ModelState.IsValid) return View(customer);

            await _customerService.CreateAsync(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RideAggregatorCore.Customers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

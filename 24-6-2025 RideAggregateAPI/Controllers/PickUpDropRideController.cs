using Microsoft.AspNetCore.Mvc;

namespace RideAggregateAPI.Controllers
{
    public class PickUpDropRideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

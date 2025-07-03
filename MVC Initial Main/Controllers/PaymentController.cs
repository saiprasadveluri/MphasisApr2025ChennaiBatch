using Microsoft.AspNetCore.Mvc;

namespace OnlinePharmacyAppMVC.Controllers
{
    public class PaymentController : Controller
    {
        [HttpGet]
        public IActionResult Index(decimal amount)
        {
            ViewBag.AmountToPay = amount;
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(decimal amount, string paymentMethod)
        {
            // TODO: Integrate with payment gateway or simulate success
            TempData["Message"] = $"Payment of ₹{amount} via {paymentMethod} was successful!";
            return RedirectToAction("Confirmation");
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}

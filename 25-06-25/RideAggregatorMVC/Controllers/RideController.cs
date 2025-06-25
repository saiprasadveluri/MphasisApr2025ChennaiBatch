using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;
using System.Threading.Tasks;
using System;

namespace RideAggregatorMVC.Controllers
{
    public class RideController : Controller
    {
        private readonly RideService _rideService;

        public RideController(RideService rideService)
        {
            _rideService = rideService;
        }

        public IActionResult BookRide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookRide(Ride ride)
        {
            ride.RideDate = DateTime.Now;
            ride.IsCompleted = false;
            ride.CustomerId = int.Parse(HttpContext.Session.GetString("CustomerId") ?? "0");

            await _rideService.BookRideAsync(ride);

            TempData["Success"] = "Your ride is successfully booked!";
            return RedirectToAction("RideConfirmation");
        }

        public IActionResult RideConfirmation()
        {
            ViewBag.Message = TempData["Success"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EndRide(int rideId)
        {
            await _rideService.CompleteRideAsync(rideId);
            TempData["RideDone"] = rideId;
            return RedirectToAction("RateDriver");
        }

        [HttpPost]
        public async Task<IActionResult> CompleteRide(int rideId)
        {
            await _rideService.CompleteRideAsync(rideId);
            TempData["RideDone"] = rideId;
            return RedirectToAction("RideCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> CompleteRideByDriver(int rideId)
        {
            await _rideService.CompleteRideAsync(rideId);
            TempData["RideReadyForPayment"] = rideId;
            return RedirectToAction("PaymentPage");
        }

        public IActionResult RideCompleted()
        {
            var rideId = (int)(TempData["RideDone"] ?? 0);
            return View(model: rideId);
        }

        public async Task<IActionResult> MyRides()
        {
            var customerId = HttpContext.Session.GetString("CustomerId");
            if (string.IsNullOrEmpty(customerId))
                return RedirectToAction("Login", "Account");

            var rides = await _rideService.GetRidesByCustomerAsync(int.Parse(customerId));
            return View(rides);
        }

        public IActionResult PaymentPage()
        {
            var rideId = (int)(TempData["RideReadyForPayment"] ?? 0);
            return View(model: rideId);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmPayment(int rideId, string paymentMethod)
        {
            await _rideService.MarkPaymentCompletedAsync(rideId, paymentMethod);
            TempData["RideReadyForRating"] = rideId;
            return RedirectToAction("RideThankYou");
        }

        public IActionResult RideThankYou()
        {
            var rideId = (int)(TempData["RideReadyForRating"] ?? 0);
            return View(model: rideId);
        }

        public IActionResult RateDriver()
        {
            var rideId = (int)(TempData["RideDone"] ?? 0);
            return View(model: rideId);
        }

        [HttpPost]
        public async Task<IActionResult> SubmitRating(int rideId, int rating)
        {
            await _rideService.SubmitRatingAsync(rideId, rating);
            TempData["ThankYou"] = "Thanks for rating your ride!";
            return RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou()
        {
            ViewBag.Message = TempData["ThankYou"];
            return View();
        }
    }
}
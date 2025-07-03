using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using OnlinePharmacyAppMVC.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace OnlinePharmacyAppMVC.Controllers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class CartController : Controller
    {
        private readonly HttpClient _client;

        public CartController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri("https://localhost:7269/api/");
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Index()
        {
            string userIdStr = HttpContext.Session.GetString("userId");
            string isAdmin = HttpContext.Session.GetString("isAdmin");

            if (string.IsNullOrEmpty(userIdStr) || isAdmin == "True")
            {
                TempData["Error"] = "Access denied. Please log in with a customer account.";
                return RedirectToAction("Login", "Home");
            }

            if (!int.TryParse(userIdStr, out int userId))
            {
                TempData["Error"] = "Session error.";
                return RedirectToAction("Login", "Home");
            }

            // Fetch cart items
            var cartResponse = await _client.GetAsync($"Cart/{userId}");
            var cartItems = new List<CartModel>();

            if (cartResponse.IsSuccessStatusCode)
            {
                cartItems = await cartResponse.Content.ReadFromJsonAsync<List<CartModel>>();

                // Fetch medicine data for each item to get available stock
                foreach (var item in cartItems)
                {
                    var medResponse = await _client.GetAsync($"Medicine/{item.MedicineId}");
                    if (medResponse.IsSuccessStatusCode)
                    {
                        var medicine = await medResponse.Content.ReadFromJsonAsync<MedicineDTO>();
                        item.AvailableQty = medicine?.stockQty ?? item.StockQty; // fallback to current cart qty
                    }
                    else
                    {
                        item.AvailableQty = item.StockQty;
                    }
                }
            }

            // Fetch discount
            var discountResponse = await _client.GetAsync($"Discount/GetByUserId/{userId}");
            DiscountDTO discount = null;

            if (discountResponse.IsSuccessStatusCode)
            {
                discount = await discountResponse.Content.ReadFromJsonAsync<DiscountDTO>();
            }

            // Calculate totals
            decimal total = cartItems.Sum(i => i.Amount);
            decimal discountAmt = 0;

            if (discount != null)
            {
                discountAmt = discount.IsPercentage ? total * (discount.Value / 100) : discount.Value;
                ViewBag.DiscountCode = discount.DiscountCode;
                ViewBag.DiscountType = discount.DiscountType;
            }

            ViewBag.Total = total;
            ViewBag.DiscountAmount = discountAmt;
            ViewBag.FinalAmount = total - discountAmt;

            return View(cartItems);
        }
    }
}

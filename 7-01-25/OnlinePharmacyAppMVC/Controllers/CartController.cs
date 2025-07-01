//using Microsoft.AspNetCore.Mvc;
//using OnlinePharmacyAppMVC.Helpers;
//using OnlinePharmacyAppMVC.DTO;
//using System.Text.Json;

//namespace OnlinePharmacyAppMVC.Controllers
//{
//    public class CartController : Controller
//    {
//        private readonly HttpClient _client;

//        public CartController()
//        {
//            _client = new HttpClient
//            {
//                BaseAddress = new Uri("https://localhost:7269/api/") // update if needed
//            };
//        }

//        // Fetch medicine by ID from the API
//        public async Task<MedicineDTO> GetMedicineByIdAsync(int id)
//        {
//            var response = await _client.GetAsync($"Medicine/{id}");
//            if (!response.IsSuccessStatusCode)
//                return null;

//            return await response.Content.ReadFromJsonAsync<MedicineDTO>();
//        }

//        // Add selected medicine and quantity to the cart stored in session
//        [HttpPost]
//        public async Task<IActionResult> AddToCart(int medicineId, int quantity)
//        {
//            var medicine = await GetMedicineByIdAsync(medicineId);
//            if (medicine == null)
//                return NotFound();

//            var cartItem = new CartItemDTO
//            {
//                MedicineId = medicine.medicineId,
//                MedName = medicine.medName,
//                Price = medicine.price,
//                Quantity = quantity
//            };

//            var cart = SessionHelper.GetObjectFromJson<List<CartItemDTO>>(HttpContext.Session, "Cart") ?? new List<CartItemDTO>();
//            cart.Add(cartItem);
//            SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart", cart);

//            return Ok();
//        }

//        // View cart contents
//        [HttpGet]
//        public IActionResult ViewCart()
//        {
//            var cart = SessionHelper.GetObjectFromJson<List<CartItemDTO>>(HttpContext.Session, "Cart") ?? new List<CartItemDTO>();
//            return View(cart);
//        }
//    }
//}

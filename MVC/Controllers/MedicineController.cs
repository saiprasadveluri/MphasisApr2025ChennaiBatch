using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyApp.DTO;
using OnlinePharmacyApp.Models;
using System.Text.Json;
using static OnlinePharmacyApp.DTO.MedicineDTO;

namespace OnlinePharmacyApp.Controllers
{
    public class PharmacyController : Controller
    {
        public async Task<IActionResult> ViewMedicines()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(" https://localhost:7013/api");

            HttpResponseMessage response = await client.GetAsync("Medicine"); // Assumes your API endpoint is /api/Medicine
            response.EnsureSuccessStatusCode();

            string jsonData = await response.Content.ReadAsStringAsync();

            var medicines = JsonSerializer.Deserialize<List<GetMedicine>>(jsonData); // Assuming a 'Medicine' model

            return View(medicines); // Returns the medicines to a view like ViewMedicines.cshtml
        }
    }
}


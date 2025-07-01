using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

public class MedicineController : Controller
{
    private readonly HttpClient _client;

    public MedicineController()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7269/api/")
        };
    }

    // GET: /Medicine/AddMedicine
    [HttpGet]
    public IActionResult AddMedicine()
    {
        return View();
    }

    // POST: /Medicine/AddMedicine
    [HttpPost]
    public async Task<IActionResult> AddMedicine(MedicineDTO medicine)
    {
        try
        {
            var response = await _client.PostAsJsonAsync("Medicine", medicine);
            if (response.IsSuccessStatusCode)
            {
                TempData["Success"] = "Medicine added successfully!";
                return RedirectToAction("ViewMedicine");
            }

            TempData["Error"] = $"API Error: {response.StatusCode}";
            return View(medicine);
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Exception: {ex.Message}";
            return View(medicine);
        }
    }

    // GET: /Medicine/ViewMedicine
    [HttpGet]
    public async Task<IActionResult> ViewMedicine()
    {
        try
        {
            var response = await _client.GetAsync("Medicine");
            if (!response.IsSuccessStatusCode)
            {
                TempData["Error"] = "Failed to load medicine list.";
                return View(new GetMedicine { data = new List<MedicineDTO>() });
            }

            var result = await response.Content.ReadFromJsonAsync<GetMedicine>();
            return View(result);
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Error: {ex.Message}";
            return View(new GetMedicine { data = new List<MedicineDTO>() });
        }
    }

    // GET: /Medicine/EditMedicine/5
    [HttpGet]
    public async Task<IActionResult> EditMedicine(int id)
    {
        var response = await _client.GetAsync($"Medicine/{id}");
        if (!response.IsSuccessStatusCode)
        {
            TempData["Error"] = "Could not load medicine data.";
            return RedirectToAction("ViewMedicine");
        }

        var content = await response.Content.ReadAsStringAsync();
        var medicine = JsonSerializer.Deserialize<MedicineDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return View(medicine);
    }

    // POST: /Medicine/EditMedicine
    [HttpPost]
    public async Task<IActionResult> EditMedicine(MedicineDTO medicine)
    {
        var response = await _client.PutAsJsonAsync($"Medicine/{medicine.medicineId}", medicine);
        if (response.IsSuccessStatusCode)
        {
            TempData["Success"] = "Medicine updated successfully!";
            return RedirectToAction("ViewMedicine");
        }

        TempData["Error"] = "Update failed.";
        return View(medicine);
    }

    // GET: /Medicine/DeleteMedicine/5
    public async Task<IActionResult> DeleteMedicine(int id)
    {
        var response = await _client.DeleteAsync($"Medicine/{id}");
        if (response.IsSuccessStatusCode)
        {
            TempData["Success"] = "Medicine deleted successfully!";
        }
        else
        {
            TempData["Error"] = "Delete failed.";
        }

        return RedirectToAction("ViewMedicine");
    }
    [HttpPost]
    public async Task<IActionResult> UpdateStock(Dictionary<int, StockUpdateDTO> stockUpdates)
    {
        foreach (var entry in stockUpdates.Values)
        {
            // Fetch current medicine
            var response = await _client.GetAsync($"Medicine/{entry.medicineId}");
            if (!response.IsSuccessStatusCode) continue;

            var medicine = await response.Content.ReadFromJsonAsync<MedicineDTO>();

            // Update stock quantity
            medicine.stockQty += entry.addedQty;

            // Call PUT to update
            await _client.PutAsJsonAsync($"Medicine/{medicine.medicineId}", medicine);
        }

        TempData["Success"] = "Stock updated successfully!";
        return RedirectToAction("ViewMedicine");
    }
    [HttpGet]
    public async Task<IActionResult> ManageStock()
    {
        var response = await _client.GetAsync("Medicine");
        if (!response.IsSuccessStatusCode)
        {
            TempData["Error"] = "Failed to load medicine data.";
            return View(new GetMedicine { data = new List<MedicineDTO>() });
        }

        var medicines = await response.Content.ReadFromJsonAsync<GetMedicine>();
        return View(medicines);
    }


}

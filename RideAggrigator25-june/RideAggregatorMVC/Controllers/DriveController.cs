using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.Models;
using RideAggregatorMVC.Services;

namespace RideAggregatorMVC.Controllers;

public class DriverController : Controller
{
    private readonly DriverService _driverService;
    public DriverController(DriverService driverService) => _driverService = driverService;

    public async Task<IActionResult> Index()
    {
        var drivers = await _driverService.GetAllAsync();
        return View(drivers);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Driver driver)
    {
        if (!ModelState.IsValid)
            return View(driver);

        await _driverService.CreateAsync(driver);
        TempData["SuccessMessage"] = "Driver saved successfully!";
        return RedirectToAction(nameof(Index));
    }
}
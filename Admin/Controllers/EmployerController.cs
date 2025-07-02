using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

public class EmployerController : Controller
{
    private readonly UnitOfWorkDb _unitOfWork;
    private readonly UserMVCRepo _userRepo;


    private async Task PopulateUsersDropDownAsync()
    {
        var users = await _userRepo.GetAllAsync();
        // Create SelectList: Value = UserId, Text = UserName or Email (choose what you prefer)
        ViewBag.UserList = new SelectList(users, "UserId", "UserName");
    }

    public EmployerController(UnitOfWorkDb unitOfWork, UserMVCRepo userRepo)
    {
        _unitOfWork = unitOfWork;
        _userRepo = userRepo;
    }

    // GET: Employer
    public async Task<IActionResult> Index()
    {
        var employers = await _unitOfWork.employerRepo.GetAllAsync();
        return View(employers);
    }

    // GET: Employer/Details/{id}
    public async Task<IActionResult> Details(Guid id)
    {
        var employer = await _unitOfWork.employerRepo.GetByIdAsync(id.ToString());
        if (employer == null) return NotFound();
        return View(employer);
    }

    public async Task<IActionResult> Create()
    {
        await PopulateUsersDropDownAsync();
        return View();
    }

    // POST: Employer/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Employer employer)
    {
        if (ModelState.IsValid)
        {
            // Validate UserId via UserMVCRepo API call
            var user = await _userRepo.GetByIdAsync(employer.UserId.ToString());
            if (user == null)
            {
                ModelState.AddModelError("UserId", "User with specified UserId does not exist.");
                return View(employer);
            }

            employer.EmployerId = Guid.NewGuid();
            await _unitOfWork.employerRepo.CreateAsync(employer);
            return RedirectToAction(nameof(Index));
        }
        return View(employer);
    }

    // GET: Employer/Edit/{id}
    public async Task<IActionResult> Edit(Guid id)
    {
        var employer = await _unitOfWork.employerRepo.GetByIdAsync(id.ToString());
        if (employer == null) return NotFound();

        await PopulateUsersDropDownAsync();
        return View(employer);
    }

    // POST: Employer/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, Employer employer)
    {
        if (id != employer.EmployerId) return BadRequest();

        if (ModelState.IsValid)
        {
            // Validate UserId on update as well
            var user = await _userRepo.GetByIdAsync(employer.UserId.ToString());
            if (user == null)
            {
                ModelState.AddModelError("UserId", "User with specified UserId does not exist.");
                return View(employer);
            }

            await _unitOfWork.employerRepo.UpdateAsync(id.ToString(), employer);
            return RedirectToAction(nameof(Index));
        }
        return View(employer);
    }

    // GET: Employer/Delete/{id}
    public async Task<IActionResult> Delete(Guid id)
    {
        var employer = await _unitOfWork.employerRepo.GetByIdAsync(id.ToString());
        if (employer == null) return NotFound();
        return View(employer);
    }

    // POST: Employer/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var employer = await _unitOfWork.employerRepo.GetByIdAsync(id.ToString());
        if (employer == null) return NotFound();

        await _unitOfWork.employerRepo.DeleteAsync(id.ToString(), employer);
        return RedirectToAction(nameof(Index));
    }
}

using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JobSearchMVC.Controllers
{
    public class EducationController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public EducationController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Education
        public async Task<IActionResult> Index()
        {
            try
            {
                var educations = await _unitOfWork.educationRepo.GetAllAsync();
                return View(educations);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error loading educations: {ex.Message}");
                return View(Array.Empty<Education>());
            }
        }

        // GET: Education/Details/{id}
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var education = await _unitOfWork.educationRepo.GetByIdAsync(id.ToString());
            if (education == null) return NotFound();

            return View(education);
        }

        // GET: Education/Create
        public IActionResult Create()
        {
            var education = new Education();
            // Optionally initialize any defaults here, e.g.
            // education.StartDate = DateTime.Today;
            return View(education);
        }


        // POST: Education/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Education education)
        {
            if (!ModelState.IsValid) return View(education);

            try
            {
                await _unitOfWork.educationRepo.CreateAsync(education);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error creating education: {ex.Message}");
                return View(education);
            }
        }

        // GET: Education/Edit/{id}
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var education = await _unitOfWork.educationRepo.GetByIdAsync(id.ToString());
            if (education == null) return NotFound();

            return View(education);
        }

        // POST: Education/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Education education)
        {
            if (id != education.EducationId) return NotFound();

            if (!ModelState.IsValid) return View(education);

            try
            {
                await _unitOfWork.educationRepo.UpdateAsync(id.ToString(), education);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error updating education: {ex.Message}");
                return View(education);
            }
        }

        // GET: Education/Delete/{id}
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();

            var education = await _unitOfWork.educationRepo.GetByIdAsync(id.ToString());
            if (education == null) return NotFound();

            return View(education);
        }

        // POST: Education/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            try
            {
                var education = await _unitOfWork.educationRepo.GetByIdAsync(id.ToString());
                if (education == null) return NotFound();

                await _unitOfWork.educationRepo.DeleteAsync(id.ToString(), education);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error deleting education: {ex.Message}");
                return View();
            }
        }
    }
}

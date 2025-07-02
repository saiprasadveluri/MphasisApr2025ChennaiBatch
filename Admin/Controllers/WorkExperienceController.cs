using JobSearchAPI.DAL;
using JobSearchAPI.DataDTO;
using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchDatabase.Controllers
{
    public class WorkExperienceController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public WorkExperienceController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /WorkExperience
        public async Task<IActionResult> Index()
        {
            var list = await _unitOfWork.workRepo.GetAllAsync();
            return View(list ?? new List<WorkExperience>());
        }

        // GET: /WorkExperience/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            var entry = await _unitOfWork.workRepo.GetByIdAsync(id.ToString());
            if (entry == null)
                return NotFound();
            return View(entry);
        }

        // GET: /WorkExperience/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /WorkExperience/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkExperience workExperience)
        {
            if (!ModelState.IsValid)
                return View(workExperience);

            workExperience.WorkExperienceId = Guid.NewGuid();
            await _unitOfWork.workRepo.CreateAsync(workExperience);
            return RedirectToAction(nameof(Index));
        }

        // GET: /WorkExperience/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            var entry = await _unitOfWork.workRepo.GetByIdAsync(id.ToString());
            if (entry == null)
                return NotFound();
            return View(entry);
        }

        // POST: /WorkExperience/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(WorkExperience workExperience)
        {
            if (!ModelState.IsValid)
                return View(workExperience);

            await _unitOfWork.workRepo.UpdateAsync(workExperience.WorkExperienceId.ToString(), workExperience);
            return RedirectToAction(nameof(Index));
        }

        // GET: /WorkExperience/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            var entry = await _unitOfWork.workRepo.GetByIdAsync(id.ToString());
            if (entry == null)
                return NotFound();
            return View(entry);
        }

        // POST: /WorkExperience/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _unitOfWork.workRepo.DeleteAsync(id.ToString(), null);
            return RedirectToAction(nameof(Index));
        }
    }
}

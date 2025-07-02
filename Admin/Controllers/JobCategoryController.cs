using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchUI.Controllers
{
    public class JobCategoryController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public JobCategoryController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: JobCategory
        public async Task<IActionResult> Index()
        {
            var categories = await _unitOfWork.jobCategoryRepo.GetAllAsync();
            return View(categories);
        }

        // GET: JobCategory/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var category = await _unitOfWork.jobCategoryRepo.GetByIdAsync(id.ToString());
            if (category == null)
                return NotFound();

            return View(category);
        }

        // GET: JobCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobCategory category)
        {
            if (ModelState.IsValid)
            {
                category.CategoryId = Guid.NewGuid();
                try
                {
                    await _unitOfWork.jobCategoryRepo.CreateAsync(category);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"Error creating category: {ex.Message}");
                }
            }
            return View(category);
        }

        // GET: JobCategory/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var category = await _unitOfWork.jobCategoryRepo.GetByIdAsync(id.ToString());
            if (category == null)
                return NotFound();

            return View(category);
        }

        // POST: JobCategory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, JobCategory category)
        {
            if (id != category.CategoryId)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _unitOfWork.jobCategoryRepo.UpdateAsync(id.ToString(), category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        // GET: JobCategory/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var category = await _unitOfWork.jobCategoryRepo.GetByIdAsync(id.ToString());
            if (category == null)
                return NotFound();

            return View(category);
        }

        // POST: JobCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var category = await _unitOfWork.jobCategoryRepo.GetByIdAsync(id.ToString());
            if (category != null)
            {
                await _unitOfWork.jobCategoryRepo.DeleteAsync(id.ToString(), category);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

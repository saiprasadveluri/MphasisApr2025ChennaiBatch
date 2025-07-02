using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JobSearchDatabase.Controllers
{
    public class JobPostingController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public JobPostingController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: JobPosting
        public async Task<IActionResult> Index()
        {
            var jobPostings = await _unitOfWork.jobPostingRepo.GetAllAsync();
            return View(jobPostings);
        }

        // GET: JobPosting/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            var jobPosting = await _unitOfWork.jobPostingRepo.GetByIdAsync(id.ToString());
            if (jobPosting == null) return NotFound();
            return View(jobPosting);
        }

        // GET: JobPosting/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobPosting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobPosting jobPosting)
        {
            if (!ModelState.IsValid)
                return View(jobPosting);

            jobPosting.JobPostingId = Guid.NewGuid();
            await _unitOfWork.jobPostingRepo.CreateAsync(jobPosting);
            return RedirectToAction(nameof(Index));
        }

        // GET: JobPosting/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            var jobPosting = await _unitOfWork.jobPostingRepo.GetByIdAsync(id.ToString());
            if (jobPosting == null) return NotFound();
            return View(jobPosting);
        }

        // POST: JobPosting/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, JobPosting jobPosting)
        {
            if (id != jobPosting.JobPostingId)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(jobPosting);

            await _unitOfWork.jobPostingRepo.UpdateAsync(id.ToString(), jobPosting);
            return RedirectToAction(nameof(Index));
        }

        // GET: JobPosting/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            var jobPosting = await _unitOfWork.jobPostingRepo.GetByIdAsync(id.ToString());
            if (jobPosting == null) return NotFound();
            return View(jobPosting);
        }

        // POST: JobPosting/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _unitOfWork.jobPostingRepo.DeleteAsync(id.ToString(), null);
            return RedirectToAction(nameof(Index));
        }
    }
}

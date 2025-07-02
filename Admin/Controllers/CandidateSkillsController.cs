using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchDatabase.Controllers
{
    public class CandidateSkillsController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public CandidateSkillsController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var skills = await _unitOfWork.candidateSkillsRepo.GetAllAsync();
            return View(skills);
        }

        public async Task<IActionResult> Details(string id)
        {
            var skill = await _unitOfWork.candidateSkillsRepo.GetByIdAsync(id);
            if (skill == null)
                return NotFound();

            return View(skill);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CandidateSkills skill)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.candidateSkillsRepo.CreateAsync(skill);
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var skill = await _unitOfWork.candidateSkillsRepo.GetByIdAsync(id);
            if (skill == null)
                return NotFound();

            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, CandidateSkills skill)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.candidateSkillsRepo.UpdateAsync(id, skill);
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var skill = await _unitOfWork.candidateSkillsRepo.GetByIdAsync(id);
            if (skill == null)
                return NotFound();

            return View(skill);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var skill = await _unitOfWork.candidateSkillsRepo.GetByIdAsync(id);
            if (skill == null)
                return NotFound();

            await _unitOfWork.candidateSkillsRepo.DeleteAsync(id, skill);
            return RedirectToAction(nameof(Index));
        }
    }
}

using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchDatabase.Controllers
{
    public class SkillController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public SkillController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Skill
        public async Task<IActionResult> Index()
        {
            var skills = await _unitOfWork.skillRepo.GetAllAsync(); // change to skill repo below
            return View(skills);
        }

        // GET: Skill/Details/{id}
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var skill = await _unitOfWork.skillRepo.GetByIdAsync(id.ToString());
            if (skill == null) return NotFound();

            return View(skill);
        }

        // GET: Skill/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill skill)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.skillRepo.CreateAsync(skill);
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        // GET: Skill/Edit/{id}
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var skill = await _unitOfWork.skillRepo.GetByIdAsync(id.ToString());
            if (skill == null) return NotFound();

            return View(skill);
        }

        // POST: Skill/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Skill skill)
        {
            if (id != skill.SkillId) return BadRequest();

            if (ModelState.IsValid)
            {
                await _unitOfWork.skillRepo.UpdateAsync(id.ToString(), skill);
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        // GET: Skill/Delete/{id}
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            var skill = await _unitOfWork.skillRepo.GetByIdAsync(id.ToString());
            if (skill == null) return NotFound();

            return View(skill);
        }

        // POST: Skill/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var skill = await _unitOfWork.skillRepo.GetByIdAsync(id.ToString());
            if (skill == null) return NotFound();

            await _unitOfWork.skillRepo.DeleteAsync(id.ToString(), skill);
            return RedirectToAction(nameof(Index));
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobSearchDatabase.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobSearchDatabase.Controllers
{
    public class CandidateController : Controller
    {
        private readonly JSDbContext _context;

        public CandidateController(JSDbContext context)
        {
            _context = context;
        }

        // GET: Candidate
        public async Task<IActionResult> Index()
        {
            var candidates = await _context.Candidates
                .Include(c => c.User)
                .ToListAsync();
            return View(candidates);
        }

        // GET: Candidate/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var candidate = await _context.Candidates
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null) return NotFound();

            return View(candidate);
        }

        // GET: Candidate/Create
        public IActionResult Create()
        {
            // Load users for dropdown
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            return View();
        }

        // POST: Candidate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,DateOfBirth,Gender,Address,ResumeFilePath,ProfileSummary,UserId")] Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                candidate.CandidateId = Guid.NewGuid();
                _context.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", candidate.UserId);
            return View(candidate);
        }

        // GET: Candidate/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null) return NotFound();

            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", candidate.UserId);
            return View(candidate);
        }

        // POST: Candidate/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CandidateId,FirstName,LastName,DateOfBirth,Gender,Address,ResumeFilePath,ProfileSummary,UserId")] Candidate candidate)
        {
            if (id != candidate.CandidateId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateExists(candidate.CandidateId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", candidate.UserId);
            return View(candidate);
        }

        // GET: Candidate/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();

            var candidate = await _context.Candidates
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidate == null) return NotFound();

            return View(candidate);
        }

        // POST: Candidate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate != null)
            {
                _context.Candidates.Remove(candidate);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateExists(Guid id)
        {
            return _context.Candidates.Any(e => e.CandidateId == id);
        }
    }
}

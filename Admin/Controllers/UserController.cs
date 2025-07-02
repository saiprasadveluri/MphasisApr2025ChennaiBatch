using JobSearchDatabase.Data;
using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JobSearchDatabase.Controllers
{
    public class UserController : Controller
    {
        private readonly UnitOfWorkDb _unitOfWork;

        public UserController(UnitOfWorkDb unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var users = await _unitOfWork.userRepository.GetAllAsync();
            return View(users);
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
            if (user == null) return NotFound();
            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.UserId = Guid.NewGuid();
                await _unitOfWork.userRepository.CreateAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
            if (user == null) return NotFound();
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, User user)
        {
            if (id != user.UserId) return NotFound();

            if (ModelState.IsValid)
            {
                await _unitOfWork.userRepository.UpdateAsync(id.ToString(), user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
            if (user == null) return NotFound();
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
            if (user != null)
            {
                await _unitOfWork.userRepository.DeleteAsync(id.ToString(), user);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

using JobSearchMVC.DataDTO;
using JobSearchMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobSearchMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public UserController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // View all users
        public async Task<IActionResult> UserView()
        {
            try
            {
                var users = await _unitOfWork.userRepository.GetAllAsync();
                return View(users ?? new List<UserDTO>());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching users: {ex.Message}");
                return View(new List<UserDTO>());
            }
        }
        public async Task<IActionResult> ViewUserById(Guid id)
        {
            try
            {
                var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
                if (user == null)
                    return NotFound($"User with ID {id} not found.");

                return View(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving user: {ex.Message}");
                return StatusCode(500, "An error occurred while fetching user details.");
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(Guid id)
        {
            var user = await _unitOfWork.userRepository.GetByIdAsync(id.ToString());
            if (user == null)
                return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(UserDTO userdto)
        {
            if (!ModelState.IsValid)
                return View(userdto);

            var success = await _unitOfWork.userRepository.UpdateAsync(userdto.userId.ToString(), userdto);
            //if (!success)
            //    return NotFound();

            return RedirectToAction("UserView");
        }

        [ValidateAntiForgeryToken, HttpPost]
        public async Task<IActionResult> DeleteUser(Guid id,UserDTO userDTO)
        {
            try
            {
                var userDel = await _unitOfWork.userRepository.DeleteAsync(id.ToString(),userDTO);
                if (userDel == null)
                {
                    return NotFound($"User with ID {id} not found.");
                }
                return RedirectToAction("UserView");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Deleting data: {ex.Message}");
                return StatusCode(500, $"An Error Occurred While deleting User Details{ex.Message}");
            }
        }
    }
}

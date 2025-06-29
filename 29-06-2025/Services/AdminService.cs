// Book.Services/AdminService.cs
using Book.Data; // For the Admin entity
using Book.Data.DB; // For BookMyShowDbContext
using Book.DTO; // For AdminDTO, AdminCreateDTO, AdminLoginDTO
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity; // IMPORTANT: For IPasswordHasher
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.Services
{
    // NO LONGER INHERITS from BookMyShowDbContext
    public class AdminService
    {
        private readonly BookMyShowDbContext _context;
        private readonly IPasswordHasher<Admin> _passwordHasher; // Inject IPasswordHasher for Admin

        // Constructor for Dependency Injection
        public AdminService(BookMyShowDbContext context, IPasswordHasher<Admin> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher; // Assign the injected hasher
        }

        // --- READ Operations ---

        // Listing all Admins
        public async Task<List<AdminDTO>> GetAllAdminsAsync()
        {
            return await _context.Admins // Use _context.Admins
                                 .Select(a => new AdminDTO
                                 {
                                     AdminId = a.AdminId,
                                     AdminName = a.AdminName
                                 })
                                 .ToListAsync();
        }

        // Getting Admin by ID
        public async Task<AdminDTO?> GetAdminByIdAsync(int id) // Changed return type to AdminDTO?
        {
            var admin = await _context.Admins.FindAsync(id); // Use _context.Admins

            if (admin == null)
            {
                return null;
            }

            return new AdminDTO
            {
                AdminId = admin.AdminId,
                AdminName = admin.AdminName
            };
        }

        // --- CREATE Operation ---
        public async Task<AdminDTO?> CreateAdminAsync(AdminCreateDTO adminCreateDto) // Changed return type to AdminDTO?
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(adminCreateDto.AdminName))
            {
                throw new ArgumentException("Admin name cannot be empty or whitespace.", nameof(adminCreateDto.AdminName));
            }
            if (string.IsNullOrWhiteSpace(adminCreateDto.Password) || adminCreateDto.Password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.", nameof(adminCreateDto.Password));
            }

            // Check if admin name already exists
            var existingAdmin = await _context.Admins.AnyAsync(a => a.AdminName == adminCreateDto.AdminName);
            if (existingAdmin)
            {
                throw new InvalidOperationException($"Admin with name '{adminCreateDto.AdminName}' already exists.");
            }

            // HASH THE PASSWORD before storing!
            string hashedPassword = _passwordHasher.HashPassword(new Admin(), adminCreateDto.Password);

            var admin = new Admin
            {
                AdminName = adminCreateDto.AdminName,
                Password = hashedPassword // Store the hashed password
            };

            _context.Admins.Add(admin); // Use _context.Admins
            int savedChanges = await _context.SaveChangesAsync(); // Use _context.SaveChangesAsync()

            if (savedChanges > 0)
            {
                return new AdminDTO
                {
                    AdminId = admin.AdminId,
                    AdminName = admin.AdminName
                };
            }
            return null; // Should ideally not be reached if savedChanges > 0
        }

        // --- UPDATE Operation (Added based on User service pattern) ---
        public async Task<AdminDTO?> UpdateAdminAsync(int id, AdminDTO adminUpdateDto) // Changed return type to AdminDTO?
        {
            var existingAdmin = await _context.Admins.FindAsync(id);

            if (existingAdmin == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(adminUpdateDto.AdminName))
            {
                throw new ArgumentException("Admin name cannot be empty or whitespace for update.", nameof(adminUpdateDto.AdminName));
            }

            // Check if updated admin name is already taken by another admin (excluding current admin)
            if (existingAdmin.AdminName != adminUpdateDto.AdminName)
            {
                var nameTaken = await _context.Admins.AnyAsync(a => a.AdminName == adminUpdateDto.AdminName && a.AdminId != id);
                if (nameTaken)
                {
                    throw new InvalidOperationException($"Admin name '{adminUpdateDto.AdminName}' is already taken by another admin.");
                }
            }

            existingAdmin.AdminName = adminUpdateDto.AdminName;
            // IMPORTANT: Admin password should NOT be updated directly via AdminDTO.
            // Create a separate ChangeAdminPasswordAsync method if needed.

            _context.Entry(existingAdmin).State = EntityState.Modified;
            int savedChanges = await _context.SaveChangesAsync();

            if (savedChanges > 0)
            {
                return new AdminDTO
                {
                    AdminId = existingAdmin.AdminId,
                    AdminName = existingAdmin.AdminName
                };
            }
            return null;
        }

        // --- DELETE Operation ---
        public async Task<bool> DeleteAdminAsync(int id)
        {
            var adminToDelete = await _context.Admins.FindAsync(id); // Use _context.Admins

            if (adminToDelete == null)
            {
                return false; // Admin not found
            }

            _context.Admins.Remove(adminToDelete); // Use _context.Admins
            int savedChanges = await _context.SaveChangesAsync(); // Use _context.SaveChangesAsync()

            return savedChanges > 0;
        }

        // --- Admin Credential Verification (Login) ---
        public async Task<AdminDTO?> VerifyAdminCredentialsAsync(string adminName, string plainTextPassword) // Changed return type to AdminDTO?
        {
            if (string.IsNullOrWhiteSpace(adminName) || string.IsNullOrWhiteSpace(plainTextPassword))
            {
                return null;
            }

            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.AdminName == adminName);

            if (admin == null)
            {
                return null; // Admin not found
            }

            // Verify the provided plain-text password against the stored hash
            var verificationResult = _passwordHasher.VerifyHashedPassword(admin, admin.Password, plainTextPassword);

            if (verificationResult == PasswordVerificationResult.Success ||
                verificationResult == PasswordVerificationResult.SuccessRehashNeeded)
            {
                if (verificationResult == PasswordVerificationResult.SuccessRehashNeeded)
                {
                    // If the hash needs to be updated (e.g., stronger algorithm available), re-hash and save
                    admin.Password = _passwordHasher.HashPassword(admin, plainTextPassword);
                    await _context.SaveChangesAsync();
                }

                return new AdminDTO
                {
                    AdminId = admin.AdminId,
                    AdminName = admin.AdminName
                };
            }
            return null; // Password mismatch
        }
    }
}
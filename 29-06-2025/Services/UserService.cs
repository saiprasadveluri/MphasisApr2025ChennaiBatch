// Book.Services/UserService.cs
using Book.Data; // For the User entity
using Book.Data.DB; // For BookMyShowDbContext
using Book.DTO; // For UserDTO, RegisterDTO, LoginDTO, ChangePasswordDTO
using Microsoft.AspNetCore.Identity; // IMPORTANT: This is the correct namespace for IPasswordHasher
using Microsoft.EntityFrameworkCore; // For DbContext, FindAsync, ToListAsync, FirstOrDefaultAsync
using System; // For ArgumentException, InvalidOperationException, UnauthorizedAccessException
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.Services
{
    // NO LONGER INHERITS from BookMyShowDbContext
    public class UserService
    {
        private readonly BookMyShowDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher; // Declare the injected password hasher

       

        // Constructor for Dependency Injection
        public UserService(BookMyShowDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher; // Assign the injected hasher
        }



        // --- READ Operations ---

        // Get All Users
        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            return await _context.Users // Use _context
                                 .Select(u => new UserDTO
                                 {
                                     UserId = u.UserId,
                                     UserName = u.UserName,
                                     UserEmail = u.UserEmail,
                                     Age = u.Age,
                                     Gender = u.Gender,
                                     MobileNo = u.MobileNo,
                                     Address = u.Address
                                 })
                                 .ToListAsync();
        }

        // Get User by ID
        public async Task<UserDTO?> GetUserByIdAsync(int id) // Changed return type to UserDTO? (nullable)
        {
            var user = await _context.Users.FindAsync(id); // Use _context

            if (user == null)
            {
                return null; // Return null if not found
            }

            return new UserDTO
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                Age = user.Age,
                Gender = user.Gender,
                MobileNo = user.MobileNo,
                Address = user.Address
            };
        }

        // Get User by Email
        public async Task<UserDTO?> GetUserByEmailAsync(string email) // Changed return type to UserDTO? (nullable)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return null; // Invalid email input
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserEmail == email); // Use _context

            if (user == null)
            {
                return null; // User not found
            }

            return new UserDTO
            {
                UserId = user.UserId,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                Age = user.Age,
                Gender = user.Gender,
                MobileNo = user.MobileNo,
                Address = user.Address
            };
        }

        // --- CREATE Operation ---
        public async Task<UserDTO?> CreateUserAsync(UserDTO userCreateDto) // Changed parameter to RegisterDTO, return type to UserDTO?
        {
            // Input validation (some basic checks, DTO attributes handle more)
            if (string.IsNullOrWhiteSpace(userCreateDto.UserName))
            {
                throw new ArgumentException("User name cannot be empty or whitespace.", nameof(userCreateDto.UserName));
            }
            if (string.IsNullOrWhiteSpace(userCreateDto.UserEmail))
            {
                throw new ArgumentException("User email cannot be empty or whitespace.", nameof(userCreateDto.UserEmail));
            }
            if (string.IsNullOrWhiteSpace(userCreateDto.Password) || userCreateDto.Password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.", nameof(userCreateDto.Password));
            }
            if (userCreateDto.Age < 0 || userCreateDto.Age > 150)
            {
                throw new ArgumentException("Invalid Age.", nameof(userCreateDto.Age));
            }

            // Check if email already exists
            var existingUserByEmail = await _context.Users.AnyAsync(u => u.UserEmail == userCreateDto.UserEmail); // Use _context
            if (existingUserByEmail)
            {
                throw new InvalidOperationException($"User with email '{userCreateDto.UserEmail}' already exists.");
            }

            // Hash the password using the injected IPasswordHasher
            // The first argument `user` can be a dummy new User object for initial hashing
            string hashedPassword = _passwordHasher.HashPassword(new User(), userCreateDto.Password);

            var newUser = new User // Create a new User entity
            {
                UserName = userCreateDto.UserName,
                UserEmail = userCreateDto.UserEmail,
                Password = hashedPassword, // Store the hashed password
                Age = userCreateDto.Age,
                Gender = userCreateDto.Gender,
                MobileNo = userCreateDto.MobileNo,
                Address = userCreateDto.Address
            };

            _context.Users.Add(newUser); // Add to DbContext, use _context
            int savedChanges = await _context.SaveChangesAsync(); // Save changes, use _context

            if (savedChanges > 0)
            {
                // Map the newly created entity to a DTO for returning
                return new UserDTO
                {
                    UserId = newUser.UserId,
                    UserName = newUser.UserName,
                    UserEmail = newUser.UserEmail,
                    Age = newUser.Age,
                    Gender = newUser.Gender,
                    MobileNo = newUser.MobileNo,
                    Address = newUser.Address
                };
            }
            return null; // Should ideally not happen if savedChanges > 0, but included for completeness
        }

        // --- UPDATE Operation ---
        public async Task<UserDTO?> UpdateUserAsync(int id, UserDTO userUpdateDto) // Changed parameter to UserDTO, return type to UserDTO?
        {
            var existingUser = await _context.Users.FindAsync(id); // Use _context

            if (existingUser == null)
            {
                return null; // User not found
            }

            // Input validation
            if (string.IsNullOrWhiteSpace(userUpdateDto.UserName))
            {
                throw new ArgumentException("User name cannot be empty or whitespace for update.", nameof(userUpdateDto.UserName));
            }
            if (string.IsNullOrWhiteSpace(userUpdateDto.UserEmail))
            {
                throw new ArgumentException("User email cannot be empty or whitespace for update.", nameof(userUpdateDto.UserEmail));
            }
            if (userUpdateDto.Age < 0 || userUpdateDto.Age > 150)
            {
                throw new ArgumentException("Invalid Age for update.", nameof(userUpdateDto.Age));
            }

            // Check if updated email is already taken by another user (excluding current user)
            if (existingUser.UserEmail != userUpdateDto.UserEmail)
            {
                var emailTaken = await _context.Users.AnyAsync(u => u.UserEmail == userUpdateDto.UserEmail && u.UserId != id); // Use _context
                if (emailTaken)
                {
                    throw new InvalidOperationException($"Email '{userUpdateDto.UserEmail}' is already taken by another user.");
                }
            }

            // Update user properties from DTO
            existingUser.UserName = userUpdateDto.UserName;
            existingUser.UserEmail = userUpdateDto.UserEmail;
            // IMPORTANT: Password should NOT be updated directly via UserDTO. Use ChangePasswordAsync for this.
            existingUser.Age = userUpdateDto.Age;
            existingUser.Gender = userUpdateDto.Gender;
            existingUser.MobileNo = userUpdateDto.MobileNo;
            existingUser.Address = userUpdateDto.Address;

            _context.Entry(existingUser).State = EntityState.Modified; // Mark as modified, use _context
            int savedChanges = await _context.SaveChangesAsync(); // Save changes, use _context

            if (savedChanges > 0)
            {
                return new UserDTO
                {
                    UserId = existingUser.UserId,
                    UserName = existingUser.UserName,
                    UserEmail = existingUser.UserEmail,
                    Age = existingUser.Age,
                    Gender = existingUser.Gender,
                    MobileNo = existingUser.MobileNo,
                    Address = existingUser.Address
                };
            }
            return null; // Should ideally always save if no exceptions
        }

        // --- DELETE Operation ---
        public async Task<bool> DeleteUserAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id); // Use _context

            if (userToDelete == null)
            {
                return false; // User not found
            }

            // Optional: Check for related records (e.g., bookings, comments) before deleting
            // Example:
            // var hasBookings = await _context.Bookings.AnyAsync(b => b.UserId == id);
            // if (hasBookings) { throw new InvalidOperationException("Cannot delete user with existing bookings."); }

            _context.Users.Remove(userToDelete); // Remove from DbContext, use _context
            int savedChanges = await _context.SaveChangesAsync(); // Save changes, use _context

            return savedChanges > 0; // Returns true if at least one record was affected
        }

        // --- Password Change Operation ---
        public async Task<bool> ChangePasswordAsync(int userId, ChangePasswordDTO changePasswordDto)
        {
            var user = await _context.Users.FindAsync(userId); // Use _context

            if (user == null)
            {
                return false; // User not found
            }

            // 1. Verify the current password using the injected _passwordHasher
            // Arguments: (user object, stored hashed password, provided plain-text password)
            var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, changePasswordDto.CurrentPassword);

            if (verificationResult == PasswordVerificationResult.Failed)
            {
                throw new UnauthorizedAccessException("The current password provided is incorrect.");
            }

            // 2. Validate the new password
            if (string.IsNullOrWhiteSpace(changePasswordDto.NewPassword) || changePasswordDto.NewPassword.Length < 6)
            {
                throw new ArgumentException("New password must be at least 6 characters long.", nameof(changePasswordDto.NewPassword));
            }

            // Optional: Prevent reuse of old password (compare plain text with provided current password)
            if (changePasswordDto.NewPassword.Equals(changePasswordDto.CurrentPassword, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("New password cannot be the same as the current password.");
            }

            // 3. Hash the new password and update the user entity
            user.Password = _passwordHasher.HashPassword(user, changePasswordDto.NewPassword);

            _context.Entry(user).State = EntityState.Modified; // Mark as modified, use _context
            int savedChanges = await _context.SaveChangesAsync(); // Save changes, use _context

            return savedChanges > 0;
        }

        // --- User Credential Verification (Login) ---
        public async Task<UserDTO?> VerifyUserCredentialsAsync(string email, string plainTextPassword) // Changed return type to UserDTO?
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(plainTextPassword))
            {
                return null; // Invalid input
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserEmail == email); // Use _context

            if (user == null)
            {
                return null; // User not found
            }

            // Verify the provided plain-text password against the stored hash
            var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, plainTextPassword);

            if (verificationResult == PasswordVerificationResult.Success ||
                verificationResult == PasswordVerificationResult.SuccessRehashNeeded)
            {
                if (verificationResult == PasswordVerificationResult.SuccessRehashNeeded)
                {
                    // If the hash needs to be updated (e.g., stronger algorithm available), re-hash and save
                    user.Password = _passwordHasher.HashPassword(user, plainTextPassword);
                    await _context.SaveChangesAsync(); // Save the rehashed password
                }

                return new UserDTO
                {
                    UserId = user.UserId,
                    UserName = user.UserName,
                    UserEmail = user.UserEmail,
                    Age = user.Age,
                    Gender = user.Gender,
                    MobileNo = user.MobileNo,
                    Address = user.Address
                };
            }
            return null; // Password mismatch
        }
    }
}
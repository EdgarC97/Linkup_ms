using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.Models;
using Linkup_ms.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linkup_ms.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all users from the database, including their associated sector and role information.
        /// </summary>
        /// <remarks>
        /// Returns a list of users or a 500 error message if an error occurs.
        /// </remarks>
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _context.Users
                    .Include(u => u.Sector)
                    .Include(u => u.Role)
                    .ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving users", error = ex.Message });
            }
        }

        /// <summary>
        /// Retrieves a user by their email address, including associated sector and role information.
        /// </summary>
        /// <remarks>
        /// Returns the user or a 404 error if not found.
        /// </remarks>
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            try
            {
                var user = await _context.Users
                    .Include(u => u.Sector)
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Email == email);

                if (user == null)
                    return NotFound(new { message = "User not found." });

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving the user.", error = ex.Message });
            }
        }


        /// <summary>
        /// Updates the email and phone number of a user identified by their email address.
        /// </summary>
        /// <remarks>
        /// Allows partial updates and returns 404 if the user is not found.
        /// </remarks>
        [HttpPatch("{email}")]
        public async Task<IActionResult> PatchUser(string email, [FromBody] UserPathDto updatedData)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (user == null)
                    return NotFound(new { message = "User not found." });

                // Update only the email and phoneNumber fields if they are present
                if (!string.IsNullOrEmpty(updatedData.Email))
                {
                    user.Email = updatedData.Email;
                }
                if (!string.IsNullOrEmpty(updatedData.PhoneNumber))
                {
                    user.PhoneNumber = updatedData.PhoneNumber;
                }

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the user.", error = ex.Message });
            }
        }

        /// <summary>
        /// Deletes a user identified by their email address.
        /// </summary>
        /// <remarks>
        /// Returns a success message or a 404 error if the user is not found.
        /// </remarks>
        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteUser(string email)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (user == null)
                    return NotFound(new { message = "User not found." });

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return Ok(new { message = "User deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the user.", error = ex.Message });
            }
        }


        /// <summary>
        /// Resets the password for a user identified by their email address.
        /// </summary>
        /// <remarks>
        /// Updates the password or returns errors for not found or mismatched passwords.
        /// </remarks>
        [HttpPatch("reset-password/{email}")]
        public async Task<IActionResult> PatchPassword(string email, [FromBody] ResetPasswordDto resetPasswordDto)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (user == null)
                {
                    return NotFound(new { message = "User not found." });
                }

                if (resetPasswordDto.NewPassword != resetPasswordDto.ConfirmPassword)
                {
                    return BadRequest(new { message = "Passwords do not match." });
                }

                using (var hmac = new HMACSHA512())
                {
                    user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(resetPasswordDto.NewPassword));
                    user.PasswordSalt = hmac.Key;
                }

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Password successfully updated." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while resetting the password.", error = ex.Message });
            }
        }

    }
}
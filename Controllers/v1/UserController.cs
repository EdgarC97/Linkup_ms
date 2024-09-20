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

        //Get : api/User (All Users)
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
                return StatusCode(500, new { message = "An error occured while retrieving users", error = ex.Message });
            }
        }

        // GET: api/User/email/{email} (search user by email)
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

        // PATCH: api/User/{email} (search user by email and update only email and phonenumber)
        [HttpPatch("{email}")]
        public async Task<IActionResult> PatchUser(string email, [FromBody] UserPathDto updatedData)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (user == null)
                    return NotFound(new { message = "User not found." });

                // Actualiza solo los campos de email y phoneNumber si están presentes
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

        // DELETE: api/User/{email} (Delete user by email)
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

        // PATCH: api/User/reset-password/{email} (search user by enail and reset password)
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
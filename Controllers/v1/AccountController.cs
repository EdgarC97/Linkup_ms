using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Interfaces;
using Backend_Riwi_LinkUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly AppDbContext _context;

        public AccountController(ITokenService tokenService, AppDbContext context)
        {
            _tokenService = tokenService;
            _context = context;
        }

        /// <summary>
        /// Registers a new user in the system.
        /// </summary>
        /// <remarks>
        /// This endpoint allows the creation of a new user. It first checks if the email is already in use. If the email is not taken, it hashes the user's password and saves the user details in the database.
        /// </remarks>
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterUserDto registerUserDto)
        {
            if (await UserExists(registerUserDto.Email))
            {
                return BadRequest("Email is already taken");
            }

            using var hmac = new HMACSHA512();
            var user = new User
            {
                Name = registerUserDto.Name,
                Email = registerUserDto.Email,
                PhoneNumber = registerUserDto.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                SectorId = registerUserDto.SectorId,
                RoleId = 2,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerUserDto.Password)),
                PasswordSalt = hmac.Key
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto
            {
                Email = user.Email,
                Token = _tokenService.CreateToken(user),
            };
        }


        /// <summary>
        /// Authenticates a user and generates an authentication token.
        /// </summary>
        /// <remarks>
        /// This endpoint checks the provided email and password against the stored user credentials. If the email exists and the password is correct, it returns a token for the user. If either the email is invalid or the password is incorrect, it returns an Unauthorized response.
        /// </remarks>
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginUserDto loginUserDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Email == loginUserDto.Email.ToLower());
            if (user == null)
            {
                return Unauthorized("Invalid email");
            }

            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginUserDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                    return Unauthorized("Invalid password");
            }

            return new UserDto
            {
                RoleId = user.RoleId,
                Email = user.Email,
                Token = _tokenService.CreateToken(user),
            };
        }
        
        private async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }
    }
}
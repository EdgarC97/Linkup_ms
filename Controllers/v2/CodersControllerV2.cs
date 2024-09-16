using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Controllers.v2
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class CodersControllerV2 : ControllerBase
    {
        private readonly AppDbContext _context;

        public CodersControllerV2(AppDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> GetCoders()
        {
            var coders = await _context.Coders
                .Select(c => new CoderDtoV2
                {
                    Id = c.Id,
                    Name = c.Name,
                    Birthday = c.Birthday,
                    UrlImage = c.UrlImage,
                    Description = c.Description
                })
                .ToListAsync();

            return Ok(coders);
        }

        // GET /id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoder(int id)
        {
            var coder = await _context.Coders
                .Where(c => c.Id == id)
                .Select(c => new CoderDtoV2
                {
                    Id = c.Id,
                    Name = c.Name,
                    Birthday = c.Birthday,
                    UrlImage = c.UrlImage,
                    Description = c.Description
                })
                .FirstOrDefaultAsync();

            if (coder == null)
            {
                return NotFound();
            }

            return Ok(coder);
        }
    }
}

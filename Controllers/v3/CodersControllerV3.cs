using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Linkup_ms.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Controllers.v3
{
    // Defines the API controller for Coders and specifies the route
    [ApiController]
    [Route("api/v3/[controller]")]
    public class CodersControllerV3 : ControllerBase
    {
        // Dependency injection for the database context
        private readonly AppDbContext _context;

        public CodersControllerV3(AppDbContext context)
        {
            _context = context;
        }

        // Endpoint to filter coders based on various query parameters
        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<CoderDto>>> FilterCoders(
            [FromQuery] int? clanId, // Optional clanId filter
            [FromQuery] int? genderId, // Optional genderId filter
            [FromQuery] List<int> languageIds, // List of language IDs to filter by
            [FromQuery] List<int> technicalSkillIds, // List of technical skill IDs to filter by
            [FromQuery] List<int> softSkillIds // List of soft skill IDs to filter by
        )
        {
            // Base query to fetch coders with related data using eager loading
            var query = _context.Coders
                .Include(c => c.Gender) // Include gender relationship
                .Include(c => c.Clan) // Include clan relationship
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill) // Include soft skills relationship
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language) // Include language relationship
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill) // Include technical skills relationship
                .AsQueryable(); // Makes the query flexible for further conditions

            // Apply clan filter if specified
            if (clanId.HasValue)
            {
                query = query.Where(c => c.ClanId == clanId.Value);
            }

            // Apply gender filter if specified
            if (genderId.HasValue)
            {
                query = query.Where(c => c.GenderId == genderId.Value);
            }

            // Apply language filter if any language IDs are specified
            if (languageIds.Any())
            {
                query = query.Where(c => c.CoderLanguages.Any(cl => languageIds.Contains(cl.LanguageId)));
            }

            // Apply technical skill filter if any technical skill IDs are specified
            if (technicalSkillIds.Any())
            {
                query = query.Where(c => c.CoderTechnicalSkills.Any(cts => technicalSkillIds.Contains(cts.TechnicalSkillId)));
            }

            // Apply soft skill filter if any soft skill IDs are specified
            if (softSkillIds.Any())
            {
                query = query.Where(c => c.CoderSoftSkills.Any(css => softSkillIds.Contains(css.SoftSkillId)));
            }

            // Executes the query and maps the result to a list of CoderDto
            var filteredCoders = await query
                .Select(c => new CoderDtoV3
                {
                    Id = c.Id,
                    Name = c.Name,
                    UrlImage = c.UrlImage,
                    Birthday = c.Birthday,

                })
                .ToListAsync(); // Execute query asynchronously

            // Return the filtered list of coders in the response
            return Ok(filteredCoders);
        }
    }
}

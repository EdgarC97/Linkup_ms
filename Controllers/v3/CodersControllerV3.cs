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
    // Defines the API controller for Coders and specifies the route for version 3 of the API.
    [ApiController]
    [Route("api/v3/[controller]")]
    [ApiExplorerSettings(GroupName = "v3")]
    public class CodersControllerV3 : ControllerBase
    {
        // Dependency injection for the database context. This provides access to the data layer.
        private readonly AppDbContext _context;

        public CodersControllerV3(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Filters coders based on various query parameters.
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to filter coders using optional query parameters. You can filter by clan ID, gender ID, and by multiple IDs for languages, technical skills, and soft skills. The query will return a list of coders matching the specified criteria. If no filters are applied, it will return all coders.
        ///
        /// The query parameters are:
        /// - `clanId` (optional): Filter coders by a specific clan ID.
        /// - `genderId` (optional): Filter coders by a specific gender ID.
        /// - `languageIds`: Filter coders by a list of language IDs they are associated with.
        /// - `technicalSkillIds`: Filter coders by a list of technical skill IDs they possess.
        /// - `softSkillIds`: Filter coders by a list of soft skill IDs they have.
        ///
        /// The result will include coders with their related data such as gender, clan, soft skills, languages, and technical skills.
        /// </remarks>
        
        //GET /api/v3/coders/filter?
        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<CoderDto>>> FilterCoders(
            [FromQuery] int? clanId,
            [FromQuery] int? genderId,
            [FromQuery] List<int> languageIds,
            [FromQuery] List<int> technicalSkillIds,
            [FromQuery] List<int> softSkillIds
        )
        {
            // Start the query for coders, including related entities for filtering.
            var query = _context.Coders
                .Include(c => c.Gender) // Includes the related Gender entity for each coder.
                .Include(c => c.Clan) // Includes the related Clan entity for each coder.
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill) // Includes the related SoftSkill entities for each coder.
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language) // Includes the related Language entities for each coder.
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill) // Includes the related TechnicalSkill entities for each coder.
                .AsQueryable(); // Converts the query to IQueryable for further filtering.


            // Apply filtering based on optional query parameters.
            if (clanId.HasValue)
            {
                query = query.Where(c => c.ClanId == clanId.Value); // Filter by clan ID if provided.
            }

            if (genderId.HasValue)
            {
                query = query.Where(c => c.GenderId == genderId.Value); // Filter by gender ID if provided.
            }

            if (languageIds.Any())
            {
                query = query.Where(c => c.CoderLanguages.Any(cl => languageIds.Contains(cl.LanguageId))); // Filter by language IDs if provided.
            }

            if (technicalSkillIds.Any())
            {
                query = query.Where(c => c.CoderTechnicalSkills.Any(cts => technicalSkillIds.Contains(cts.TechnicalSkillId))); // Filter by technical skill IDs if provided.
            }

            if (softSkillIds.Any())
            {
                query = query.Where(c => c.CoderSoftSkills.Any(css => softSkillIds.Contains(css.SoftSkillId))); // Filter by soft skill IDs if provided.
            }

            // Execute the query and project the results into a list of CoderDtoV3.
            var filteredCoders = await query
                .Select(c => new CoderDtoV3
                {
                    Id = c.Id, // Selects the ID of the coder.
                    Name = c.Name, // Selects the name of the coder.
                    UrlImage = c.UrlImage, // Selects the URL of the coder's image.
                    Birthday = c.Birthday, // Selects the birthday of the coder.
                })
                .ToListAsync(); // Converts the results to a list asynchronously.

            // Return the filtered coders with an HTTP 200 OK status.
            return Ok(filteredCoders);
        }

    }
}

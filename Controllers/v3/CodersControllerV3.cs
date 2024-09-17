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
        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<CoderDto>>> FilterCoders(
            [FromQuery] int? clanId, 
            [FromQuery] int? genderId, 
            [FromQuery] List<int> languageIds, 
            [FromQuery] List<int> technicalSkillIds, 
            [FromQuery] List<int> softSkillIds 
        )
        {

            var query = _context.Coders
                .Include(c => c.Gender) 
                .Include(c => c.Clan) 
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill) 
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language) 
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill) 
                .AsQueryable();


            if (clanId.HasValue)
            {
                query = query.Where(c => c.ClanId == clanId.Value);
            }


            if (genderId.HasValue)
            {
                query = query.Where(c => c.GenderId == genderId.Value);
            }


            if (languageIds.Any())
            {
                query = query.Where(c => c.CoderLanguages.Any(cl => languageIds.Contains(cl.LanguageId)));
            }


            if (technicalSkillIds.Any())
            {
                query = query.Where(c => c.CoderTechnicalSkills.Any(cts => technicalSkillIds.Contains(cts.TechnicalSkillId)));
            }


            if (softSkillIds.Any())
            {
                query = query.Where(c => c.CoderSoftSkills.Any(css => softSkillIds.Contains(css.SoftSkillId)));
            }

            var filteredCoders = await query
                .Select(c => new CoderDtoV3
                {
                    Id = c.Id,
                    Name = c.Name,
                    UrlImage = c.UrlImage,
                    Birthday = c.Birthday,
                })
                .ToListAsync(); 


            return Ok(filteredCoders);
        }

    }
}

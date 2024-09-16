using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Controllers.v3
{
    [ApiController]
    [Route("api/v3/[controller]")]
    public class CodersControllerV3 : ControllerBase
    {
        private readonly AppDbContext _context;

        public CodersControllerV3(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<CoderDto>>> FilterCoders(
    [FromQuery] int? clanId,
    [FromQuery] int? genderId,
    [FromQuery] List<int> languageIds,
    [FromQuery] List<int> technicalSkillIds,
    [FromQuery] List<int> softSkillIds)
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
                .Select(c => new CoderDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    GenderName = c.Gender.Name,
                    ClanName = c.Clan.Name,
                    SoftSkills = c.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
                    LanguageLevels = c.CoderLanguages.Select(cl => new LanguageLevelDto
                    {
                        Id = cl.LanguageLevel.Id,
                        LevelName = cl.LanguageLevel.Name,
                        LanguageName = cl.Language.Name
                    }).ToList(),
                    TechnicalSkillLevels = c.CoderTechnicalSkills.Select(cts => new TechnicalSkillDto
                    {
                        Id = cts.TechnicalSkillLevel.Id,
                        LevelName = cts.TechnicalSkillLevel.Name,
                        TechnicalSkillName = cts.TechnicalSkill.Name
                    }).ToList()
                })
                .ToListAsync();

            return Ok(filteredCoders);
        }

    }
}

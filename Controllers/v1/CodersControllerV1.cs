using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Models;
using Linkup_ms.DTOS;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.ControllersV1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CodersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CodersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/Coders
        [HttpGet]
        public async Task<IActionResult> GetCoders()
        {
            var coders = await _context.Coders
                .Include(c => c.Gender)
                .Include(c => c.Clan)
                .Include(c => c.CoderSoftSkills)
                    .ThenInclude(css => css.SoftSkill)
                .Include(c => c.CoderLanguages)
                    .ThenInclude(cl => cl.LanguageLevel)
                .Include(c => c.CoderTechnicalSkills)
                    .ThenInclude(cts => cts.TechnicalSkillLevel)
                .Select(c => new CoderDtoV1
                {
                    Id = c.Id,
                    Name = c.Name,
                    GenderName = c.Gender.Name,
                    ClanName = c.Clan.Name,
                    Birthday = c.Birthday,
                    Description = c.Description,
                    UrlImage = c.UrlImage,
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

            return Ok(coders);
        }

        // GET: api/v1/Coders/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoder(int id)
        {
            var coder = await _context.Coders
                .Include(c => c.Gender)
                .Include(c => c.Clan)
                .Include(c => c.CoderSoftSkills)
                    .ThenInclude(css => css.SoftSkill)
                .Include(c => c.CoderLanguages)
                    .ThenInclude(cl => cl.LanguageLevel)
                .Include(c => c.CoderTechnicalSkills)
                    .ThenInclude(cts => cts.TechnicalSkillLevel)
                .Select(c => new CoderResponseDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    GenderId = c.Gender.Id,
                    GenderName = c.Gender.Name,
                    ClanId = c.Clan.Id,
                    ClanName = c.Clan.Name,
                    Birthday = c.Birthday,
                    Description = c.Description,
                    UrlImage = c.UrlImage,
                    SoftSkills = c.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
                    LanguageLevels = c.CoderLanguages.Select(cl => new LanguageLevelDto
                    {
                        Id = cl.LanguageId,
                        LevelName = cl.LanguageLevel.Name,
                        LevelId = cl.LanguageLevel.Id,
                        LanguageName = cl.Language.Name,
                    }).ToList(),
                    TechnicalSkillLevels = c.CoderTechnicalSkills.Select(cts => new TechnicalSkillDto
                    {
                        Id = cts.TechnicalSkillId,
                        LevelName = cts.TechnicalSkill.Name,
                        TechnicalSkillName = cts.TechnicalSkill.Name,
                        LevelId = cts.TechnicalSkillLevelId
                    }).ToList()
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            if (coder == null)
            {
                return NotFound();
            }

            return Ok(coder);
        }

        // GET: api/v1/Coders/Genders
        [HttpGet("Genders")]
        public async Task<ActionResult<IEnumerable<GenderDto>>> GetGenders()
        {
            var genders = await _context.Genders
                .Select(g => new GenderDto { Id = g.Id, Name = g.Name })
                .ToListAsync();

            return Ok(genders);
        }

        // GET: api/v1/Coders/Clans
        [HttpGet("Clans")]
        public async Task<ActionResult<IEnumerable<ClanDto>>> GetClans()
        {
            var clans = await _context.Clans
                .Select(c => new ClanDto { Id = c.Id, Name = c.Name })
                .ToListAsync();

            return Ok(clans);
        }

        // GET: api/v1/Coders/SoftSkills
        [HttpGet("SoftSkills")]
        public async Task<ActionResult<IEnumerable<SoftSkillDto>>> GetSoftSkills()
        {
            var softSkills = await _context.SoftSkills
                .Select(ss => new SoftSkillDto { Id = ss.Id, Name = ss.Name })
                .ToListAsync();

            return Ok(softSkills);
        }

        // GET: api/v1/Coders/Languages
        [HttpGet("Languages")]
        public async Task<ActionResult<IEnumerable<LanguageDto>>> GetLanguages()
        {
            var languages = await _context.Languages
                .Select(l => new LanguageDto { Id = l.Id, Name = l.Name })
                .ToListAsync();

            return Ok(languages);
        }

        // GET: api/v1/Coders/TechnicalSkills
        [HttpGet("TechnicalSkills")]
        public async Task<ActionResult<IEnumerable<TechnicalSkillDtoV1>>> GetTechnicalSkills()
        {
            var technicalSkills = await _context.TechnicalSkills
                .Select(ts => new TechnicalSkillDtoV1
                {
                    Id = ts.Id,
                    TechnicalSkillName = ts.Name
                })
                .ToListAsync();

            return Ok(technicalSkills);
        }

        // GET: api/v1/Coders/LanguageLevels
        [HttpGet("LanguageLevels")]
        public async Task<ActionResult<IEnumerable<LanguageLevelDto>>> GetLanguageLevels()
        {
            var languageLevels = await _context.LanguageLevels
                .Select(ll => new LanguageLevelDto { Id = ll.Id, LanguageName = ll.Name })
                .ToListAsync();

            return Ok(languageLevels);
        }

        // GET: api/v1/Coders/TechnicalSkillLevels
        [HttpGet("TechnicalSkillLevels")]
        public async Task<ActionResult<IEnumerable<TechnicalSkillLevelDto>>> GetTechnicalSkillLevels()
        {
            var technicalSkillLevels = await _context.TechnicalSkillLevels
                .Select(tsl => new TechnicalSkillLevelDto { Id = tsl.Id, Name = tsl.Name })
                .ToListAsync();

            return Ok(technicalSkillLevels);
        }
    }
}
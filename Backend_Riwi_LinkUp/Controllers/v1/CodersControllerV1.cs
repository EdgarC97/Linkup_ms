// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Backend_Riwi_LinkUp.Data;
// using Backend_Riwi_LinkUp.DTOS;
// using Backend_Riwi_LinkUp.Models;
// using Microsoft.AspNetCore.JsonPatch;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace Backend_Riwi_LinkUp.ControllersV1
// {
//     [ApiController]
//     [Route("api/v1/[controller]")]
//     public class CodersController : ControllerBase
//     {
//         private readonly AppDbContext _context;

//         public CodersController(AppDbContext context)
//         {
//             _context = context;
//         }


//         //GET
//         [HttpGet]
//         public async Task<IActionResult> GetCoders()
//         {
//             var coders = await _context.Coders
//                 .Include(c => c.Gender)
//                 .Include(c => c.Clan)
//                 .Include(c => c.CoderSoftSkills)
//                     .ThenInclude(css => css.SoftSkill)
//                 .Include(c => c.CoderLanguageLevels)
//                     .ThenInclude(cll => cll.LanguageLevel)
//                         .ThenInclude(ll => ll.Language)
//                 .Include(c => c.CoderTechnicalSkillLevels)
//                     .ThenInclude(ctsl => ctsl.TechnicalSkillLevel)
//                         .ThenInclude(tsl => tsl.TechnicalSkill)
//                 .Select(c => new CoderDtoV1
//                 {
//                     Id = c.Id,
//                     Name = c.Name,
//                     GenderName = c.Gender.Name,
//                     ClanName = c.Clan.Name,
//                     Birthday = c.Birthday,
//                     Description = c.Description,
//                     UrlImage = c.UrlImage,
//                     SoftSkills = c.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
//                     LanguageLevels = c.CoderLanguageLevels.Select(cll => new LanguageLevelDto
//                     {
//                         LevelName = cll.LanguageLevel.Name,
//                         LanguageName = cll.LanguageLevel.Language.Name
//                     }).ToList(),
//                     TechnicalSkillLevels = c.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillDto
//                     {
//                         LevelName = ctsl.TechnicalSkillLevel.Name,
//                         TechnicalSkillName = ctsl.TechnicalSkillLevel.TechnicalSkill.Name
//                     }).ToList()
//                 })
//                 .ToListAsync();

//             GET
//             [HttpGet]
//         public async Task<IActionResult> GetCoders()
//         {
//             var coders = await _context.Coders
//                 .Include(c => c.Gender)
//                 .Include(c => c.Clan)
//                 .Include(c => c.CoderSoftSkills)
//                     .ThenInclude(css => css.SoftSkill)
//                 .Include(c => c.CoderLanguageLevels)
//                     .ThenInclude(cll => cll.LanguageLevel)
//                         .ThenInclude(ll => ll.Language)
//                 .Include(c => c.CoderTechnicalSkillLevels)
//                     .ThenInclude(ctsl => ctsl.TechnicalSkillLevel)
//                         .ThenInclude(tsl => tsl.TechnicalSkill)
//                 .Select(c => new CoderDtoV1
//                 {
//                     Id = c.Id,
//                     Name = c.Name,
//                     GenderName = c.Gender.Name,
//                     ClanName = c.Clan.Name,
//                     Birthday = c.Birthday,
//                     Description = c.Description,
//                     UrlImage = c.UrlImage,
//                     SoftSkills = c.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
//                     LanguageLevels = c.CoderLanguageLevels.Select(cll => new LanguageLevelDto
//                     {
//                         LanguageName = cll.LanguageLevel.Language.Name
//                     }).ToList(),
//                     TechnicalSkillLevels = c.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillDto
//                     {
//                         LevelName = ctsl.TechnicalSkillLevel.Name,
//                         TechnicalSkillName = ctsl.TechnicalSkillLevel.TechnicalSkill.Name
//                     }).ToList()
//                 })
//                 .ToListAsync();


//             return Ok(coders);
//         }

//         //GET / id
//         [HttpGet("{id}")]
//         public async Task<IActionResult> GetCoder(int id)
//         {
//             var coder = await _context.Coders
//                 .Include(c => c.Gender)
//                 .Include(c => c.Clan)
//                 .Include(c => c.CoderSoftSkills)
//                     .ThenInclude(css => css.SoftSkill)
//                 .Include(c => c.CoderLanguageLevels)
//                     .ThenInclude(cll => cll.LanguageLevel)
//                         .ThenInclude(ll => ll.Language)
//                 .Include(c => c.CoderTechnicalSkillLevels)
//                     .ThenInclude(ctsl => ctsl.TechnicalSkillLevel)
//                         .ThenInclude(tsl => tsl.TechnicalSkill)
//                 .FirstOrDefaultAsync(c => c.Id == id);

//             if (coder == null)
//             {
//                 return NotFound();
//             }


//             var coderDto = new CoderDtoV1
//             {
//                 Id = coder.Id,
//                 Name = coder.Name,
//                 GenderName = coder.Gender.Name,
//                 ClanName = coder.Clan.Name,
//                 Birthday = coder.Birthday,
//                 Description = coder.Description,
//                 UrlImage = coder.UrlImage,
//                 SoftSkills = coder.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
//                 LanguageLevels = coder.CoderLanguageLevels.Select(cll => new LanguageLevelDto
//                 {
//                     LevelName = cll.LanguageLevel.Name,
//                     LanguageName = cll.LanguageLevel.Language.Name
//                 }).ToList(),
//                 TechnicalSkillLevels = coder.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillDto
//                 {
//                     LevelName = ctsl.TechnicalSkillLevel.Name,
//                     TechnicalSkillName = ctsl.TechnicalSkillLevel.TechnicalSkill.Name
//                 }).ToList()
//             };

//             var coderDto = new CoderDtoV1
//             {
//                 Id = coder.Id,
//                 Name = coder.Name,
//                 GenderName = coder.Gender.Name,
//                 ClanName = coder.Clan.Name,
//                 Birthday = coder.Birthday,
//                 Description = coder.Description,
//                 UrlImage = coder.UrlImage,
//                 SoftSkills = coder.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
//                 LanguageLevels = coder.CoderLanguageLevels.Select(cll => new LanguageLevelDto
//                 {
//                     LanguageName = cll.LanguageLevel.Language.Name
//                 }).ToList(),
//                 TechnicalSkillLevels = coder.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillDto
//                 {
//                     LevelName = ctsl.TechnicalSkillLevel.Name,
//                     TechnicalSkillName = ctsl.TechnicalSkillLevel.TechnicalSkill.Name
//                 }).ToList()
//             };


//             return Ok(coderDto);
//         }


//         POST: api/v1/Coders
//         [HttpPost]
//         public async Task<IActionResult> CreateCoder([FromBody] CoderCreationDto coderDto)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             var gender = await _context.Genders.FindAsync(coderDto.GenderId);
//             if (gender == null)
//             {
//                 return BadRequest("El género especificado no existe.");
//             }

//             var clan = await _context.Clans.FindAsync(coderDto.ClanId);
//             if (clan == null)
//             {
//                 return BadRequest("El clan especificado no existe.");
//             }

//             var coder = new Coder
//             {
//                 Name = coderDto.Name,
//                 Birthday = coderDto.Birthday,
//                 Description = coderDto.Description,
//                 UrlImage = coderDto.UrlImage,
//                 GenderId = coderDto.GenderId,
//                 ClanId = coderDto.ClanId
//             };

//             _context.Coders.Add(coder);
//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateException ex)
//             {
//                 Manejo del error más detallado
//                 return StatusCode(500, $"Error al guardar en la base de datos: {ex.Message}");
//             }

//             Agregar relaciones
//             await AddCoderRelationships(coder.Id, coderDto);

//             Crear DTO de respuesta
//             var responseDto = await CreateCoderResponseDto(coder.Id);

//             return CreatedAtAction(nameof(GetCoder), new { id = coder.Id }, responseDto);
//         }

//         private async Task AddCoderRelationships(int coderId, CoderCreationDto coderDto)
//         {
//             foreach (var skillId in coderDto.SoftSkillIds)
//             {
//                 _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
//             }

//             foreach (var levelId in coderDto.LanguageLevelIds)
//             {
//                 _context.CoderLanguageLevels.Add(new CoderLanguageLevel { CoderId = coderId, LanguageLevelId = levelId });
//             }

//             foreach (var levelId in coderDto.TechnicalSkillLevelIds)
//             {
//                 _context.CoderTechnicalSkillLevels.Add(new CoderTechnicalSkillLevel { CoderId = coderId, TechnicalSkillLevelId = levelId });
//             }

//             await _context.SaveChangesAsync();
//         }

//         private async Task<CoderResponseDto> CreateCoderResponseDto(int coderId)
//         {
//             var coder = await _context.Coders
//                 .Include(c => c.Gender)
//                 .Include(c => c.Clan)
//                 .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill)
//                 .Include(c => c.CoderLanguageLevels).ThenInclude(cll => cll.LanguageLevel)
//                 .ThenInclude(ll => ll.Language)
//                 .Include(c => c.CoderTechnicalSkillLevels).ThenInclude(ctsl => ctsl.TechnicalSkillLevel)
//                 .ThenInclude(tsl => tsl.TechnicalSkill)
//                 .FirstOrDefaultAsync(c => c.Id == coderId);

//             return new CoderResponseDto
//             {
//                 Id = coder.Id,
//                 Name = coder.Name,
//                 Birthday = coder.Birthday,
//                 Description = coder.Description,
//                 UrlImage = coder.UrlImage,
//                 GenderId = coder.GenderId,
//                 ClanId = coder.ClanId,
//                 GenderName = coder.Gender.Name,
//                 SoftSkills = coder.CoderSoftSkills.Select(css => css.SoftSkill.Name).ToList(),
//                 LanguageLevels = coder.CoderLanguageLevels.Select(cll => new LanguageLevelDto
//                 {
//                     Name = cll.LanguageLevel.Name,
//                     LanguageName = cll.LanguageLevel.Language.Name
//                 }).ToList(),
//                 TechnicalSkillLevels = coder.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillDto
//                 {
//                     LevelName = ctsl.TechnicalSkillLevel.Name,
//                     TechnicalSkillName = ctsl.TechnicalSkillLevel.TechnicalSkill.Name
//                 }).ToList()
//             };
//         }

//         GET: api/v1/Coders/Genders
//         [HttpGet("Genders")]
//         public async Task<ActionResult<IEnumerable<GenderDto>>> GetGenders()
//         {
//             var genders = await _context.Genders
//                 .Select(g => new GenderDto { Id = g.Id, Name = g.Name })
//                 .ToListAsync();

//             return Ok(genders);
//         }

//         GET: api/v1/Coders/Clans
//         [HttpGet("Clans")]
//         public async Task<ActionResult<IEnumerable<ClanDto>>> GetClans()
//         {
//             var clans = await _context.Clans
//                 .Select(c => new ClanDto { Id = c.Id, Name = c.Name })
//                 .ToListAsync();

//             return Ok(clans);
//         }

//         GET: api/v1/Coders/SoftSkills
//         [HttpGet("SoftSkills")]
//         public async Task<ActionResult<IEnumerable<SoftSkillDto>>> GetSoftSkills()
//         {
//             var softSkills = await _context.SoftSkills
//                 .Select(ss => new SoftSkillDto { Id = ss.Id, Name = ss.Name })
//                 .ToListAsync();

//             return Ok(softSkills);
//         }

//         GET: api/v1/Coders/Clans
//         [HttpGet("Languages")]
//         public async Task<ActionResult<IEnumerable<ClanDto>>> GetLanguages()
//         {
//             var clans = await _context.Languages
//                 .Select(c => new ClanDto { Id = c.Id, Name = c.Name })
//                 .ToListAsync();

//             return Ok(clans);
//         }

//         GET: api/v1/Coders/LanguageLevels
//         [HttpGet("LanguageLevels")]
//         public async Task<ActionResult<IEnumerable<LanguageLevelDto>>> GetLanguageLevels()
//         {
//             var languageLevels = await _context.LanguageLevels
//                 .Select(ll => new LanguageLevelDto { Id = ll.Id, Name = ll.Name, LanguageName = ll.Language.Name })
//                 .ToListAsync();

//             return Ok(languageLevels);
//         }

//         GET: api/v1/Coders/TechnicalSkillLevels
//         [HttpGet("TechnicalSkillLevels")]
//         public async Task<ActionResult<IEnumerable<TechnicalSkillLevelDto>>> GetTechnicalSkillLevels()
//         {
//             var technicalSkillLevels = await _context.TechnicalSkillLevels
//                 .Select(tsl => new TechnicalSkillLevelDto { Id = tsl.Id, Name = tsl.Name, TechnicalSkillName = tsl.TechnicalSkill.Name })
//                 .ToListAsync();

//             return Ok(technicalSkillLevels);
//         }

//         //PUT
//         [HttpPut("{id}")]
//         public async Task<IActionResult> UpdateCoder(int id, [FromBody] CoderUpdateDto coderDto)
//         {
//             if (id != coderDto.Id)
//             {
//                 return BadRequest();
//             }

//             var existingCoder = await _context.Coders
//                 .Include(c => c.CoderSoftSkills)
//                 .Include(c => c.CoderLanguageLevels)
//                 .Include(c => c.CoderTechnicalSkillLevels)
//                 .FirstOrDefaultAsync(c => c.Id == id);

//             if (existingCoder == null)
//             {
//                 return NotFound();
//             }

//             // Update basic properties
//             existingCoder.Name = coderDto.Name.ToLower();
//             existingCoder.Birthday = coderDto.Birthday;
//             existingCoder.Description = coderDto.Description.ToLower();
//             existingCoder.UrlImage = coderDto.UrlImage.ToLower();
//             existingCoder.Clan.Name = coderDto.ClanName.ToLower();
//             existingCoder.GenderId = coderDto.GenderId;

//             // Clear existing relationships
//             _context.CoderSoftSkills.RemoveRange(existingCoder.CoderSoftSkills);
//             _context.CoderLanguageLevels.RemoveRange(existingCoder.CoderLanguageLevels);
//             _context.CoderTechnicalSkillLevels.RemoveRange(existingCoder.CoderTechnicalSkillLevels);

//             // Add new relationships
//             foreach (var softSkillId in coderDto.SoftSkillIds)
//             {
//                 _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = id, SoftSkillId = softSkillId });
//             }

//             foreach (var language in coderDto.Languages)
//             {
//                 var languageLevel = await _context.LanguageLevels
//                     .FirstOrDefaultAsync(ll => ll.LanguageId == language.LanguageId && ll.Id == language.LevelId);

//                 if (languageLevel != null)
//                 {
//                     _context.CoderLanguageLevels.Add(new CoderLanguageLevel { CoderId = id, LanguageLevelId = languageLevel.Id });
//                 }
//             }

//             foreach (var technicalSkill in coderDto.TechnicalSkills)
//             {
//                 var technicalSkillLevel = await _context.TechnicalSkillLevels
//                     .FirstOrDefaultAsync(tsl => tsl.TechnicalSkillId == technicalSkill.TechnicalSkillId && tsl.Id == technicalSkill.LevelId);

//                 if (technicalSkillLevel != null)
//                 {
//                     _context.CoderTechnicalSkillLevels.Add(new CoderTechnicalSkillLevel { CoderId = id, TechnicalSkillLevelId = technicalSkillLevel.Id });
//                 }
//             }

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!CoderExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         //PATCH
//         [HttpPatch("{id}")]
//         [Consumes("application/json-patch+json")]
//         public async Task<IActionResult> PatchCoder(int id, [FromBody] JsonPatchDocument<CoderPatchDto> patchDoc)
//         {
//             if (patchDoc == null)
//             {
//                 return BadRequest("Patch document is null");
//             }

//             var coder = await _context.Coders
//                 .Include(c => c.CoderSoftSkills)
//                 .Include(c => c.CoderLanguageLevels)
//                 .Include(c => c.CoderTechnicalSkillLevels)
//                 .FirstOrDefaultAsync(c => c.Id == id);

//             if (coder == null)
//             {
//                 return NotFound();
//             }

//             var coderPatchDto = new CoderPatchDto
//             {
//                 Name = coder.Name,
//                 Birthday = coder.Birthday,
//                 Description = coder.Description,
//                 UrlImage = coder.UrlImage,
//                 ClanName = coder.Clan.Name,
//                 GenderId = coder.GenderId,
//                 SoftSkillIds = coder.CoderSoftSkills.Select(css => css.SoftSkillId).ToList(),
//                 Languages = coder.CoderLanguageLevels.Select(cll => new LanguageWithLevelDto
//                 {
//                     LanguageId = cll.LanguageLevel.LanguageId,
//                     LevelId = cll.LanguageLevel.Id
//                 }).ToList(),
//                 TechnicalSkills = coder.CoderTechnicalSkillLevels.Select(ctsl => new TechnicalSkillWithLevelDto
//                 {
//                     TechnicalSkillId = ctsl.TechnicalSkillLevel.TechnicalSkillId,
//                     LevelId = ctsl.TechnicalSkillLevel.Id
//                 }).ToList()
//             };

//             patchDoc.ApplyTo(coderPatchDto, ModelState);

//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             // Update basic properties
//             coder.Name = coderPatchDto.Name?.ToLower() ?? coder.Name;
//             coder.Birthday = coderPatchDto.Birthday ?? coder.Birthday;
//             coder.Description = coderPatchDto.Description?.ToLower() ?? coder.Description;
//             coder.UrlImage = coderPatchDto.UrlImage?.ToLower() ?? coder.UrlImage;
//             coder.Clan.Name = coderPatchDto.ClanName?.ToLower() ?? coder.Clan.Name;
//             coder.GenderId = coderPatchDto.GenderId ?? coder.GenderId;

//             // Update relationships
//             if (coderPatchDto.SoftSkillIds != null)
//             {
//                 _context.CoderSoftSkills.RemoveRange(coder.CoderSoftSkills);
//                 foreach (var skillId in coderPatchDto.SoftSkillIds)
//                 {
//                     _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = id, SoftSkillId = skillId });
//                 }
//             }

//             if (coderPatchDto.Languages != null)
//             {
//                 _context.CoderLanguageLevels.RemoveRange(coder.CoderLanguageLevels);
//                 foreach (var language in coderPatchDto.Languages)
//                 {
//                     var languageLevel = await _context.LanguageLevels
//                         .FirstOrDefaultAsync(ll => ll.LanguageId == language.LanguageId && ll.Id == language.LevelId);

//                     if (languageLevel != null)
//                     {
//                         _context.CoderLanguageLevels.Add(new CoderLanguageLevel { CoderId = id, LanguageLevelId = languageLevel.Id });
//                     }
//                 }
//             }

//             if (coderPatchDto.TechnicalSkills != null)
//             {
//                 _context.CoderTechnicalSkillLevels.RemoveRange(coder.CoderTechnicalSkillLevels);
//                 foreach (var technicalSkill in coderPatchDto.TechnicalSkills)
//                 {
//                     var technicalSkillLevel = await _context.TechnicalSkillLevels
//                         .FirstOrDefaultAsync(tsl => tsl.TechnicalSkillId == technicalSkill.TechnicalSkillId && tsl.Id == technicalSkill.LevelId);

//                     if (technicalSkillLevel != null)
//                     {
//                         _context.CoderTechnicalSkillLevels.Add(new CoderTechnicalSkillLevel { CoderId = id, TechnicalSkillLevelId = technicalSkillLevel.Id });
//                     }
//                 }
//             }

//             await _context.SaveChangesAsync();

//             return Ok("hola");
//         }

//         //DELETE
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> DeleteCoder(int id)
//         {
//             var coder = await _context.Coders.FindAsync(id);
//             if (coder == null)
//             {
//                 return NotFound();
//             }

//             _context.Coders.Remove(coder);
//             await _context.SaveChangesAsync();

//             return NoContent();
//         }

//         private bool CoderExists(int id)
//         {
//             return _context.Coders.Any(e => e.Id == id);
//         }
//     }
// }

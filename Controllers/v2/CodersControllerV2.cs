using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Models;
using Microsoft.AspNetCore.JsonPatch;
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

        /// <summary>
        /// Retrieves a list of all coders.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a list of all coders from the database. Each coder is represented by their ID, name, birthday, URL image, and description.
        /// </remarks>
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


        /// <summary>
        /// Retrieves a specific coder by their ID.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches the details of a single coder from the database based on the provided ID. The coder is represented by their ID, name, birthday, URL image, and description. If no coder is found with the given ID, it returns a 404 Not Found response.
        /// </remarks>
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


        /// <summary>
        /// Creates a new coder.
        /// </summary>
        /// <remarks>
        /// This endpoint allows for the creation of a new coder in the database. The coder's details are provided in the request body. The endpoint performs validation checks to ensure that the specified gender and clan exist. If the creation is successful, it returns a response with the details of the newly created coder. In case of errors, appropriate error messages are returned.
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> CreateCoder([FromBody] CoderCreationDto coderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gender = await _context.Genders.FindAsync(coderDto.GenderId);
            if (gender == null)
            {
                return BadRequest("El clan especificado no existe.");
            }

            var clan = await _context.Clans.FindAsync(coderDto.ClanId);
            if (clan == null)
            {
                return BadRequest("El clan especificado no existe.");
            }

            // Convert fields to lowercase
            coderDto.Name = coderDto.Name?.ToLower();
            coderDto.Description = coderDto.Description?.ToLower();
            coderDto.UrlImage = coderDto.UrlImage?.ToLower();

            var coder = new Coder
            {
                Name = coderDto.Name,
                Birthday = coderDto.Birthday,
                Description = coderDto.Description,
                UrlImage = coderDto.UrlImage,
                GenderId = coderDto.GenderId,
                ClanId = coderDto.ClanId
            };

            _context.Coders.Add(coder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"Error al guardar en la base de datos: {ex.Message}");
            }

            // Add relationships
            await AddCoderRelationships(coder.Id, coderDto);

            // Create response DTO
            var responseDto = await CreateCoderResponseDto(coder.Id);

            return CreatedAtAction(nameof(GetCoder), new { id = coder.Id }, new
            {
                message = "Coder created successfully",
                data = responseDto
            });
        }


        private async Task AddCoderRelationships(int coderId, CoderCreationDto coderDto)
        {
            foreach (var skillId in coderDto.SoftSkillIds)
            {
                _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
            }

            foreach (var languageDto in coderDto.Languages)
            {
                _context.CoderLanguages.Add(new CoderLanguage
                {
                    CoderId = coderId,
                    LanguageId = languageDto.Id,
                    LanguageLevelId = languageDto.LevelId
                });
            }

            foreach (var technicalSkillDto in coderDto.TechnicalSkills)
            {
                _context.CoderTechnicalSkills.Add(new CoderTechnicalSkill
                {
                    CoderId = coderId,
                    TechnicalSkillId = technicalSkillDto.Id,
                    TechnicalSkillLevelId = technicalSkillDto.LevelId
                });
            }

            await _context.SaveChangesAsync();
        }

        private async Task<CoderResponseDto> CreateCoderResponseDto(int coderId)
        {
            var coder = await _context.Coders
                .Include(c => c.Gender)
                .Include(c => c.Clan)
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.LanguageLevel)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkillLevel)
                .FirstOrDefaultAsync(c => c.Id == coderId);

            return new CoderResponseDto
            {
                Id = coder.Id,
                Name = coder.Name,
                Birthday = coder.Birthday,
                Description = coder.Description,
                UrlImage = coder.UrlImage,
                GenderId = coder.GenderId,
                ClanId = coder.ClanId,
                GenderName = coder.Gender?.Name,
                ClanName = coder.Clan?.Name,
                SoftSkills = coder.CoderSoftSkills?.Select(css => css.SoftSkill?.Name ?? "Unknown").ToList() ?? new List<string>(),
                LanguageLevels = coder.CoderLanguages?.Select(cl => new LanguageLevelDto
                {
                    Id = cl.LanguageId,
                    LevelId = cl.LanguageLevel.Id,
                    LanguageName = cl.Language?.Name ?? "Unknown",
                }).ToList() ?? new List<LanguageLevelDto>(),
                TechnicalSkillLevels = coder.CoderTechnicalSkills?.Select(cts => new TechnicalSkillDto
                {
                    Id = cts.TechnicalSkillId,
                    TechnicalSkillName = cts.TechnicalSkill?.Name ?? "Unknown",
                    LevelId = cts.TechnicalSkillLevelId
                }).ToList() ?? new List<TechnicalSkillDto>()
            };
        }

        /// <summary>
        /// Updates the details of an existing coder.
        /// </summary>
        /// <remarks>
        /// This endpoint updates the details of a coder in the database based on the provided ID. The updated details are provided in the request body. It performs validation to ensure that the coder exists and updates the coder's information accordingly. In case of errors during the update process, appropriate error messages are returned.
        /// </remarks>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCoder(int id, [FromBody] CoderUpdateDto coderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                return NotFound();
            }

            // Convert fields to lowercase
            coderDto.Name = coderDto.Name?.ToLower();
            coderDto.Description = coderDto.Description?.ToLower();
            coderDto.UrlImage = coderDto.UrlImage?.ToLower();

            coder.Name = coderDto.Name;
            coder.Birthday = coderDto.Birthday;
            coder.Description = coderDto.Description;
            coder.UrlImage = coderDto.UrlImage;
            coder.GenderId = coderDto.GenderId;
            coder.ClanId = coderDto.ClanId;

            _context.Entry(coder).State = EntityState.Modified;

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.SaveChangesAsync();
                await UpdateCoderRelationships(id, coderDto);
                await transaction.CommitAsync();
            }
            catch (DbUpdateException)
            {
                await transaction.RollbackAsync();
                // Log the exception details here
                return StatusCode(500, "Error al actualizar el coder. Por favor, verifica que todos los IDs sean válidos.");
            }

            return NoContent();
        }


        private async Task UpdateCoderRelationships(int coderId, CoderUpdateDto coderDto)
        {
            // Eliminar relaciones existentes
            var currentSoftSkills = await _context.CoderSoftSkills.Where(css => css.CoderId == coderId).ToListAsync();
            _context.CoderSoftSkills.RemoveRange(currentSoftSkills);

            var currentLanguages = await _context.CoderLanguages.Where(cl => cl.CoderId == coderId).ToListAsync();
            _context.CoderLanguages.RemoveRange(currentLanguages);

            var currentTechnicalSkills = await _context.CoderTechnicalSkills.Where(cts => cts.CoderId == coderId).ToListAsync();
            _context.CoderTechnicalSkills.RemoveRange(currentTechnicalSkills);

            // Validar y agregar nuevas relaciones
            var validSoftSkillIds = await _context.SoftSkills.Where(ss => coderDto.SoftSkillIds.Contains(ss.Id)).Select(ss => ss.Id).ToListAsync();
            foreach (var skillId in validSoftSkillIds)
            {
                _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
            }

            var validLanguageIds = await _context.Languages.Where(l => coderDto.Languages.Select(dto => dto.Id).Contains(l.Id)).Select(l => l.Id).ToListAsync();
            foreach (var languageDto in coderDto.Languages.Where(l => validLanguageIds.Contains(l.Id)))
            {
                _context.CoderLanguages.Add(new CoderLanguage
                {
                    CoderId = coderId,
                    LanguageId = languageDto.Id,
                    LanguageLevelId = languageDto.LevelId
                });
            }

            var validTechnicalSkillIds = await _context.TechnicalSkills.Where(ts => coderDto.TechnicalSkills.Select(dto => dto.Id).Contains(ts.Id)).Select(ts => ts.Id).ToListAsync();
            foreach (var technicalSkillDto in coderDto.TechnicalSkills.Where(ts => validTechnicalSkillIds.Contains(ts.Id)))
            {
                _context.CoderTechnicalSkills.Add(new CoderTechnicalSkill
                {
                    CoderId = coderId,
                    TechnicalSkillId = technicalSkillDto.Id,
                    TechnicalSkillLevelId = technicalSkillDto.LevelId
                });
            }

            await _context.SaveChangesAsync();
        }

        private bool CoderExists(int id)
        {
            return _context.Coders.Any(c => c.Id == id);
        }

        /// <summary>
        /// Applies partial updates to an existing coder.
        /// </summary>
        /// <remarks>
        /// This endpoint allows partial updates to the details of a coder using a JSON Patch document. The patch document contains the fields to be updated, and the changes are applied to the coder identified by the specified ID. The method handles validation and ensures that the updates are correctly applied before saving them to the database. It also includes error handling for concurrency issues and invalid patch documents.
        /// </remarks>
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCoder(int id, [FromBody] JsonPatchDocument<CoderUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }

            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                return NotFound();
            }

            var coderToPatch = new CoderUpdateDto
            {
                Name = coder.Name,
                Birthday = coder.Birthday,
                Description = coder.Description,
                UrlImage = coder.UrlImage,
                GenderId = coder.GenderId,
                ClanId = coder.ClanId
            };

            patchDoc.ApplyTo(coderToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Convert strings to lowercase before saving
            if (coderToPatch.Name != null)
            {
                coderToPatch.Name = coderToPatch.Name.ToLower();
            }
            if (coderToPatch.Description != null)
            {
                coderToPatch.Description = coderToPatch.Description.ToLower();
            }
            if (coderToPatch.UrlImage != null)
            {
                coderToPatch.UrlImage = coderToPatch.UrlImage.ToLower();
            }

            coder.Name = coderToPatch.Name;
            coder.Birthday = coderToPatch.Birthday;
            coder.Description = coderToPatch.Description;
            coder.UrlImage = coderToPatch.UrlImage;
            coder.GenderId = coderToPatch.GenderId;
            coder.ClanId = coderToPatch.ClanId;

            _context.Entry(coder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoderExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }


        /// <summary>
        /// Deletes a coder by its unique identifier.
        /// </summary>
        /// <remarks>
        /// This endpoint deletes the coder specified by the given ID from the database. If the coder does not exist, it returns a 404 Not Found status. If the deletion is successful, it returns a 204 No Content status. This operation is used to remove a coder entry from the system permanently.
        /// </remarks>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoder(int id)
        {
            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                return NotFound();
            }

            _context.Coders.Remove(coder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}

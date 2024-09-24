using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Models;
using Linkup_ms.Interfaces;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace Linkup_ms.Services
{
    public class CoderService : ICoderService
    {
        private readonly AppDbContext _context;

        public CoderService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new coder in the database.
        /// </summary>
        /// <param name="coderDto">The DTO containing the coder's information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the created coder's response DTO.</returns>
        public async Task<CoderResponseDto> CreateCoderAsync(CoderCreationDto coderDto)
        {
            // Validate the gender and clan
            var gender = await _context.Genders.FindAsync(coderDto.GenderId);
            if (gender == null)
            {
                throw new ArgumentException("The specified gender does not exist.");
            }

            var clan = await _context.Clans.FindAsync(coderDto.ClanId);
            if (clan == null)
            {
                throw new ArgumentException("The specified clan does not exist.");
            }

            // Convert string fields to lowercase for consistency
            coderDto.Name = coderDto.Name?.ToLower();
            coderDto.Description = coderDto.Description?.ToLower();
            coderDto.UrlImage = coderDto.UrlImage?.ToLower();

            // Create a new Coder entity
            var coder = new Coder
            {
                Name = coderDto.Name,
                Birthday = coderDto.Birthday,
                Description = coderDto.Description,
                UrlImage = coderDto.UrlImage,
                GenderId = coderDto.GenderId,
                ClanId = coderDto.ClanId
            };

            // Add the new Coder to the database context
            _context.Coders.Add(coder);
            await _context.SaveChangesAsync();

            // Add relationships
            await AddCoderRelationshipsAsync(coder.Id, coderDto);

            // Create and return the response DTO
            return await CreateCoderResponseDtoAsync(coder.Id);
        }

        /// <summary>
        /// Adds relationships for a newly created coder.
        /// </summary>
        /// <param name="coderId">The ID of the newly created coder.</param>
        /// <param name="coderDto">The DTO containing the relationships to be added.</param>
        public async Task AddCoderRelationshipsAsync(int coderId, CoderCreationDto coderDto)
        {
            // Add SoftSkills relationships
            foreach (var skillId in coderDto.SoftSkillIds)
            {
                _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
            }

            // Add Language relationships
            foreach (var languageDto in coderDto.Languages)
            {
                _context.CoderLanguages.Add(new CoderLanguage
                {
                    CoderId = coderId,
                    LanguageId = languageDto.Id,
                    LanguageLevelId = languageDto.LevelId
                });
            }

            // Add TechnicalSkill relationships
            foreach (var technicalSkillDto in coderDto.TechnicalSkills)
            {
                _context.CoderTechnicalSkills.Add(new CoderTechnicalSkill
                {
                    CoderId = coderId,
                    TechnicalSkillId = technicalSkillDto.Id,
                    TechnicalSkillLevelId = technicalSkillDto.LevelId
                });
            }

            // Save the changes for the added relationships
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Creates a detailed response DTO with all the coder's information including relationships.
        /// </summary>
        /// <param name="coderId">The ID of the coder.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a detailed CoderResponseDto object.</returns>
        public async Task<CoderResponseDto> CreateCoderResponseDtoAsync(int coderId)
        {
            // Retrieve the coder with all related entities loaded
            var coder = await _context.Coders
                .Include(c => c.Gender)
                .Include(c => c.Clan)
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.LanguageLevel)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkillLevel)
                .FirstOrDefaultAsync(c => c.Id == coderId);

            // Map the coder and its relationships to a CoderResponseDto
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
        /// Updates an existing coder in the database.
        /// </summary>
        /// <param name="id">The ID of the coder to be updated.</param>
        /// <param name="coderDto">The DTO containing the updated information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated coder's response DTO.</returns>
        public async Task<CoderResponseDto> UpdateCoderAsync(int id, CoderUpdateDto coderDto)
        {
            // Validate the incoming coderDto
            if (!await ValidateCoderUpdateAsync(coderDto))
            {
                throw new ArgumentException("Invalid input data. Please check the information provided.");
            }

            // Find the existing coder
            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                throw new ArgumentException("Coder not found.");
            }

            // Update the coder entity
            coder.Name = coderDto.Name?.ToLower();
            coder.Birthday = coderDto.Birthday;
            coder.Description = coderDto.Description?.ToLower();
            coder.UrlImage = coderDto.UrlImage?.ToLower();
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
                throw new Exception("Error updating the coder. Please check that all IDs are valid.");
            }

            return await CreateCoderResponseDtoAsync(coder.Id);
        }

        /// <summary>
        /// Applies a JSON Patch document to an existing coder in the database.
        /// </summary>
        /// <param name="id">The ID of the coder to be patched.</param>
        /// <param name="patchDoc">The JSON Patch document containing the updates.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the patched coder's response DTO.</returns>
        public async Task<CoderResponseDto> PatchCoderAsync(int id, JsonPatchDocument<CoderUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                throw new ArgumentException("Invalid patch document.");
            }

            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                throw new ArgumentException("Coder not found.");
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

            patchDoc.ApplyTo(coderToPatch);

            if (!await ValidateCoderUpdateAsync(coderToPatch))
            {
                throw new ArgumentException("Invalid input data after patching.");
            }

            coder.Name = coderToPatch.Name?.ToLower();
            coder.Birthday = coderToPatch.Birthday;
            coder.Description = coderToPatch.Description?.ToLower();
            coder.UrlImage = coderToPatch.UrlImage?.ToLower();
            coder.GenderId = coderToPatch.GenderId;
            coder.ClanId = coderToPatch.ClanId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoderExists(id))
                {
                    throw new ArgumentException("Coder not found.");
                }
                throw;
            }

            return await CreateCoderResponseDtoAsync(coder.Id);
        }

        /// <summary>
        /// Updates relationships for a coder.
        /// </summary>
        /// <param name="coderId">The ID of the coder to update relationships for.</param>
        /// <param name="coderDto">The DTO containing the relationships to be updated.</param>
        private async Task UpdateCoderRelationships(int coderId, CoderUpdateDto coderDto)
        {
            // Update SoftSkills
            var existingSoftSkills = await _context.CoderSoftSkills
                .Where(css => css.CoderId == coderId)
                .ToListAsync();

            // Remove relationships that are no longer in coderDto
            foreach (var existing in existingSoftSkills)
            {
                if (!coderDto.SoftSkillIds.Contains(existing.SoftSkillId))
                {
                    _context.CoderSoftSkills.Remove(existing);
                }
            }

            // Add new SoftSkills
            foreach (var skillId in coderDto.SoftSkillIds)
            {
                if (!existingSoftSkills.Any(css => css.SoftSkillId == skillId))
                {
                    _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
                }
            }

            // Update Language relationships
            var existingLanguages = await _context.CoderLanguages
                .Where(cl => cl.CoderId == coderId)
                .ToListAsync();

            // Remove relationships that are no longer in coderDto
            foreach (var existing in existingLanguages)
            {
                var languageDto = coderDto.Languages.FirstOrDefault(l => l.Id == existing.LanguageId);
                if (languageDto == null)
                {
                    _context.CoderLanguages.Remove(existing);
                }
            }

            // Add new Language relationships
            foreach (var languageDto in coderDto.Languages)
            {
                var existingLanguage = existingLanguages.FirstOrDefault(cl => cl.LanguageId == languageDto.Id);
                if (existingLanguage == null)
                {
                    _context.CoderLanguages.Add(new CoderLanguage
                    {
                        CoderId = coderId,
                        LanguageId = languageDto.Id,
                        LanguageLevelId = languageDto.LevelId
                    });
                }
                else
                {
                    // Update language level if exists
                    existingLanguage.LanguageLevelId = languageDto.LevelId;
                    _context.Entry(existingLanguage).State = EntityState.Modified;
                }
            }

            // Update TechnicalSkill relationships
            var existingTechnicalSkills = await _context.CoderTechnicalSkills
                .Where(cts => cts.CoderId == coderId)
                .ToListAsync();

            // Remove relationships that are no longer in coderDto
            foreach (var existing in existingTechnicalSkills)
            {
                var technicalSkillDto = coderDto.TechnicalSkills.FirstOrDefault(ts => ts.Id == existing.TechnicalSkillId);
                if (technicalSkillDto == null)
                {
                    _context.CoderTechnicalSkills.Remove(existing);
                }
            }

            // Add new TechnicalSkill relationships
            foreach (var technicalSkillDto in coderDto.TechnicalSkills)
            {
                var existingTechnicalSkill = existingTechnicalSkills.FirstOrDefault(cts => cts.TechnicalSkillId == technicalSkillDto.Id);
                if (existingTechnicalSkill == null)
                {
                    _context.CoderTechnicalSkills.Add(new CoderTechnicalSkill
                    {
                        CoderId = coderId,
                        TechnicalSkillId = technicalSkillDto.Id,
                        TechnicalSkillLevelId = technicalSkillDto.LevelId
                    });
                }
                else
                {
                    // Update technical skill level if exists
                    existingTechnicalSkill.TechnicalSkillLevelId = technicalSkillDto.LevelId;
                    _context.Entry(existingTechnicalSkill).State = EntityState.Modified;
                }
            }

            // Save changes for updated relationships
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Validates the coder update DTO.
        /// </summary>
        /// <param name="coderDto">The coder update DTO to validate.</param>
        /// <returns>A task that represents the asynchronous operation. Returns true if valid, otherwise false.</returns>
        private async Task<bool> ValidateCoderUpdateAsync(CoderUpdateDto coderDto)
        {
            // Implement your validation logic here
            // Example: Check if GenderId and ClanId exist
            var genderExists = await _context.Genders.AnyAsync(g => g.Id == coderDto.GenderId);
            var clanExists = await _context.Clans.AnyAsync(c => c.Id == coderDto.ClanId);
            return genderExists && clanExists;
        }


        /// <summary>
        /// Checks if a coder exists by ID.
        /// </summary>
        /// <param name="id">The ID of the coder.</param>
        /// <returns>True if exists, otherwise false.</returns>
        private bool CoderExists(int id)
        {
            return _context.Coders.Any(e => e.Id == id);
        }
    }

}

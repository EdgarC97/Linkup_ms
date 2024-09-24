using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Models;
using Linkup_ms.Interfaces;
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

    }
}
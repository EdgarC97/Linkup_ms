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
    [ApiExplorerSettings(GroupName = "v2")]
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
        
        //GET: api/v2/coders
        [HttpGet]
        public async Task<IActionResult> GetCoders()
        {
            // Query the database to select the required fields for each coder.
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
        
        // GET: api/v2/coders/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoder(int id)
        {
            // Query the database to get the coder with the specified ID.
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

            // If the coder does not exist, return a 404 Not Found response.
            if (coder == null)
            {
                return NotFound();
            }

            // Return the coder details with a 200 OK response.
            return Ok(coder);
        }

        /// <summary>
        /// Retrieves a paginated list of coders.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a paginated list of coders from the database. 
        /// Each coder is represented by their ID, name, birthday, URL image, and description.
        /// </remarks>
        /// <param name="pageNumber">The page number to retrieve (default is 1)</param>
        /// <param name="pageSize">The number of items per page (default is 10)</param>
        /// <returns>A paginated list of coders</returns>
        
        // GET: api/v2/coders/paginated
        [HttpGet("paginated")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCodersPaginated(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                return BadRequest("Page number and page size must be greater than 0.");
            }

            var query = _context.Coders
                .Select(c => new CoderDtoV2
                {
                    Id = c.Id,
                    Name = c.Name,
                    Birthday = c.Birthday,
                    UrlImage = c.UrlImage,
                    Description = c.Description
                });

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var coders = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var paginatedResult = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                PageNumber = pageNumber,
                PageSize = pageSize,
                Data = coders
            };

            return Ok(paginatedResult);
        }

        /// <summary>
        /// Creates a new coder.
        /// </summary>
        /// <remarks>
        /// This endpoint allows for the creation of a new coder in the database. The coder's details are provided in the request body. The endpoint performs validation checks to ensure that the specified gender and clan exist. If the creation is successful, it returns a response with the details of the newly created coder. In case of errors, appropriate error messages are returned.
        /// </remarks>

        // POST: api/v2/coders
        [HttpPost]
        public async Task<IActionResult> CreateCoder([FromBody] CoderCreationDto coderDto)
        {
            // Validate the incoming request model.
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Check if the provided Gender ID exists.
            var gender = await _context.Genders.FindAsync(coderDto.GenderId);
            if (gender == null)
            {
                return BadRequest("El clan especificado no existe.");
            }

            // Check if the provided Clan ID exists.
            var clan = await _context.Clans.FindAsync(coderDto.ClanId);
            if (clan == null)
            {
                return BadRequest("El clan especificado no existe.");
            }

            // Convert string fields to lowercase for consistency.
            coderDto.Name = coderDto.Name?.ToLower();
            coderDto.Description = coderDto.Description?.ToLower();
            coderDto.UrlImage = coderDto.UrlImage?.ToLower();

            // Create a new Coder entity based on the provided DTO.
            var coder = new Coder
            {
                Name = coderDto.Name,
                Birthday = coderDto.Birthday,
                Description = coderDto.Description,
                UrlImage = coderDto.UrlImage,
                GenderId = coderDto.GenderId,
                ClanId = coderDto.ClanId
            };

            // Add the new Coder to the database context.
            _context.Coders.Add(coder);
            try
            {
                // Attempt to save changes to the database.
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Handle database update exceptions and return a 500 Internal Server Error response.
                return StatusCode(500, $"Error al guardar en la base de datos: {ex.Message}");
            }

            // Add relationships such as SoftSkills, Languages, and TechnicalSkills.
            await AddCoderRelationships(coder.Id, coderDto);

            // Create a detailed response DTO with all relationships included.
            var responseDto = await CreateCoderResponseDto(coder.Id);

            // Return a 201 Created response with the newly created coder details.
            return CreatedAtAction(nameof(GetCoder), new { id = coder.Id }, new
            {
                message = "Coder created successfully",
                data = responseDto
            });
        }

        /// <summary>
        /// Adds relationships for the newly created coder.
        /// </summary>
        /// <param name="coderId">The ID of the newly created coder.</param>
        /// <param name="coderDto">The DTO containing the relationships to be added.</param>
        private async Task AddCoderRelationships(int coderId, CoderCreationDto coderDto)
        {
            // Add SoftSkills relationships.
            foreach (var skillId in coderDto.SoftSkillIds)
            {
                _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
            }

            // Add Language relationships.
            foreach (var languageDto in coderDto.Languages)
            {
                _context.CoderLanguages.Add(new CoderLanguage
                {
                    CoderId = coderId,
                    LanguageId = languageDto.Id,
                    LanguageLevelId = languageDto.LevelId
                });
            }

            // Add TechnicalSkill relationships.
            foreach (var technicalSkillDto in coderDto.TechnicalSkills)
            {
                _context.CoderTechnicalSkills.Add(new CoderTechnicalSkill
                {
                    CoderId = coderId,
                    TechnicalSkillId = technicalSkillDto.Id,
                    TechnicalSkillLevelId = technicalSkillDto.LevelId
                });
            }

            // Save the changes for the added relationships.
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Creates a detailed response DTO with all the coder's information including relationships.
        /// </summary>
        /// <param name="coderId">The ID of the coder.</param>
        /// <returns>A detailed CoderResponseDto object.</returns>
        private async Task<CoderResponseDto> CreateCoderResponseDto(int coderId)
        {
            // Retrieve the coder with all related entities loaded.
            var coder = await _context.Coders
                .Include(c => c.Gender)
                .Include(c => c.Clan)
                .Include(c => c.CoderSoftSkills).ThenInclude(css => css.SoftSkill)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.Language)
                .Include(c => c.CoderLanguages).ThenInclude(cl => cl.LanguageLevel)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkill)
                .Include(c => c.CoderTechnicalSkills).ThenInclude(cts => cts.TechnicalSkillLevel)
                .FirstOrDefaultAsync(c => c.Id == coderId);

            // Map the coder and its relationships to a CoderResponseDto.
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

        //PUT: api/v2/coders/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCoder(int id, [FromBody] CoderUpdateDto coderDto)
        {
            // Validate the incoming request model.
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Find the coder by the provided ID.
            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                return NotFound();
            }

            // Convert strings to lowercase before updating.
            coderDto.Name = coderDto.Name?.ToLower();
            coderDto.Description = coderDto.Description?.ToLower();
            coderDto.UrlImage = coderDto.UrlImage?.ToLower();

            coder.Name = coderDto.Name;
            coder.Birthday = coderDto.Birthday;
            coder.Description = coderDto.Description;
            coder.UrlImage = coderDto.UrlImage;
            coder.GenderId = coderDto.GenderId;
            coder.ClanId = coderDto.ClanId;

            // Update the coder entity in the database context.
            _context.Entry(coder).State = EntityState.Modified;

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Save changes to the database.
                await _context.SaveChangesAsync();
                // Update relationships such as SoftSkills, Languages, and TechnicalSkills.
                await UpdateCoderRelationships(id, coderDto);
                await transaction.CommitAsync();
            }
            catch (DbUpdateException)
            {
                await transaction.RollbackAsync();
                // Log the exception details here
                return StatusCode(500, "Error al actualizar el coder. Por favor, verifica que todos los IDs sean válidos.");
            }

            // Return a 204 No Content response to indicate a successful update.
            return NoContent();
        }

        /// <summary>
        /// Updates the relationships (SoftSkills, Languages, TechnicalSkills) of an existing coder.
        /// </summary>
        /// <param name="coderId">The ID of the coder to update relationships for.</param>
        /// <param name="coderDto">The DTO containing the new relationships.</param>
        private async Task UpdateCoderRelationships(int coderId, CoderUpdateDto coderDto)
        {
            // Remove existing relationships

            // Remove existing SoftSkills relationships.
            var currentSoftSkills = await _context.CoderSoftSkills.Where(css => css.CoderId == coderId).ToListAsync();
            _context.CoderSoftSkills.RemoveRange(currentSoftSkills);

            // Remove existing Languages relationships.
            var currentLanguages = await _context.CoderLanguages.Where(cl => cl.CoderId == coderId).ToListAsync();
            _context.CoderLanguages.RemoveRange(currentLanguages);

            // Remove existing TechnicalSkills relationships.
            var currentTechnicalSkills = await _context.CoderTechnicalSkills.Where(cts => cts.CoderId == coderId).ToListAsync();
            _context.CoderTechnicalSkills.RemoveRange(currentTechnicalSkills);

            // Validate and add new relationships 

            // Add new SoftSkills relationships.
            var validSoftSkillIds = await _context.SoftSkills.Where(ss => coderDto.SoftSkillIds.Contains(ss.Id)).Select(ss => ss.Id).ToListAsync();
            foreach (var skillId in validSoftSkillIds)
            {
                _context.CoderSoftSkills.Add(new CoderSoftSkill { CoderId = coderId, SoftSkillId = skillId });
            }

            // Add new Language relationships.
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

            // Add new TechnicalSkill relationships.
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

            // Save changes to update relationships in the database.
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Checks if a coder exists by their ID.
        /// </summary>
        /// <param name="id">The ID of the coder to check.</param>
        /// <returns>True if the coder exists, otherwise false.</returns>
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

        //PATCH: api/v2/coders/{id}
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchCoder(int id, [FromBody] JsonPatchDocument<CoderUpdateDto> patchDoc)
        {
            // Check if the patch document is null.
            if (patchDoc == null)
            {
                return BadRequest();
            }

            // Find the coder by the provided ID.
            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                return NotFound();
            }

            // Create a DTO object to apply the patch document to.
            var coderToPatch = new CoderUpdateDto
            {
                Name = coder.Name,
                Birthday = coder.Birthday,
                Description = coder.Description,
                UrlImage = coder.UrlImage,
                GenderId = coder.GenderId,
                ClanId = coder.ClanId
            };

            // Apply the patch document to the DTO.
            patchDoc.ApplyTo(coderToPatch, ModelState);

            // Validate the patched model state.
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

            // Update the coder entity with the patched values.
            coder.Name = coderToPatch.Name;
            coder.Birthday = coderToPatch.Birthday;
            coder.Description = coderToPatch.Description;
            coder.UrlImage = coderToPatch.UrlImage;
            coder.GenderId = coderToPatch.GenderId;
            coder.ClanId = coderToPatch.ClanId;

            // Mark the coder entity as modified.
            _context.Entry(coder).State = EntityState.Modified;

            try
            {
                // Save changes to the database.
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency issues.
                if (!CoderExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            // Return a 204 No Content response to indicate a successful update.
            return NoContent();
        }


        /// <summary>
        /// Deletes a coder by its unique identifier.
        /// </summary>
        /// <remarks>
        /// This endpoint deletes the coder specified by the given ID from the database. If the coder does not exist, it returns a 404 Not Found status. If the deletion is successful, it returns a 204 No Content status. This operation is used to remove a coder entry from the system permanently.
        /// </remarks>

        //DELETE: api/v2/coders/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoder(int id)
        {
            // Find the coder by the provided ID.
            var coder = await _context.Coders.FindAsync(id);
            if (coder == null)
            {
                // If the coder does not exist, return a 404 Not Found response
                return NotFound();
            }

            // Remove the coder entity from the database context.
            _context.Coders.Remove(coder);
            await _context.SaveChangesAsync();

            // Return a 204 No Content response to indicate successful deletion.
            return NoContent();
        }

    }
}

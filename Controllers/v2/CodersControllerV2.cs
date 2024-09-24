using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Backend_Riwi_LinkUp.DTOS;
using Backend_Riwi_LinkUp.Models;
using Linkup_ms.Interfaces;
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
        private readonly ICoderService _coderService;

        public CodersControllerV2(AppDbContext context, ICoderService coderService)
        {
            _context = context;
            _coderService = coderService;
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
                return BadRequest("Invalid input data. Please check the information provided.");
            }

            try
            {
                // Use the service to create the coder
                var responseDto = await _coderService.CreateCoderAsync(coderDto);

                // Return a 201 Created response with the newly created coder details.
                return CreatedAtAction(nameof(GetCoder), new { id = responseDto.Id }, new
                {
                    message = "Coder created successfully",
                    data = responseDto
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException)
            {
                // Log the exception details here
                return StatusCode(500, "Error saving to the database. Please check that all IDs are valid.");
            }
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
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid input data. Please check the information provided.");
            }

            try
            {
                var updatedCoder = await _coderService.UpdateCoderAsync(id, coderDto);
                // Return a 204 No Content response to indicate a successful update.
                return Ok("Coder updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Error updating the coder. Please check that all IDs are valid.");
            }
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
            if (patchDoc == null)
            {
                return BadRequest("Invalid patch document.");
            }

            try
            {
                var patchedCoder = await _coderService.PatchCoderAsync(id, patchDoc);
                // Return a 204 No Content response to indicate a successful partial update.
                return Ok("Coder updated partially successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Error applying patch to coder. Please check that all IDs are valid.");
            }
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
                return NotFound("Coder not found.");
            }

            // Remove the coder entity from the database context.
            _context.Coders.Remove(coder);
            await _context.SaveChangesAsync();

            // Return a 204 No Content response to indicate successful deletion.
            return Ok("Coder deleted successfully.");
        }

    }
}

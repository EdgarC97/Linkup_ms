using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.DTOS;
using Microsoft.AspNetCore.JsonPatch;

namespace Linkup_ms.Interfaces
{
    public interface ICoderService
    {
        /// <summary>
        /// Creates a new coder in the database.
        /// </summary>
        /// <param name="coderDto">The DTO containing the coder's information.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the created coder's response DTO.</returns>
        Task<CoderResponseDto> CreateCoderAsync(CoderCreationDto coderDto);

        /// <summary>
        /// Adds relationships for a newly created coder.
        /// </summary>
        /// <param name="coderId">The ID of the newly created coder.</param>
        /// <param name="coderDto">The DTO containing the relationships to be added.</param>
        Task AddCoderRelationshipsAsync(int coderId, CoderCreationDto coderDto);

        /// <summary>
        /// Creates a detailed response DTO with all the coder's information including relationships.
        /// </summary>
        /// <param name="coderId">The ID of the coder.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a detailed CoderResponseDto object.</returns>
        Task<CoderResponseDto> CreateCoderResponseDtoAsync(int coderId);

        /// <summary>
        /// Updates an existing coder's information.
        /// </summary>
        /// <param name="id">The ID of the coder to be updated.</param>
        /// <param name="coderDto">The DTO containing the updated information of the coder.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated coder's response DTO.</returns>
        Task<CoderResponseDto> UpdateCoderAsync(int id, CoderUpdateDto coderDto);

         /// <summary>
        /// Applies a JSON Patch to an existing coder's information.
        /// </summary>
        /// <param name="id">The ID of the coder to be patched.</param>
        /// <param name="patchDoc">The JSON Patch document containing the changes to be applied.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the patched coder's response DTO.</returns>
        Task<CoderResponseDto> PatchCoderAsync(int id, JsonPatchDocument<CoderUpdateDto> patchDoc);
    }
}
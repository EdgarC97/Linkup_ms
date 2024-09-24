using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.DTOS;

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
    }
}
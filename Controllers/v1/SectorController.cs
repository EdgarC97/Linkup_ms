using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linkup_ms.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class SectorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SectorController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves a list of all sectors.
        /// </summary>
        /// <remarks>
        /// This endpoint fetches a list of all sectors from the database. If the retrieval is successful, it returns the list of sectors. In case of an error, it returns a 500 Internal Server Error with an error message.
        /// </remarks>
        [HttpGet]
        public async Task<IActionResult> AllSectors()
        {
            try
            {
                var sectors = await _context.Sectors.ToListAsync();
                return Ok(sectors);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving sectors.", error = ex.Message });
            }
        }

    }
}
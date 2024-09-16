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
    public class SectorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SectorController(AppDbContext context)
        {
            _context = context;
        }

        //Get: api/Sector
        [HttpGet]
        public async Task<IActionResult> AllSectors()
        {
            try
            {
                var sectors = await _context.Sector.ToListAsync();
                return Ok(sectors);
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving sectores.", error = ex.Message});
            }
        }
    }
}
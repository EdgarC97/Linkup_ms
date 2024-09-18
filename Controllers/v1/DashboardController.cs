using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class DashboardController : ControllerBase
    {
        // Dependency injection of the database context
        private readonly AppDbContext _context;

        // Constructor to initialize the context
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the count of all coders in training.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the total number of coders in the system. It counts all records in the Coders table and returns the count as an integer. This can be useful for quickly getting a total count of coders without any additional filtering or conditions.
        /// </remarks>
        [HttpGet("coders-in-training")]
        public async Task<int> GetCodersInTrainingCount()
        {
            return await _context.Coders.CountAsync();
        }


        /// <summary>
        /// Gets the count of frontend coders with specific skills.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the total number of frontend coders who possess any of the specified technical skills, namely "JavaScript" or "Next.js". The method queries the Coders table and filters the records to include only those coders who have at least one of the specified skills. The count of these coders is then returned.
        /// </remarks>
        [HttpGet("frontend-coders")]
        public async Task<int> GetFrontendCodersCount()
        {
            return await _context.Coders
                .Where(c => c.CoderTechnicalSkills
                    .Any(cts => new[] { "javaScript", "nextJs" }
                        .Contains(cts.TechnicalSkill.Name)))
                .CountAsync();
        }


        /// <summary>
        /// Gets the count of backend coders with specific skills.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the total number of backend coders who possess any of the specified technical skills, namely "C#", "Java", "Node.js", or "Python". The method queries the Coders table and filters the records to include only those coders who have at least one of the specified skills. The count of these coders is then returned.
        /// </remarks>
        [HttpGet("backend-coders")]
        public async Task<int> GetBackendCodersCount()
        {
            return await _context.Coders
                .Where(c => c.CoderTechnicalSkills
                    .Any(cts => new[] { "c#", "java", "nodeJs", "python" }
                        .Contains(cts.TechnicalSkill.Name)))
                .CountAsync();
        }


        /// <summary>
        /// Gets the count of companies grouped by month and year.
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the total number of companies, grouped by the month and year they were created. The method queries the `Users` table, filtering for users with the role "cliente" and groups them by the year and month of their creation date. It then counts the number of companies in each group, orders the results by year and month, and returns the data.
        /// </remarks>
        [HttpGet("companies-by-month")]
        public async Task<IActionResult> GetCompaniesByMonth()
        {
            var companiesByMonth = await _context.Users
                .Where(u => u.Role.Name == "cliente")
                .GroupBy(u => new { u.CreatedAt.Year, u.CreatedAt.Month })
                .Select(g => new
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Count = g.Count()
                })
                .OrderBy(c => c.Year)
                .ThenBy(c => c.Month)
                .ToListAsync();

            return Ok(companiesByMonth);
        }

    }
}
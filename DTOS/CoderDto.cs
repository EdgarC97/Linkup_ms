using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    // Data Transfer Object for representing a coder
    public class CoderDto
    {
        // Unique identifier for the coder
        public int Id { get; set; }

        // Name of the coder
        public string Name { get; set; }

        // Name of the gender associated with the coder
        public string GenderName { get; set; }

        // Name of the clan associated with the coder
        public string ClanName { get; set; }

        // List of soft skills the coder has
        public List<string> SoftSkills { get; set; }

        // List of language levels associated with the coder
        public List<LanguageLevelDto> LanguageLevels { get; set; }

        // List of technical skills and their levels for the coder
        public List<TechnicalSkillDto> TechnicalSkillLevels { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class CoderResponseDto
    {
        // Unique identifier for the coder
        public int Id { get; set; }

        // Name of the coder
        public string Name { get; set; }

        // Birthdate of the coder
        public DateTime Birthday { get; set; }

        // Description of the coder
        public string Description { get; set; }

        // URL of the coder's image
        public string UrlImage { get; set; }

        // ID of the coder's clan
        public int ClanId { get; set; }

        // Name of the coder's clan
        public string ClanName { get; set; }

        // ID of the coder's gender
        public int GenderId { get; set; }

        // Name of the coder's gender
        public string GenderName { get; set; }

        // List of soft skills possessed by the coder
        public List<string> SoftSkills { get; set; }

        // List of languages and their levels the coder is proficient in
        public List<LanguageLevelDto> LanguageLevels { get; set; }

        // List of technical skills and their levels the coder has
        public List<TechnicalSkillDto> TechnicalSkillLevels { get; set; }
    }
}
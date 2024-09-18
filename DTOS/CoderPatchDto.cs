using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class CoderPatchDto
    {
        // Name of the coder
        public string Name { get; set; }

        // Optional: Birthdate of the coder
        public DateTime? Birthday { get; set; }

        // Description of the coder
        public string Description { get; set; }

        // URL of the coder's image
        public string UrlImage { get; set; }

        // Optional: Name of the coder's clan
        public string ClanName { get; set; }

        // Optional: Gender ID of the coder
        public int? GenderId { get; set; }

        // List of soft skill IDs associated with the coder
        public List<int> SoftSkillIds { get; set; }

        // List of languages and their levels associated with the coder
        public List<LanguageWithLevelDto> Languages { get; set; }

        // List of technical skills and their levels associated with the coder
        public List<TechnicalSkillWithLevelDto> TechnicalSkills { get; set; }
    }
}
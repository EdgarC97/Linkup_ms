using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class CoderUpdateDto
    {
        // Updated name of the coder
        public string Name { get; set; }

        // Updated birthdate of the coder
        public DateTime Birthday { get; set; }

        // Updated description of the coder
        public string Description { get; set; }

        // Updated URL of the coder's image
        public string UrlImage { get; set; }

        // Updated ID of the coder's gender
        public int GenderId { get; set; }

        // Updated ID of the coder's clan
        public int ClanId { get; set; }

        // Updated list of soft skill IDs for the coder
        public List<int> SoftSkillIds { get; set; }

        // Updated list of languages with their levels for the coder
        public List<LanguageDto> Languages { get; set; }

        // Updated list of technical skills with their levels for the coder
        public List<TechnicalSkillDto> TechnicalSkills { get; set; }
    }
}
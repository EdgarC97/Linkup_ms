using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    // Data Transfer Object for creating a new coder
    public class CoderCreationDto
    {
        // Name of the coder, required and max length 100 characters
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Birthday of the coder, required field
        [Required]
        public DateTime Birthday { get; set; }

        // Description of the coder, optional and max length 500 characters
        [StringLength(500)]
        public string Description { get; set; }

        // URL of the coder's image, optional and max length 255 characters
        [StringLength(255)]
        public string UrlImage { get; set; }

        // Gender ID of the coder, required field
        [Required]
        public int GenderId { get; set; }

        // Clan ID of the coder, required field
        [Required]
        public int ClanId { get; set; }

        // List of soft skill IDs associated with the coder, required field
        [Required]
        public List<int> SoftSkillIds { get; set; }

        // List of languages the coder knows, required field
        [Required]
        public List<LanguageDto> Languages { get; set; }

        // List of technical skills the coder possesses, required field
        [Required]
        public List<TechnicalSkillDto> TechnicalSkills { get; set; }
    }
}
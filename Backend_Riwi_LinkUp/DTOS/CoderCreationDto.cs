using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class CoderCreationDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(255)]
        public string UrlImage { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public int ClanId { get; set; }

        [Required]
        public List<int> SoftSkillIds { get; set; }

        [Required]
        public List<LanguageDto> Languages { get; set; }

        [Required]
        public List<TechnicalSkillDto> TechnicalSkills { get; set; }
    }
}


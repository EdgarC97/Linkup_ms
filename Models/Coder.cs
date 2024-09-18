using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a coder
    public class Coder
    {
        // Unique identifier for the coder
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the coder (required and limited to 100 characters)
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Birthday of the coder (required)
        [Required]
        public DateTime Birthday { get; set; }

        // Description of the coder (optional, limited to 500 characters)
        [StringLength(500)]
        public string Description { get; set; }

        // URL of the coder's image (optional, limited to 255 characters)
        [StringLength(255)]
        public string UrlImage { get; set; }

        // ID of the gender (required)
        [Required]
        public int GenderId { get; set; }

        // Navigation property for the gender
        public Gender Gender { get; set; }

        // ID of the clan (required)
        [Required]
        public int ClanId { get; set; }

        // Navigation property for the clan
        public Clan Clan { get; set; }

        // Collection of soft skills associated with the coder
        public ICollection<CoderSoftSkill> CoderSoftSkills { get; set; }

        // Collection of technical skills associated with the coder
        public ICollection<CoderTechnicalSkill> CoderTechnicalSkills { get; set; }

        // Collection of languages associated with the coder
        public ICollection<CoderLanguage> CoderLanguages { get; set; }
    }
}

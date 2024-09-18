using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a level for technical skills (e.g., Beginner, Intermediate, Expert)
    public class TechnicalSkillLevel
    {
        // Unique identifier for the TechnicalSkillLevel
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the technical skill level (e.g., Junior, Senior)
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Collection of coder-technical skill level associations
        public ICollection<CoderTechnicalSkill> CoderTechnicalSkills { get; set; }
    }
}
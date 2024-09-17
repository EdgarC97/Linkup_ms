using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents the relationship between a coder and a technical skill, including the skill level
    public class CoderTechnicalSkill
    {
        // Unique identifier for the CoderTechnicalSkill entry
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // ID of the associated coder
        public int CoderId { get; set; }

        // Navigation property for the associated coder
        public Coder Coder { get; set; }

        // ID of the associated technical skill
        public int TechnicalSkillId { get; set; }

        // Navigation property for the associated technical skill
        public TechnicalSkill TechnicalSkill { get; set; }

        // ID of the associated technical skill level
        public int TechnicalSkillLevelId { get; set; }

        // Navigation property for the associated technical skill level
        public TechnicalSkillLevel TechnicalSkillLevel { get; set; }
    }
}
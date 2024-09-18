using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a technical skill that coders can have
    public class TechnicalSkill
    {
        // Unique identifier for the TechnicalSkill
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the technical skill (e.g., C#, JavaScript)
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Collection of coder-technical skill associations
        public ICollection<CoderTechnicalSkill> CoderTechnicalSkills { get; set; }
    }
}
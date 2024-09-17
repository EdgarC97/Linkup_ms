using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a soft skill that coders can possess
    public class SoftSkill
    {
        // Unique identifier for the SoftSkill
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the soft skill (e.g., Communication, Leadership)
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Collection of coder-soft skill associations
        public ICollection<CoderSoftSkill> CoderSoftSkills { get; set; }
    }
}
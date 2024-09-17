using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents the relationship between a coder and a soft skill
    public class CoderSoftSkill
    {
        // Unique identifier for the CoderSoftSkill entry
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // ID of the associated coder
        public int CoderId { get; set; }

        // Navigation property for the associated coder
        public Coder Coder { get; set; }

        // ID of the associated soft skill
        public int SoftSkillId { get; set; }

        // Navigation property for the associated soft skill
        public SoftSkill SoftSkill { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents the proficiency level of a language for coders
    public class LanguageLevel
    {
        // Unique identifier for the LanguageLevel
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the proficiency level (e.g., Beginner, Intermediate)
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Collection of coder-language associations with this proficiency level
        public ICollection<CoderLanguage> CoderLanguages { get; set; }
    }
}
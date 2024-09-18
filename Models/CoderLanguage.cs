using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents the relationship between a coder and a language
    public class CoderLanguage
    {
        // Unique identifier for the CoderLanguage entry
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // ID of the associated coder
        public int CoderId { get; set; }

        // Navigation property for the associated coder
        public Coder Coder { get; set; }

        // ID of the associated language
        public int LanguageId { get; set; }

        // Navigation property for the associated language
        public Language Language { get; set; }

        // ID of the language proficiency level
        public int LanguageLevelId { get; set; }

        // Navigation property for the language proficiency level
        public LanguageLevel LanguageLevel { get; set; }
    }
}
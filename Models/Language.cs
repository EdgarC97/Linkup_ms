using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a language that can be associated with multiple coders
    public class Language
    {
        // Unique identifier for the Language
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the language (e.g., English, Spanish)
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Collection of coder-language associations
        public ICollection<CoderLanguage> CoderLanguages { get; set; }
    }
}
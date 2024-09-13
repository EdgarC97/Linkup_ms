using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    public class CoderLanguage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CoderId { get; set; }
        public Coder Coder { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int LanguageLevelId { get; set; }
        public LanguageLevel LanguageLevel { get; set; }

    }
}
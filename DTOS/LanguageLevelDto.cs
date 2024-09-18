using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class LanguageLevelDto
    {
        // Unique identifier for the language level
        public int Id { get; set; }

        // Identifier for the proficiency level of the language
        public int LevelId { get; set; }

        // Name of the language
        public string LanguageName { get; set; }

        // Name of the proficiency level
        public string LevelName { get; set; }

    }
}
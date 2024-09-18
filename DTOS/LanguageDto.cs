using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class LanguageDto
    {
        // Unique identifier for the language
        public int Id { get; set; }

        // Name of the language
        public string Name { get; set; }

        // Identifier for the proficiency level of the language
        public int LevelId { get; set; }
    }
}
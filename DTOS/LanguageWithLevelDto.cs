using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class LanguageWithLevelDto
    {
        // Identifier for the language
        public int LanguageId { get; set; }

        // Identifier for the proficiency level of the language
        public int LevelId { get; set; }
    }
}
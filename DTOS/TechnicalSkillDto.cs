using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class TechnicalSkillDto
    {
        // Unique identifier for the technical skill
        public int Id { get; set; }

        // Name of the technical skill
        public string TechnicalSkillName { get; set; }

        // Identifier for the level of the technical skill
        public int LevelId { get; set; }

        // Name of the level of the technical skill
        public string LevelName { get; set; }

    }
}
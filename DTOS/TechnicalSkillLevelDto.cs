using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class TechnicalSkillLevelDto
    {
        // Unique identifier for the technical skill level
        public int Id { get; set; }

        // Name of the technical skill level
        public string Name { get; set; }

        // Name of the technical skill associated with this level
        public string TechnicalSkillName { get; set; }
    }
}
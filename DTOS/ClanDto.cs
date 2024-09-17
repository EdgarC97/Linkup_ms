using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    // Data Transfer Object for a clan
    public class ClanDto
    {
        // Unique identifier for the clan
        public int Id { get; set; }

        // Name of the clan
        public string Name { get; set; }
    }
}
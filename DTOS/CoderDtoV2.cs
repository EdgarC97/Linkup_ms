using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    // Data Transfer Object for representing a coder in version 2
    public class CoderDtoV2
    {
        // Unique identifier for the coder
        public int Id { get; set; }

        // Name of the coder
        public string Name { get; set; }

        // Birthday of the coder
        public DateTime Birthday { get; set; }

        // URL of the coder's image
        public string UrlImage { get; set; }

        // Description of the coder
        public string Description { get; set; }
    }
}
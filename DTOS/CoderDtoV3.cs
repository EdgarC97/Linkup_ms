using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linkup_ms.DTOS
{
    public class CoderDtoV3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenderName { get; set; }
        public string ClanName { get; set; }
        public DateTime Birthday { get; set; }
        public string UrlImage { get; set; }
        public string Description { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a coding clan
    public class Clan
    {
        // Unique identifier for the clan
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the clan (required and limited to 50 characters)
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Collection of coders belonging to this clan
        public ICollection<Coder> Coders { get; set; }
    }
}
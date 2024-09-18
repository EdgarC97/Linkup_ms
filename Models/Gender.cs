using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    // Represents a gender, associated with multiple coders
    public class Gender
    {
        // Unique identifier for the Gender
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Name of the gender (e.g., Male, Female)
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Collection of coders associated with this gender
        public ICollection<Coder> Coders { get; set; }
    }
}
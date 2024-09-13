using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        [Required]
        [MinLength(6)]
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
        [Required]
        public int RoleId { get; set; }
        public UserRole Role { get; set; }
    }
}
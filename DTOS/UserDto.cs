using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.DTOS
{
    public class UserDto
    {
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
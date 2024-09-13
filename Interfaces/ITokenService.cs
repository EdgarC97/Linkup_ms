using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;

namespace Backend_Riwi_LinkUp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
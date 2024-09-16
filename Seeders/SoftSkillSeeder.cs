using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class SoftSkillSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoftSkill>().HasData(
                new SoftSkill { Id = 1, Name = "comunicación" },
                new SoftSkill { Id = 2, Name = "resolución de problemas" },
                new SoftSkill { Id = 3, Name = "liderazgo" }
            );
        }
    }
}
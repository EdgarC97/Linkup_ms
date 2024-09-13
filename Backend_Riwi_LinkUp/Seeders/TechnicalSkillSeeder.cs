using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class TechnicalSkillSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TechnicalSkill>().HasData(
                new TechnicalSkill { Id = 1, Name = "javaScript" },
                new TechnicalSkill { Id = 2, Name = "python" },
                new TechnicalSkill { Id = 3, Name = "java" },
                new TechnicalSkill { Id = 4, Name = "c#" },
                new TechnicalSkill { Id = 5, Name = "nextJs" },
                new TechnicalSkill { Id = 6, Name = "nodeJs" }
            );
        }
    }
}
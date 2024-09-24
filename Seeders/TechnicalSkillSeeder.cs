using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{   
    // TechnicalSkillSeeder class
    public class TechnicalSkillSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {   
            // Initialize the seed
            modelBuilder.Entity<TechnicalSkill>().HasData(
                new TechnicalSkill { Id = 1, Name = "java" },
                new TechnicalSkill { Id = 2, Name = "c#" },
                new TechnicalSkill { Id = 3, Name = "nextJs" },
                new TechnicalSkill { Id = 4, Name = "nodeJs" }
            );
        }
    }
}
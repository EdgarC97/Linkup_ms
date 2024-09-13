using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class TechnicalSkillLevelSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TechnicalSkillLevel>().HasData(
                new TechnicalSkillLevel { Id = 1, Name = "junior" },
                new TechnicalSkillLevel { Id = 2, Name = "semi-senior" },
                new TechnicalSkillLevel { Id = 3, Name = "senior" }
            );
        }
    }
}
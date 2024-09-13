using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class LanguageLevelSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LanguageLevel>().HasData(
                new LanguageLevel { Id = 1, Name = "a1" },
                new LanguageLevel { Id = 2, Name = "a2" },
                new LanguageLevel { Id = 3, Name = "b1" },
                new LanguageLevel { Id = 4, Name = "b2" },
                new LanguageLevel { Id = 5, Name = "c1" },
                new LanguageLevel { Id = 6, Name = "c2" }
            );
        }
    }
}
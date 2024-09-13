using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class LanguageSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(
            new Language { Id = 1, Name = "inglés" },
            new Language { Id = 2, Name = "portugues" },
            new Language { Id = 3, Name = "francés" },
            new Language { Id = 4, Name = "aleman" },
            new Language { Id = 5, Name = "chino" }


        );
    }
    }
}
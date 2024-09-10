using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class LanguageSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(
            new Language { Id = 1, Name = "inglés" },
            new Language { Id = 2, Name = "español" },
            new Language { Id = 3, Name = "francés" }
        );
    }
    }
}
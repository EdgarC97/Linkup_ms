using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class CoderLanguageSeeder

    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoderLanguage>().HasData(
                new CoderLanguage { Id = 1, CoderId = 1, LanguageId = 1, LanguageLevelId = 4},
                new CoderLanguage { Id = 2, CoderId = 1, LanguageId = 3, LanguageLevelId = 1},
                new CoderLanguage { Id = 3, CoderId = 2, LanguageId = 1, LanguageLevelId = 3},
                new CoderLanguage { Id = 4, CoderId = 3, LanguageId = 2, LanguageLevelId = 2},
                new CoderLanguage { Id = 5, CoderId = 4, LanguageId = 5, LanguageLevelId = 4},
                new CoderLanguage { Id = 6, CoderId = 5, LanguageId = 3, LanguageLevelId = 5},
                new CoderLanguage { Id = 7, CoderId = 6, LanguageId = 2, LanguageLevelId = 2},
                new CoderLanguage { Id = 8, CoderId = 7, LanguageId = 1, LanguageLevelId = 3},
                new CoderLanguage { Id = 9, CoderId = 8, LanguageId = 5, LanguageLevelId = 4},
                new CoderLanguage { Id = 10, CoderId = 9, LanguageId = 1, LanguageLevelId = 6},
                new CoderLanguage { Id = 11, CoderId = 10, LanguageId = 2, LanguageLevelId = 3}
            );
        }
    }
}
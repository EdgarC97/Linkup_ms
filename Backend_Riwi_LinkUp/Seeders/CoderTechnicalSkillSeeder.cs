using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class CoderTechnicalSkillSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoderTechnicalSkill>().HasData(
                new CoderTechnicalSkill { Id = 1, CoderId = 1, TechnicalSkillId = 1, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 2, CoderId = 1, TechnicalSkillId = 4, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 3, CoderId = 2, TechnicalSkillId = 2, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 4, CoderId = 3, TechnicalSkillId = 1, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 5, CoderId = 4, TechnicalSkillId = 6, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 6, CoderId = 5, TechnicalSkillId = 4, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 7, CoderId = 6, TechnicalSkillId = 7, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 8, CoderId = 7, TechnicalSkillId = 1, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 9, CoderId = 8, TechnicalSkillId = 5, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 10, CoderId = 9, TechnicalSkillId = 1, TechnicalSkillLevelId = 1},
                new CoderTechnicalSkill { Id = 11, CoderId = 10, TechnicalSkillId = 3, TechnicalSkillLevelId = 1}
            );
        }
    }
}
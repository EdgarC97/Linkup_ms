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
                new CoderTechnicalSkill { Id = 1, CoderId = 1, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 2, CoderId = 1, TechnicalSkillId = 3, TechnicalSkillLevelId = 1 },
                new CoderTechnicalSkill { Id = 3, CoderId = 2, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 4, CoderId = 3, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 5, CoderId = 4, TechnicalSkillId = 4, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 6, CoderId = 5, TechnicalSkillId = 3, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 7, CoderId = 6, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 8, CoderId = 7, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 9, CoderId = 8, TechnicalSkillId = 4, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 10, CoderId = 9, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 11, CoderId = 10, TechnicalSkillId = 3, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 12, CoderId = 11, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 13, CoderId = 12, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 14, CoderId = 13, TechnicalSkillId = 4, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 15, CoderId = 14, TechnicalSkillId = 3, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 16, CoderId = 15, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 17, CoderId = 16, TechnicalSkillId = 4, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 18, CoderId = 17, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 19, CoderId = 18, TechnicalSkillId = 3, TechnicalSkillLevelId = 1 }, 
                new CoderTechnicalSkill { Id = 20, CoderId = 19, TechnicalSkillId = 2, TechnicalSkillLevelId = 1 },
                new CoderTechnicalSkill { Id = 21, CoderId = 20, TechnicalSkillId = 1, TechnicalSkillLevelId = 1 }
            );
        }
    }
}
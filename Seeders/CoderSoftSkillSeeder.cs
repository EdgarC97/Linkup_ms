using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    // CoderSoftSkillSeeder class
    public class CoderSoftSkillSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {   
            // Initialize the seed
            modelBuilder.Entity<CoderSoftSkill>().HasData(
            new CoderSoftSkill { Id = 1, CoderId = 1, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 2, CoderId = 1, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 3, CoderId = 2, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 4, CoderId = 3, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 5, CoderId = 4, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 6, CoderId = 5, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 7, CoderId = 6, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 8, CoderId = 7, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 9, CoderId = 8, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 10, CoderId = 9, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 11, CoderId = 10, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 12, CoderId = 11, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 13, CoderId = 12, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 14, CoderId = 13, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 15, CoderId = 14, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 16, CoderId = 15, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 17, CoderId = 16, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 18, CoderId = 17, SoftSkillId = 2 },
            new CoderSoftSkill { Id = 19, CoderId = 18, SoftSkillId = 3 },
            new CoderSoftSkill { Id = 20, CoderId = 19, SoftSkillId = 1 },
            new CoderSoftSkill { Id = 21, CoderId = 20, SoftSkillId = 2 }
                );
        }
    }
}
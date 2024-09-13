using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class ClanSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clan>().HasData(
                new Clan { Id = 1, Name = "berners lee" },
                new Clan { Id = 2, Name = "ritchie" },
                new Clan { Id = 3, Name = "gates" },
                new Clan { Id = 4, Name = "jeff bezzos" }
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{   
    // SectorSeeder
    public class SectorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {   
            // Initialize the seed
            modelBuilder.Entity<Sector>().HasData(
                new Sector { Id = 1, Name = "tecnología" },
                new Sector { Id = 2, Name = "finanzas" },
                new Sector { Id = 3, Name = "salud" },
                new Sector { Id = 4, Name = "educación" },
                new Sector { Id = 5, Name = "manufactura" }
            );
        }
    }
}
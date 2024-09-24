using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{   
    // RoleSeeder class
    public class RoleSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {   
            // Initialize the seed
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, Name = "admin" },
                new UserRole { Id = 2, Name = "cliente" }
            );
        }
    }
}
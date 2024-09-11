using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Seeders
{
    public class UserSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var users = new[]
        {
            new { Id = 1, Name = "jackeline cardona", Email = "jackeline.cardona@example.com", PhoneNumber = "1234567890", CreatedAt = new DateTime(2024, 2, 15, 1, 17, 51, DateTimeKind.Utc), SectorId = 1, RoleId = 1 },
            new { Id = 2, Name = "jane smith", Email = "jane.smith@example.com", PhoneNumber = "2345678901", CreatedAt = new DateTime(2024, 3, 10, 1, 17, 51, DateTimeKind.Utc), SectorId = 2, RoleId = 2 },
            new { Id = 3, Name = "alice johnson", Email = "alice.johnson@example.com", PhoneNumber = "3456789012", CreatedAt = new DateTime(2024, 4, 5, 1, 17, 51, DateTimeKind.Utc), SectorId = 4, RoleId = 2 },
            new { Id = 4, Name = "bob williams", Email = "bob.williams@example.com", PhoneNumber = "4567890123", CreatedAt = new DateTime(2024, 5, 20, 1, 17, 51, DateTimeKind.Utc), SectorId = 3, RoleId = 2 },
            new { Id = 5, Name = "charlie brown", Email = "charlie.brown@example.com", PhoneNumber = "5678901234", CreatedAt = new DateTime(2024, 6, 25, 1, 17, 51, DateTimeKind.Utc), SectorId = 2, RoleId = 2 },
            new { Id = 6, Name = "diana clark", Email = "diana.clark@example.com", PhoneNumber = "6789012345", CreatedAt = new DateTime(2024, 7, 10, 1, 17, 51, DateTimeKind.Utc), SectorId = 1, RoleId = 2 },
            new { Id = 7, Name = "edward davis", Email = "edward.davis@example.com", PhoneNumber = "7890123456", CreatedAt = new DateTime(2024, 8, 15, 1, 17, 51, DateTimeKind.Utc), SectorId = 5, RoleId = 2 },
            new { Id = 8, Name = "fiona evans", Email = "fiona.evans@example.com", PhoneNumber = "8901234567", CreatedAt = new DateTime(2024, 9, 10, 1, 17, 51, DateTimeKind.Utc), SectorId = 2, RoleId = 2 },
            new { Id = 9, Name = "george fisher", Email = "george.fisher@example.com", PhoneNumber = "9012345678", CreatedAt = new DateTime(2024, 10, 5, 1, 17, 51, DateTimeKind.Utc), SectorId = 5, RoleId = 2 },
            new { Id = 10, Name = "hannah green", Email = "hannah.green@example.com", PhoneNumber = "0123456789", CreatedAt = new DateTime(2024, 11, 1, 1, 17, 51, DateTimeKind.Utc), SectorId = 3, RoleId = 2 }
        };

        foreach (var user in users)
        {
            CreatePasswordHash("riwi123", out byte[] passwordHash, out byte[] passwordSalt);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                IsConfirmed = true,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = user.PhoneNumber,
                CreatedAt = user.CreatedAt,
                SectorId = user.SectorId,
                RoleId = user.RoleId
            });
        }
    }

    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}
}
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Riwi_LinkUp.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clan",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "berners lee" },
                    { 2, "ritchie" },
                    { 3, "gates" },
                    { 4, "jeff bezzos" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "masculino" },
                    { 2, "femenino" },
                    { 3, "prefiero no indicarlo" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "inglés" },
                    { 2, "español" },
                    { 3, "francés" }
                });

            migrationBuilder.InsertData(
                table: "Sector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "tecnología" },
                    { 2, "finanzas" },
                    { 3, "salud" },
                    { 4, "educación" },
                    { 5, "manufactura" }
                });

            migrationBuilder.InsertData(
                table: "SoftSkills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "comunicación" },
                    { 2, "trabajo en equipo" },
                    { 3, "resolución de problemas" },
                    { 4, "adaptabilidad" },
                    { 5, "creatividad" },
                    { 6, "gestión del tiempo" },
                    { 7, "liderazgo" },
                    { 8, "inteligencia emocional" },
                    { 9, "pensamiento crítico" },
                    { 10, "resolución de conflictos" }
                });

            migrationBuilder.InsertData(
                table: "TechnicalSkills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "javaScript" },
                    { 2, "python" },
                    { 3, "java" },
                    { 4, "c#" },
                    { 5, "sql" },
                    { 6, "nextJs" },
                    { 7, "nodeJs" },
                    { 8, "docker" },
                    { 9, "aws" },
                    { 10, "machine learning" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "cliente" }
                });

            migrationBuilder.InsertData(
                table: "Coders",
                columns: new[] { "Id", "Birthday", "ClanId", "ClanName", "Description", "GenderId", "Name", "UrlImage" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 5, 22, 1, 17, 51, 0, DateTimeKind.Utc), 1, null, "especialista en front-end", 2, "edgar cardona", "https://media.licdn.com/dms/image/v2/D4E03AQH22ztGRhoM2g/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1677008729241?e=1731542400&v=beta&t=89RVHJpVnq8_m5ObsEU3CEs0KVrBraYI4gGWdIEuXEM" },
                    { 2, new DateTime(1988, 9, 30, 1, 17, 51, 0, DateTimeKind.Utc), 2, null, "desarrollador backend", 1, "nicolas martinez", "https://avatars.githubusercontent.com/u/164014608?v=4&size=64" },
                    { 3, new DateTime(1995, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), 2, null, "desarrolladora de aplicaciones móviles", 2, "brayan acosta", "https://media.licdn.com/dms/image/v2/C4D03AQHAwWzaQDI6gw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1641180503207?e=1731542400&v=beta&t=A7lWrZBzJ84ZlLdFsvKA73tbZKdP1vfPGuvf3Ah6XH4" },
                    { 4, new DateTime(1991, 7, 18, 1, 17, 51, 0, DateTimeKind.Utc), 3, null, "ingeniero devops", 1, "jose barreto", "https://media.licdn.com/dms/image/v2/D4E03AQEqn-8BGpvfaw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1724345138906?e=1731542400&v=beta&t=wWL1nKrccb9DfJVg8Dz6v49L3AIpunv8gkovi5BpqgQ" },
                    { 5, new DateTime(1993, 11, 5, 1, 17, 51, 0, DateTimeKind.Utc), 4, null, "diseñadora ui/ux", 2, "juan arias", "https://media.licdn.com/dms/image/v2/D4E03AQGXb8dGisr-wQ/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1724327950529?e=1731542400&v=beta&t=uCMHF7cJT2SfM-4acPddFycPWzAUYFWYr_WofvG2Cf8" },
                    { 6, new DateTime(1989, 2, 28, 1, 17, 51, 0, DateTimeKind.Utc), 1, null, "científico de datos", 1, "juan rojas", "https://media.licdn.com/dms/image/v2/D4E03AQGyhYNRLL9edg/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1681701914743?e=1731542400&v=beta&t=0aYfJifoDREE5dhY4dCSD8IECOotdQqJ5HwtLfAKkxw" },
                    { 7, new DateTime(1994, 6, 12, 1, 17, 51, 0, DateTimeKind.Utc), 4, null, "especialista en seguridad", 2, "ava martinez", "https://example.com/ava.jpg" },
                    { 8, new DateTime(1987, 10, 8, 1, 17, 51, 0, DateTimeKind.Utc), 1, null, "desarrollador de videojuegos", 1, "noah anderson", "https://example.com/noah.jpg" },
                    { 9, new DateTime(1996, 4, 25, 1, 17, 51, 0, DateTimeKind.Utc), 2, null, "desarrolladora de blockchain", 2, "isabella white", "https://example.com/isabella.jpg" },
                    { 10, new DateTime(1990, 1, 15, 1, 17, 51, 0, DateTimeKind.Utc), 3, null, "desarrollador full-stack", 1, "alex johnson", "https://example.com/alex.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsConfirmed", "Name", "Password", "PhoneNumber", "RoleId", "SectorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", "riwi123", "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", "riwi123", "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 4, 5, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", "riwi123", "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", "riwi123", "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 6, 25, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", "riwi123", "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", "riwi123", "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 8, 15, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", "riwi123", "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 9, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", "riwi123", "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 10, 5, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", "riwi123", "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 11, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", "riwi123", "0123456789", 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SoftSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sector",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sector",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sector",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sector",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sector",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

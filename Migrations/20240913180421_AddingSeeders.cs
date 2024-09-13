using System;
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
                table: "Clans",
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
                table: "LanguageLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "a1" },
                    { 2, "a2" },
                    { 3, "b1" },
                    { 4, "b2" },
                    { 5, "c1" },
                    { 6, "c2" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "inglés" },
                    { 2, "portugues" },
                    { 3, "francés" },
                    { 4, "aleman" },
                    { 5, "chino" }
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
                table: "TechnicalSkillLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "junior" },
                    { 2, "semi-senior" },
                    { 3, "senior" }
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
                    { 5, "nextJs" },
                    { 6, "nodeJs" }
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
                columns: new[] { "Id", "Birthday", "ClanId", "Description", "GenderId", "Name", "UrlImage" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 5, 22, 1, 17, 51, 0, DateTimeKind.Utc), 1, "especialista en front-end", 1, "edgar cardona", "https://media.licdn.com/dms/image/v2/D4E03AQH22ztGRhoM2g/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1677008729241?e=1731542400&v=beta&t=89RVHJpVnq8_m5ObsEU3CEs0KVrBraYI4gGWdIEuXEM" },
                    { 2, new DateTime(1988, 9, 30, 1, 17, 51, 0, DateTimeKind.Utc), 2, "desarrollador backend", 1, "nicolas martinez", "https://avatars.githubusercontent.com/u/164014608?v=4&size=64" },
                    { 3, new DateTime(1995, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), 2, "desarrolladora de aplicaciones móviles", 2, "brayan acosta", "https://media.licdn.com/dms/image/v2/C4D03AQHAwWzaQDI6gw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1641180503207?e=1731542400&v=beta&t=A7lWrZBzJ84ZlLdFsvKA73tbZKdP1vfPGuvf3Ah6XH4" },
                    { 4, new DateTime(1991, 7, 18, 1, 17, 51, 0, DateTimeKind.Utc), 3, "ingeniero devops", 1, "jose barreto", "https://media.licdn.com/dms/image/v2/D4E03AQEqn-8BGpvfaw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1724345138906?e=1731542400&v=beta&t=wWL1nKrccb9DfJVg8Dz6v49L3AIpunv8gkovi5BpqgQ" },
                    { 5, new DateTime(1993, 11, 5, 1, 17, 51, 0, DateTimeKind.Utc), 4, "diseñadora ui/ux", 2, "juan arias", "https://media.licdn.com/dms/image/v2/D4E03AQGXb8dGisr-wQ/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1724327950529?e=1731542400&v=beta&t=uCMHF7cJT2SfM-4acPddFycPWzAUYFWYr_WofvG2Cf8" },
                    { 6, new DateTime(1989, 2, 28, 1, 17, 51, 0, DateTimeKind.Utc), 1, "científico de datos", 1, "juan rojas", "https://media.licdn.com/dms/image/v2/D4E03AQGyhYNRLL9edg/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1681701914743?e=1731542400&v=beta&t=0aYfJifoDREE5dhY4dCSD8IECOotdQqJ5HwtLfAKkxw" },
                    { 7, new DateTime(1994, 6, 12, 1, 17, 51, 0, DateTimeKind.Utc), 4, "especialista en seguridad", 2, "ava martinez", "https://example.com/ava.jpg" },
                    { 8, new DateTime(1987, 10, 8, 1, 17, 51, 0, DateTimeKind.Utc), 1, "desarrollador de videojuegos", 1, "noah anderson", "https://example.com/noah.jpg" },
                    { 9, new DateTime(1996, 4, 25, 1, 17, 51, 0, DateTimeKind.Utc), 2, "desarrolladora de blockchain", 2, "isabella white", "https://example.com/isabella.jpg" },
                    { 10, new DateTime(1990, 1, 15, 1, 17, 51, 0, DateTimeKind.Utc), 3, "desarrollador full-stack", 1, "alex johnson", "https://example.com/alex.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsConfirmed", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "SectorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 15, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", new byte[] { 215, 178, 33, 67, 55, 118, 221, 132, 76, 118, 3, 45, 60, 206, 116, 3, 74, 213, 78, 250, 112, 101, 98, 62, 222, 153, 35, 53, 79, 191, 8, 2, 183, 21, 138, 149, 121, 42, 165, 79, 250, 250, 10, 135, 166, 201, 137, 101, 26, 116, 116, 174, 78, 51, 3, 187, 144, 213, 37, 92, 53, 172, 38, 103 }, new byte[] { 17, 78, 181, 229, 50, 76, 75, 216, 143, 170, 4, 120, 235, 102, 221, 31, 17, 173, 48, 148, 19, 129, 236, 14, 80, 125, 214, 138, 107, 79, 254, 22, 220, 107, 205, 224, 251, 68, 246, 92, 22, 30, 68, 144, 199, 42, 49, 65, 195, 195, 131, 51, 38, 48, 168, 170, 222, 172, 221, 206, 39, 118, 144, 234, 125, 18, 143, 201, 140, 171, 183, 150, 2, 131, 11, 27, 83, 145, 42, 245, 243, 236, 132, 219, 89, 208, 34, 137, 130, 23, 64, 39, 55, 138, 239, 213, 118, 113, 222, 79, 48, 153, 166, 14, 45, 184, 217, 231, 241, 224, 99, 2, 183, 155, 132, 196, 246, 42, 20, 81, 61, 253, 108, 192, 69, 122, 182, 219 }, "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", new byte[] { 246, 49, 139, 134, 0, 30, 196, 175, 123, 27, 76, 22, 238, 192, 88, 173, 230, 39, 49, 65, 245, 120, 138, 125, 92, 178, 2, 225, 184, 185, 46, 66, 174, 11, 85, 191, 109, 41, 215, 4, 189, 185, 85, 178, 209, 210, 136, 83, 174, 158, 229, 2, 160, 176, 60, 145, 251, 215, 221, 205, 123, 27, 170, 94 }, new byte[] { 235, 83, 208, 204, 179, 238, 99, 248, 193, 199, 91, 8, 25, 215, 246, 169, 196, 0, 58, 247, 56, 94, 208, 134, 58, 245, 223, 166, 241, 251, 99, 19, 255, 217, 6, 146, 125, 110, 122, 235, 130, 236, 219, 6, 88, 6, 194, 159, 191, 85, 82, 223, 27, 82, 9, 107, 6, 179, 227, 35, 209, 161, 74, 165, 212, 20, 54, 2, 140, 74, 176, 61, 19, 143, 204, 112, 167, 48, 129, 83, 107, 181, 11, 105, 50, 248, 98, 12, 231, 34, 179, 58, 229, 103, 252, 173, 172, 227, 233, 246, 27, 229, 2, 124, 152, 155, 204, 7, 215, 52, 254, 83, 43, 224, 221, 59, 91, 112, 171, 74, 105, 191, 134, 218, 241, 185, 234, 112 }, "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 4, 5, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", new byte[] { 185, 149, 55, 54, 45, 83, 203, 121, 74, 48, 245, 30, 133, 166, 69, 85, 97, 180, 90, 251, 42, 52, 111, 233, 195, 40, 103, 185, 7, 55, 249, 225, 101, 174, 205, 193, 122, 188, 147, 169, 150, 132, 125, 44, 128, 164, 139, 141, 253, 180, 48, 52, 31, 39, 129, 245, 233, 249, 139, 201, 179, 191, 75, 91 }, new byte[] { 56, 112, 13, 123, 156, 144, 60, 65, 31, 161, 12, 143, 104, 58, 133, 59, 148, 222, 216, 205, 95, 51, 88, 160, 104, 120, 27, 86, 216, 93, 255, 171, 174, 184, 113, 240, 15, 219, 132, 206, 77, 125, 245, 147, 19, 178, 219, 61, 143, 243, 90, 91, 140, 17, 44, 113, 55, 71, 123, 232, 140, 162, 221, 161, 175, 15, 100, 162, 222, 19, 175, 62, 224, 107, 164, 176, 111, 44, 165, 38, 241, 112, 50, 76, 228, 73, 110, 182, 77, 183, 111, 8, 86, 244, 232, 23, 53, 186, 209, 0, 154, 72, 77, 75, 81, 103, 234, 51, 141, 135, 109, 29, 237, 85, 50, 36, 30, 114, 80, 86, 99, 15, 211, 154, 73, 86, 168, 134 }, "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", new byte[] { 35, 214, 56, 188, 17, 248, 177, 220, 238, 252, 40, 173, 215, 103, 169, 135, 111, 39, 198, 17, 28, 205, 137, 205, 99, 196, 5, 228, 235, 161, 200, 170, 192, 224, 189, 99, 189, 48, 212, 242, 73, 153, 241, 92, 36, 201, 81, 17, 180, 242, 8, 5, 57, 215, 118, 35, 125, 38, 251, 242, 56, 184, 210, 45 }, new byte[] { 81, 205, 164, 150, 149, 188, 81, 145, 207, 110, 183, 18, 58, 234, 225, 1, 230, 192, 177, 32, 176, 228, 92, 248, 208, 3, 67, 4, 76, 220, 232, 224, 209, 127, 148, 154, 68, 178, 241, 167, 192, 136, 97, 74, 63, 239, 73, 247, 86, 27, 209, 132, 223, 203, 205, 192, 190, 2, 135, 192, 171, 227, 104, 171, 168, 91, 29, 211, 87, 136, 8, 245, 136, 117, 255, 196, 114, 194, 164, 199, 212, 99, 211, 187, 213, 250, 139, 232, 176, 245, 125, 161, 189, 126, 119, 64, 137, 254, 17, 139, 144, 53, 88, 63, 133, 34, 45, 29, 77, 113, 8, 87, 133, 1, 236, 131, 202, 82, 140, 193, 88, 187, 51, 20, 231, 136, 48, 11 }, "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 5, 25, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", new byte[] { 110, 70, 176, 166, 66, 1, 110, 147, 219, 26, 102, 13, 231, 196, 73, 45, 91, 247, 84, 99, 201, 51, 9, 84, 20, 91, 230, 233, 72, 194, 219, 182, 236, 136, 175, 188, 69, 56, 52, 25, 207, 228, 84, 54, 252, 79, 105, 122, 62, 186, 67, 180, 122, 52, 209, 83, 31, 5, 184, 113, 132, 208, 248, 192 }, new byte[] { 149, 119, 95, 107, 142, 74, 159, 130, 161, 11, 237, 129, 39, 214, 39, 167, 169, 249, 4, 74, 88, 64, 223, 213, 74, 255, 218, 128, 245, 107, 145, 133, 229, 171, 102, 94, 70, 202, 42, 93, 112, 31, 59, 255, 223, 176, 192, 179, 231, 161, 140, 174, 197, 13, 167, 231, 60, 146, 251, 98, 28, 174, 95, 114, 36, 71, 250, 232, 235, 19, 21, 38, 221, 73, 0, 42, 179, 132, 95, 180, 82, 190, 51, 205, 8, 133, 228, 43, 143, 185, 177, 153, 132, 146, 42, 82, 37, 225, 215, 207, 233, 237, 137, 190, 167, 51, 224, 19, 142, 174, 95, 13, 203, 177, 246, 227, 61, 251, 40, 173, 35, 225, 105, 161, 191, 209, 43, 92 }, "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 5, 10, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", new byte[] { 155, 193, 244, 172, 241, 226, 144, 193, 184, 225, 197, 118, 5, 143, 117, 80, 106, 55, 93, 117, 49, 61, 217, 46, 25, 80, 142, 227, 78, 88, 235, 115, 218, 49, 236, 167, 194, 27, 203, 46, 208, 141, 192, 210, 154, 121, 153, 238, 95, 87, 49, 56, 91, 54, 222, 155, 238, 249, 122, 9, 184, 228, 6, 99 }, new byte[] { 195, 49, 90, 111, 246, 86, 92, 230, 246, 229, 125, 226, 196, 28, 20, 203, 92, 17, 164, 51, 51, 104, 226, 133, 208, 176, 240, 121, 52, 66, 139, 20, 237, 37, 168, 94, 207, 110, 234, 29, 3, 186, 191, 227, 32, 237, 148, 67, 82, 199, 232, 139, 23, 81, 53, 180, 41, 213, 151, 132, 177, 247, 28, 126, 42, 231, 54, 23, 207, 191, 144, 167, 80, 191, 189, 67, 25, 187, 227, 39, 118, 207, 61, 72, 248, 166, 205, 217, 228, 107, 67, 49, 150, 126, 144, 49, 52, 225, 10, 47, 59, 198, 249, 54, 25, 15, 219, 202, 160, 241, 234, 147, 104, 11, 191, 76, 50, 180, 51, 108, 141, 142, 16, 168, 41, 113, 190, 28 }, "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 6, 15, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", new byte[] { 188, 6, 82, 74, 45, 91, 167, 206, 188, 200, 192, 215, 116, 136, 81, 50, 210, 132, 181, 167, 159, 192, 126, 230, 15, 173, 163, 56, 30, 177, 204, 215, 230, 20, 146, 34, 2, 234, 105, 102, 75, 177, 28, 163, 128, 64, 230, 114, 161, 97, 42, 236, 172, 37, 167, 134, 178, 145, 201, 250, 147, 103, 155, 183 }, new byte[] { 113, 154, 249, 20, 115, 94, 77, 22, 138, 114, 201, 42, 185, 74, 242, 92, 131, 74, 96, 76, 160, 177, 173, 187, 69, 131, 133, 130, 89, 2, 197, 222, 84, 120, 192, 54, 233, 251, 185, 211, 1, 59, 83, 110, 161, 5, 91, 160, 110, 255, 73, 231, 187, 184, 4, 17, 167, 213, 95, 126, 145, 195, 144, 202, 19, 138, 34, 4, 193, 243, 166, 88, 130, 219, 230, 39, 249, 79, 100, 44, 77, 175, 169, 171, 189, 2, 67, 143, 52, 103, 212, 99, 171, 38, 121, 55, 133, 120, 90, 222, 10, 132, 162, 88, 249, 30, 212, 125, 5, 223, 52, 141, 113, 42, 55, 0, 33, 173, 50, 15, 167, 112, 240, 119, 248, 117, 118, 126 }, "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", new byte[] { 86, 112, 109, 82, 15, 228, 105, 212, 209, 208, 121, 153, 169, 114, 33, 116, 205, 194, 249, 231, 188, 9, 58, 171, 189, 63, 175, 49, 20, 70, 21, 168, 19, 169, 223, 65, 106, 75, 215, 38, 13, 255, 166, 150, 84, 70, 228, 214, 125, 199, 79, 248, 37, 76, 132, 112, 159, 249, 65, 98, 68, 9, 84, 102 }, new byte[] { 136, 76, 12, 231, 153, 62, 67, 186, 240, 162, 23, 22, 155, 223, 122, 93, 193, 51, 159, 254, 2, 100, 125, 28, 158, 199, 118, 247, 39, 36, 21, 23, 183, 234, 29, 116, 97, 99, 232, 149, 111, 126, 199, 251, 172, 159, 237, 0, 169, 148, 87, 120, 58, 21, 146, 59, 99, 24, 89, 79, 110, 126, 210, 199, 88, 218, 56, 136, 248, 148, 81, 61, 33, 170, 133, 200, 140, 35, 39, 187, 254, 86, 170, 39, 252, 73, 233, 131, 74, 121, 80, 134, 187, 78, 41, 233, 48, 89, 132, 72, 33, 123, 193, 112, 112, 168, 34, 12, 207, 12, 79, 233, 168, 149, 136, 169, 116, 5, 189, 228, 186, 135, 234, 120, 89, 221, 204, 35 }, "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 8, 5, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", new byte[] { 52, 226, 249, 218, 230, 218, 201, 163, 58, 248, 162, 121, 204, 27, 148, 87, 211, 170, 99, 28, 168, 37, 161, 113, 101, 233, 46, 242, 157, 30, 4, 1, 152, 236, 195, 71, 18, 24, 87, 69, 163, 225, 145, 250, 105, 129, 73, 125, 159, 2, 102, 222, 109, 22, 147, 58, 35, 245, 27, 37, 238, 147, 91, 191 }, new byte[] { 173, 37, 233, 38, 95, 11, 197, 213, 99, 183, 71, 215, 172, 47, 86, 48, 251, 80, 88, 187, 111, 149, 241, 212, 24, 141, 116, 128, 70, 182, 42, 92, 1, 59, 80, 113, 20, 86, 75, 210, 119, 86, 127, 54, 189, 93, 139, 226, 202, 198, 133, 75, 233, 230, 145, 202, 55, 79, 224, 128, 106, 187, 4, 224, 247, 35, 154, 28, 177, 20, 170, 98, 2, 166, 184, 199, 181, 252, 213, 183, 26, 146, 70, 31, 195, 212, 211, 100, 155, 85, 233, 54, 247, 159, 201, 12, 70, 175, 249, 182, 126, 164, 221, 133, 222, 220, 57, 34, 190, 194, 116, 40, 21, 14, 154, 35, 120, 137, 204, 110, 116, 16, 88, 104, 29, 138, 56, 17 }, "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 9, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", new byte[] { 178, 209, 142, 58, 219, 232, 27, 152, 250, 57, 65, 5, 13, 128, 0, 225, 31, 185, 222, 234, 202, 57, 21, 112, 155, 114, 87, 180, 115, 100, 140, 243, 108, 223, 205, 168, 42, 216, 104, 54, 235, 118, 2, 170, 104, 171, 25, 50, 190, 60, 77, 39, 12, 191, 10, 91, 235, 149, 65, 226, 6, 207, 213, 121 }, new byte[] { 169, 192, 193, 230, 70, 223, 60, 169, 133, 148, 126, 80, 197, 255, 79, 93, 11, 61, 59, 178, 22, 222, 59, 175, 186, 212, 221, 239, 254, 60, 151, 239, 25, 125, 243, 22, 35, 17, 160, 106, 52, 209, 40, 221, 212, 85, 14, 82, 95, 175, 57, 9, 64, 247, 163, 138, 160, 129, 117, 89, 240, 13, 42, 225, 75, 171, 178, 180, 105, 20, 170, 60, 83, 80, 122, 111, 49, 179, 30, 133, 184, 97, 109, 230, 55, 27, 215, 132, 168, 115, 56, 217, 229, 160, 209, 105, 194, 27, 237, 239, 34, 115, 10, 28, 0, 18, 118, 115, 156, 181, 171, 149, 177, 63, 92, 192, 40, 144, 19, 134, 185, 224, 146, 252, 253, 223, 37, 98 }, "0123456789", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CoderLanguages",
                columns: new[] { "Id", "CoderId", "LanguageId", "LanguageLevelId" },
                values: new object[,]
                {
                    { 1, 1, 1, 4 },
                    { 2, 1, 3, 1 },
                    { 3, 2, 1, 3 },
                    { 4, 3, 2, 2 },
                    { 5, 4, 5, 4 },
                    { 6, 5, 3, 5 },
                    { 7, 6, 2, 2 },
                    { 8, 7, 1, 3 },
                    { 9, 8, 5, 4 },
                    { 10, 9, 1, 6 },
                    { 11, 10, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CoderSoftSkills",
                columns: new[] { "CoderId", "SoftSkillId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 3, 2 },
                    { 2, 2, 3 },
                    { 3, 3, 4 },
                    { 4, 4, 5 },
                    { 5, 5, 6 },
                    { 6, 6, 7 },
                    { 7, 7, 8 },
                    { 8, 8, 9 },
                    { 9, 9, 10 },
                    { 10, 10, 11 }
                });

            migrationBuilder.InsertData(
                table: "CoderTechnicalSkills",
                columns: new[] { "Id", "CoderId", "TechnicalSkillId", "TechnicalSkillLevelId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 4, 1 },
                    { 3, 2, 2, 1 },
                    { 4, 3, 1, 1 },
                    { 5, 4, 6, 1 },
                    { 6, 5, 4, 1 },
                    { 7, 6, 3, 1 },
                    { 8, 7, 1, 1 },
                    { 9, 8, 5, 1 },
                    { 10, 9, 1, 1 },
                    { 11, 10, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LanguageLevels",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clans",
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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Riwi_LinkUp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingSeeders : Migration
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
                columns: new[] { "Id", "Birthday", "ClanId", "Description", "GenderId", "Name", "UrlImage" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 5, 22, 1, 17, 51, 0, DateTimeKind.Utc), 1, "especialista en front-end", 2, "edgar cardona", "https://media.licdn.com/dms/image/v2/D4E03AQH22ztGRhoM2g/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1677008729241?e=1731542400&v=beta&t=89RVHJpVnq8_m5ObsEU3CEs0KVrBraYI4gGWdIEuXEM" },
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
                    { 1, new DateTime(2024, 2, 15, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", new byte[] { 121, 20, 239, 9, 179, 38, 120, 135, 158, 251, 220, 207, 172, 144, 64, 127, 238, 55, 141, 9, 177, 228, 161, 100, 65, 177, 127, 178, 143, 253, 113, 12, 159, 212, 17, 124, 66, 54, 11, 245, 185, 198, 141, 68, 187, 47, 99, 182, 9, 19, 43, 158, 155, 37, 178, 215, 49, 31, 237, 146, 177, 61, 42, 246 }, new byte[] { 211, 220, 150, 37, 104, 29, 176, 94, 6, 137, 20, 134, 7, 251, 252, 167, 5, 154, 254, 81, 204, 7, 244, 133, 61, 68, 124, 139, 186, 119, 51, 173, 93, 228, 173, 217, 222, 127, 31, 114, 239, 20, 162, 152, 251, 6, 142, 16, 36, 111, 224, 130, 6, 84, 234, 133, 13, 226, 41, 138, 53, 14, 41, 113, 17, 140, 21, 82, 46, 216, 20, 237, 240, 22, 5, 2, 46, 151, 41, 230, 5, 89, 39, 139, 49, 57, 9, 14, 133, 20, 194, 163, 61, 17, 141, 4, 239, 213, 220, 183, 57, 60, 122, 231, 193, 223, 24, 186, 201, 202, 173, 5, 31, 187, 50, 35, 236, 219, 238, 205, 183, 231, 32, 233, 58, 178, 134, 101 }, "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", new byte[] { 152, 209, 223, 51, 75, 164, 121, 52, 9, 82, 75, 9, 142, 232, 0, 16, 32, 111, 251, 19, 187, 52, 57, 176, 201, 152, 139, 158, 37, 219, 238, 131, 186, 183, 10, 208, 56, 159, 46, 35, 233, 235, 165, 52, 113, 151, 220, 57, 2, 106, 105, 70, 35, 233, 243, 53, 41, 36, 197, 238, 182, 136, 116, 251 }, new byte[] { 185, 138, 226, 56, 249, 121, 203, 224, 21, 164, 187, 200, 69, 76, 52, 22, 140, 149, 240, 179, 52, 55, 188, 205, 10, 75, 187, 29, 217, 63, 137, 169, 121, 74, 125, 45, 16, 114, 173, 97, 63, 88, 141, 183, 96, 130, 225, 172, 244, 222, 63, 0, 41, 92, 174, 200, 230, 137, 192, 50, 113, 117, 88, 142, 70, 12, 27, 78, 26, 13, 95, 37, 149, 209, 181, 24, 162, 235, 82, 156, 65, 218, 103, 232, 189, 130, 147, 103, 33, 186, 205, 236, 220, 196, 120, 134, 193, 97, 89, 48, 0, 240, 125, 200, 123, 84, 189, 162, 156, 34, 139, 88, 212, 229, 64, 36, 192, 223, 15, 162, 133, 118, 75, 209, 228, 30, 246, 139 }, "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 4, 5, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", new byte[] { 99, 153, 61, 248, 140, 113, 164, 255, 15, 189, 149, 208, 98, 47, 198, 186, 12, 67, 114, 96, 195, 62, 10, 177, 212, 60, 38, 158, 170, 226, 89, 183, 194, 5, 69, 50, 83, 93, 136, 27, 38, 65, 200, 198, 138, 25, 84, 48, 138, 234, 151, 227, 211, 146, 27, 143, 173, 250, 14, 36, 146, 92, 64, 19 }, new byte[] { 165, 128, 170, 86, 112, 49, 28, 128, 186, 149, 161, 218, 218, 206, 250, 42, 101, 144, 123, 18, 216, 147, 11, 71, 19, 88, 121, 116, 202, 209, 140, 199, 219, 117, 42, 153, 160, 58, 178, 230, 96, 141, 201, 156, 125, 51, 42, 18, 60, 2, 168, 56, 69, 239, 71, 147, 188, 212, 73, 111, 215, 169, 198, 12, 245, 34, 139, 89, 11, 228, 173, 192, 26, 36, 121, 232, 73, 205, 249, 179, 188, 191, 2, 124, 221, 14, 224, 215, 133, 228, 196, 176, 25, 5, 190, 193, 194, 200, 147, 29, 12, 142, 175, 116, 212, 69, 2, 36, 198, 51, 50, 228, 70, 209, 223, 144, 30, 35, 110, 239, 36, 215, 164, 162, 112, 211, 227, 67 }, "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", new byte[] { 111, 219, 141, 168, 159, 2, 65, 137, 120, 65, 5, 80, 5, 31, 214, 17, 255, 192, 98, 182, 106, 124, 195, 225, 30, 10, 208, 75, 110, 162, 81, 217, 182, 207, 50, 157, 103, 35, 202, 114, 96, 254, 239, 58, 47, 187, 74, 14, 23, 1, 69, 117, 245, 220, 73, 91, 232, 92, 193, 173, 16, 221, 230, 189 }, new byte[] { 4, 78, 180, 246, 241, 143, 38, 154, 193, 98, 15, 139, 238, 41, 127, 166, 238, 175, 112, 188, 239, 41, 253, 102, 20, 119, 134, 95, 103, 222, 203, 97, 60, 46, 243, 244, 57, 252, 12, 163, 138, 139, 244, 78, 137, 86, 74, 239, 124, 141, 39, 156, 48, 85, 209, 231, 212, 90, 105, 175, 7, 51, 164, 188, 136, 155, 172, 64, 167, 101, 237, 101, 220, 242, 214, 212, 183, 149, 23, 62, 100, 47, 174, 113, 7, 77, 117, 157, 113, 43, 62, 16, 68, 188, 213, 164, 61, 13, 160, 131, 111, 255, 45, 186, 84, 142, 115, 2, 102, 195, 226, 131, 18, 109, 36, 77, 137, 25, 139, 148, 173, 7, 93, 220, 136, 7, 52, 251 }, "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 6, 25, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", new byte[] { 224, 185, 41, 64, 146, 134, 77, 173, 219, 220, 99, 152, 169, 90, 147, 179, 109, 218, 46, 17, 123, 42, 76, 104, 173, 188, 139, 124, 239, 44, 169, 176, 110, 250, 36, 97, 42, 135, 213, 183, 65, 173, 64, 185, 126, 190, 120, 145, 88, 51, 180, 21, 139, 251, 0, 140, 213, 137, 85, 235, 214, 132, 185, 55 }, new byte[] { 47, 96, 47, 180, 131, 132, 77, 68, 116, 255, 231, 58, 108, 195, 250, 251, 149, 32, 87, 83, 70, 102, 102, 173, 87, 253, 207, 153, 152, 105, 128, 72, 4, 254, 44, 215, 254, 16, 73, 243, 81, 103, 172, 19, 249, 177, 121, 128, 99, 45, 109, 93, 37, 91, 89, 32, 140, 196, 192, 101, 55, 199, 162, 2, 145, 113, 251, 34, 34, 139, 135, 208, 150, 214, 136, 231, 118, 170, 9, 48, 16, 255, 202, 167, 182, 209, 250, 108, 68, 40, 12, 209, 216, 140, 220, 66, 210, 204, 109, 12, 199, 39, 242, 19, 95, 130, 206, 249, 70, 144, 158, 195, 35, 202, 239, 206, 178, 255, 213, 157, 33, 216, 114, 148, 10, 156, 211, 68 }, "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", new byte[] { 35, 43, 18, 14, 240, 121, 118, 171, 219, 86, 200, 40, 179, 205, 144, 5, 154, 238, 11, 232, 40, 110, 207, 254, 225, 31, 37, 225, 239, 218, 65, 146, 44, 180, 75, 34, 46, 208, 168, 123, 106, 249, 84, 205, 93, 111, 14, 99, 2, 232, 212, 187, 166, 157, 106, 240, 26, 215, 3, 26, 125, 118, 2, 80 }, new byte[] { 156, 226, 6, 189, 161, 164, 131, 113, 248, 133, 193, 169, 146, 135, 20, 10, 230, 174, 118, 8, 238, 204, 112, 249, 45, 61, 197, 198, 60, 165, 246, 161, 67, 100, 3, 246, 82, 183, 85, 202, 183, 25, 251, 43, 254, 53, 31, 204, 30, 143, 51, 50, 30, 134, 133, 255, 127, 130, 239, 63, 32, 114, 92, 212, 126, 140, 149, 79, 15, 144, 242, 191, 242, 112, 37, 90, 83, 109, 137, 43, 166, 118, 90, 40, 119, 70, 138, 53, 82, 209, 53, 88, 19, 156, 204, 44, 196, 108, 77, 35, 205, 166, 41, 69, 84, 252, 211, 221, 241, 164, 23, 85, 47, 241, 137, 207, 147, 122, 119, 238, 179, 44, 201, 57, 143, 3, 78, 254 }, "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 8, 15, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", new byte[] { 113, 242, 51, 202, 3, 14, 168, 54, 25, 92, 35, 88, 46, 81, 207, 103, 27, 41, 251, 37, 155, 32, 159, 8, 242, 241, 231, 21, 198, 213, 171, 172, 11, 238, 171, 244, 110, 149, 169, 58, 172, 229, 245, 224, 114, 100, 89, 105, 184, 232, 90, 209, 220, 212, 170, 39, 130, 23, 209, 74, 10, 36, 200, 51 }, new byte[] { 70, 164, 144, 220, 42, 95, 206, 135, 210, 140, 17, 160, 43, 86, 119, 247, 243, 110, 49, 159, 125, 165, 159, 212, 141, 126, 85, 1, 19, 230, 62, 134, 85, 248, 144, 32, 69, 133, 132, 110, 175, 127, 108, 212, 124, 211, 54, 63, 94, 111, 93, 152, 132, 148, 74, 218, 85, 63, 57, 113, 135, 75, 218, 5, 167, 246, 109, 178, 79, 23, 52, 167, 146, 213, 87, 75, 188, 238, 89, 46, 206, 77, 169, 95, 240, 58, 216, 239, 52, 179, 195, 232, 183, 227, 65, 204, 92, 134, 108, 146, 234, 61, 110, 143, 127, 192, 203, 46, 33, 206, 20, 75, 52, 10, 207, 178, 222, 190, 156, 145, 129, 29, 183, 73, 225, 95, 125, 36 }, "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 9, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", new byte[] { 226, 176, 171, 148, 175, 217, 192, 91, 119, 5, 129, 0, 59, 197, 136, 69, 45, 183, 117, 19, 174, 55, 138, 229, 99, 74, 148, 242, 100, 52, 119, 239, 130, 243, 95, 172, 221, 214, 148, 196, 85, 116, 125, 96, 161, 115, 200, 83, 51, 70, 104, 43, 6, 175, 16, 11, 164, 230, 171, 172, 98, 46, 31, 180 }, new byte[] { 248, 228, 9, 102, 111, 165, 93, 20, 76, 211, 52, 188, 73, 203, 201, 234, 219, 208, 170, 8, 134, 156, 168, 23, 201, 141, 112, 178, 3, 229, 139, 185, 208, 170, 36, 148, 141, 230, 184, 120, 53, 91, 58, 111, 204, 162, 94, 66, 216, 71, 146, 238, 131, 182, 77, 90, 30, 86, 123, 139, 251, 87, 166, 161, 56, 222, 35, 228, 123, 75, 204, 160, 213, 220, 128, 185, 19, 40, 138, 101, 178, 109, 19, 86, 40, 123, 125, 121, 97, 98, 232, 101, 209, 49, 167, 172, 186, 27, 97, 121, 248, 250, 87, 92, 121, 196, 139, 203, 220, 179, 173, 243, 124, 83, 205, 253, 120, 1, 174, 252, 55, 75, 89, 238, 50, 75, 169, 139 }, "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 10, 5, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", new byte[] { 52, 174, 236, 102, 196, 195, 167, 27, 173, 191, 77, 216, 250, 44, 13, 155, 148, 68, 118, 124, 68, 143, 75, 159, 64, 96, 204, 243, 64, 168, 16, 241, 140, 255, 54, 113, 57, 171, 137, 201, 106, 7, 147, 9, 74, 67, 238, 98, 210, 168, 27, 212, 232, 134, 135, 24, 97, 7, 60, 137, 60, 190, 55, 149 }, new byte[] { 76, 78, 131, 13, 134, 207, 171, 131, 83, 16, 144, 137, 243, 225, 25, 7, 148, 20, 246, 150, 20, 251, 32, 251, 97, 203, 36, 187, 173, 253, 43, 63, 33, 217, 181, 243, 78, 118, 67, 211, 42, 227, 78, 33, 116, 73, 209, 108, 85, 184, 246, 201, 125, 245, 134, 116, 255, 48, 129, 243, 81, 63, 178, 140, 56, 196, 181, 177, 142, 160, 249, 248, 160, 161, 47, 201, 70, 52, 201, 230, 158, 91, 45, 41, 83, 49, 183, 249, 174, 73, 139, 77, 119, 211, 233, 10, 231, 200, 217, 253, 97, 16, 180, 104, 7, 177, 58, 62, 121, 166, 82, 69, 63, 185, 77, 193, 165, 243, 2, 68, 77, 41, 106, 222, 232, 210, 151, 39 }, "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 11, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", new byte[] { 170, 129, 224, 180, 226, 76, 25, 153, 106, 88, 126, 45, 42, 225, 28, 173, 153, 243, 195, 68, 155, 198, 179, 173, 73, 49, 223, 183, 120, 104, 169, 3, 51, 84, 209, 32, 103, 164, 46, 33, 88, 193, 254, 226, 87, 45, 235, 30, 236, 122, 213, 120, 200, 249, 170, 239, 47, 93, 101, 25, 156, 3, 244, 16 }, new byte[] { 87, 78, 46, 44, 174, 132, 251, 251, 209, 33, 180, 94, 91, 60, 110, 151, 109, 64, 218, 124, 73, 46, 3, 17, 123, 234, 9, 67, 233, 30, 220, 121, 18, 42, 192, 198, 239, 186, 222, 192, 79, 86, 75, 98, 206, 235, 101, 57, 206, 226, 193, 58, 176, 115, 149, 95, 95, 156, 255, 196, 54, 226, 53, 150, 207, 0, 166, 114, 80, 107, 102, 105, 123, 5, 195, 219, 252, 134, 179, 122, 28, 43, 235, 228, 91, 67, 63, 26, 102, 174, 90, 81, 120, 236, 2, 103, 233, 145, 40, 215, 144, 119, 95, 74, 120, 220, 38, 58, 162, 19, 124, 180, 163, 148, 42, 224, 25, 184, 43, 107, 87, 86, 184, 45, 232, 202, 104, 175 }, "0123456789", 2, 3 }
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

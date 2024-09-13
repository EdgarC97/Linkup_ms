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
                table: "TechnicalSkills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "javaScript" },
                    { 2, "python" },
                    { 3, "java" },
                    { 4, "c#" },
                    { 6, "nextJs" },
                    { 7, "nodeJs" }
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
                    { 1, new DateTime(2024, 3, 15, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", new byte[] { 83, 182, 195, 218, 140, 165, 246, 128, 3, 170, 135, 153, 246, 238, 52, 172, 144, 122, 43, 101, 28, 174, 139, 131, 223, 133, 208, 68, 125, 60, 56, 209, 255, 182, 97, 60, 94, 92, 84, 13, 194, 215, 105, 127, 41, 4, 73, 8, 15, 105, 141, 50, 196, 46, 39, 218, 179, 30, 94, 191, 55, 247, 134, 199 }, new byte[] { 12, 3, 135, 112, 248, 116, 212, 171, 85, 232, 185, 82, 214, 14, 217, 222, 49, 180, 168, 56, 187, 120, 55, 22, 156, 119, 224, 247, 98, 255, 224, 249, 41, 29, 14, 50, 73, 129, 74, 247, 56, 118, 171, 86, 161, 141, 196, 246, 222, 54, 200, 141, 237, 253, 155, 208, 177, 241, 0, 234, 29, 86, 220, 202, 121, 58, 42, 18, 57, 145, 174, 83, 254, 142, 25, 82, 252, 114, 172, 216, 134, 102, 129, 115, 196, 194, 250, 16, 228, 137, 88, 187, 155, 177, 76, 120, 81, 191, 212, 95, 218, 104, 107, 159, 245, 3, 73, 123, 166, 49, 17, 87, 237, 117, 98, 167, 126, 34, 147, 55, 226, 43, 215, 246, 227, 220, 214, 127 }, "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", new byte[] { 113, 2, 50, 10, 59, 109, 143, 161, 100, 42, 37, 146, 26, 122, 149, 164, 141, 240, 10, 242, 32, 55, 144, 108, 164, 198, 90, 215, 33, 122, 166, 100, 96, 210, 251, 50, 93, 76, 221, 41, 30, 75, 217, 172, 195, 135, 199, 19, 210, 172, 139, 83, 109, 177, 186, 73, 135, 18, 105, 5, 186, 35, 146, 29 }, new byte[] { 130, 97, 144, 116, 76, 24, 204, 97, 142, 117, 209, 130, 208, 90, 62, 5, 198, 221, 186, 226, 161, 151, 167, 240, 252, 8, 20, 58, 85, 50, 143, 91, 135, 92, 52, 99, 170, 224, 185, 97, 0, 47, 183, 222, 89, 33, 107, 133, 247, 5, 95, 72, 149, 119, 135, 182, 135, 36, 135, 148, 21, 63, 53, 68, 71, 42, 144, 185, 88, 222, 255, 127, 218, 46, 100, 178, 230, 88, 104, 4, 159, 59, 77, 96, 109, 5, 180, 167, 212, 57, 130, 24, 96, 187, 19, 204, 197, 165, 125, 82, 236, 250, 217, 5, 58, 119, 177, 24, 213, 29, 53, 74, 181, 52, 167, 230, 214, 54, 23, 115, 58, 71, 183, 88, 174, 215, 210, 30 }, "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 4, 5, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", new byte[] { 22, 27, 62, 108, 61, 186, 47, 63, 10, 199, 164, 129, 25, 219, 79, 220, 150, 7, 172, 61, 41, 143, 116, 10, 132, 58, 18, 168, 246, 74, 70, 213, 164, 247, 75, 14, 206, 5, 98, 102, 180, 247, 185, 158, 108, 220, 190, 2, 193, 243, 237, 186, 31, 91, 45, 196, 160, 191, 124, 107, 198, 136, 139, 243 }, new byte[] { 40, 105, 186, 210, 129, 121, 73, 43, 0, 13, 63, 134, 62, 138, 54, 30, 248, 0, 27, 157, 107, 48, 26, 234, 149, 110, 134, 35, 158, 107, 110, 154, 175, 56, 247, 71, 154, 235, 80, 95, 37, 10, 204, 202, 233, 133, 167, 25, 14, 53, 3, 14, 111, 202, 92, 255, 13, 244, 123, 8, 11, 187, 52, 254, 160, 192, 40, 211, 45, 33, 29, 11, 103, 88, 154, 69, 71, 79, 132, 144, 170, 114, 183, 212, 60, 93, 109, 91, 69, 186, 108, 105, 213, 108, 103, 150, 131, 108, 218, 11, 131, 52, 115, 135, 1, 54, 7, 1, 82, 9, 120, 66, 86, 166, 230, 214, 152, 59, 175, 146, 86, 148, 91, 186, 166, 143, 75, 142 }, "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", new byte[] { 253, 148, 187, 3, 33, 242, 205, 247, 213, 102, 45, 13, 154, 82, 199, 87, 10, 3, 141, 39, 112, 184, 142, 249, 90, 20, 75, 233, 38, 178, 120, 101, 38, 147, 244, 111, 127, 21, 124, 53, 212, 49, 44, 2, 207, 208, 121, 162, 209, 236, 234, 5, 244, 47, 214, 189, 157, 123, 94, 126, 218, 123, 165, 170 }, new byte[] { 35, 59, 46, 132, 205, 13, 69, 105, 33, 167, 63, 172, 218, 154, 92, 111, 96, 15, 229, 49, 137, 13, 20, 188, 111, 82, 189, 135, 23, 59, 38, 183, 168, 10, 8, 35, 104, 81, 83, 118, 124, 118, 58, 115, 36, 110, 193, 133, 15, 23, 196, 178, 171, 142, 243, 25, 193, 51, 201, 49, 102, 222, 208, 83, 67, 143, 98, 163, 8, 94, 180, 84, 243, 169, 163, 132, 231, 43, 95, 11, 28, 73, 81, 170, 69, 97, 39, 6, 241, 15, 172, 149, 81, 168, 53, 253, 175, 5, 71, 179, 110, 241, 128, 119, 137, 245, 85, 138, 42, 20, 29, 173, 216, 176, 71, 117, 183, 230, 24, 132, 250, 197, 51, 25, 141, 50, 80, 149 }, "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 5, 25, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", new byte[] { 203, 136, 178, 87, 1, 185, 65, 215, 44, 91, 205, 121, 99, 254, 50, 250, 122, 152, 156, 76, 251, 131, 170, 169, 1, 172, 76, 70, 74, 94, 239, 6, 53, 254, 38, 48, 161, 162, 115, 100, 85, 50, 97, 54, 92, 226, 86, 93, 125, 240, 153, 39, 111, 229, 140, 122, 194, 213, 193, 158, 73, 37, 192, 232 }, new byte[] { 89, 157, 15, 244, 206, 216, 245, 101, 202, 161, 158, 123, 160, 230, 107, 224, 108, 14, 254, 34, 253, 39, 71, 38, 155, 32, 87, 184, 144, 17, 237, 137, 251, 239, 203, 93, 30, 156, 179, 157, 87, 70, 89, 236, 69, 228, 43, 174, 94, 141, 247, 133, 95, 210, 68, 67, 66, 42, 5, 18, 92, 117, 159, 99, 147, 32, 90, 100, 137, 255, 13, 80, 71, 203, 105, 30, 91, 193, 68, 126, 128, 176, 15, 47, 144, 24, 252, 184, 14, 41, 28, 11, 28, 131, 125, 149, 234, 111, 79, 6, 240, 60, 78, 235, 231, 66, 31, 63, 126, 31, 234, 253, 92, 241, 113, 99, 55, 45, 226, 94, 3, 215, 21, 226, 38, 3, 171, 45 }, "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 5, 10, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", new byte[] { 80, 2, 225, 211, 182, 202, 100, 226, 140, 5, 129, 61, 19, 105, 151, 216, 187, 222, 52, 107, 55, 195, 134, 242, 189, 95, 127, 166, 235, 118, 34, 2, 214, 218, 244, 252, 159, 98, 177, 29, 149, 235, 22, 234, 132, 74, 124, 62, 205, 76, 91, 59, 112, 43, 132, 155, 157, 78, 183, 24, 239, 188, 205, 152 }, new byte[] { 146, 109, 204, 114, 155, 102, 222, 68, 232, 253, 28, 102, 239, 47, 211, 73, 73, 91, 105, 47, 216, 103, 226, 114, 117, 221, 133, 198, 219, 69, 227, 225, 234, 242, 118, 30, 13, 190, 236, 11, 254, 245, 43, 70, 126, 211, 164, 24, 92, 195, 139, 184, 37, 51, 225, 219, 162, 148, 46, 167, 97, 156, 144, 122, 88, 44, 43, 115, 68, 155, 186, 222, 11, 3, 81, 49, 253, 197, 224, 35, 15, 137, 70, 116, 155, 23, 30, 139, 211, 247, 214, 99, 132, 188, 53, 62, 109, 198, 87, 254, 53, 86, 251, 8, 104, 232, 178, 108, 2, 130, 25, 92, 151, 110, 112, 109, 48, 222, 131, 9, 153, 226, 67, 72, 139, 212, 46, 170 }, "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 6, 15, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", new byte[] { 195, 157, 125, 134, 44, 247, 224, 124, 79, 151, 223, 166, 197, 40, 76, 166, 50, 196, 173, 234, 243, 105, 117, 172, 160, 63, 233, 209, 130, 124, 209, 158, 241, 88, 7, 206, 187, 161, 165, 48, 42, 14, 144, 52, 143, 247, 84, 30, 240, 143, 242, 137, 167, 243, 174, 158, 155, 176, 212, 183, 102, 195, 151, 34 }, new byte[] { 6, 207, 115, 162, 145, 146, 187, 253, 198, 167, 118, 234, 129, 149, 149, 239, 143, 12, 170, 249, 202, 230, 156, 197, 59, 10, 222, 69, 116, 86, 197, 137, 255, 208, 249, 240, 16, 247, 10, 73, 19, 225, 69, 139, 9, 100, 40, 54, 98, 120, 193, 254, 35, 27, 29, 230, 46, 221, 151, 164, 5, 14, 68, 184, 131, 204, 226, 7, 226, 144, 90, 103, 89, 123, 212, 22, 194, 241, 174, 149, 31, 35, 35, 46, 101, 236, 254, 30, 171, 149, 59, 232, 41, 101, 168, 149, 226, 241, 253, 216, 71, 171, 20, 146, 79, 181, 79, 53, 181, 171, 80, 209, 160, 232, 31, 194, 73, 87, 60, 107, 53, 180, 240, 101, 137, 67, 170, 53 }, "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", new byte[] { 97, 52, 224, 226, 193, 2, 161, 158, 161, 15, 133, 114, 30, 254, 44, 169, 198, 124, 173, 112, 72, 30, 88, 197, 129, 200, 156, 119, 19, 135, 37, 240, 231, 103, 182, 157, 140, 178, 46, 111, 11, 94, 250, 240, 71, 215, 119, 242, 197, 63, 237, 176, 224, 32, 60, 144, 219, 160, 136, 236, 108, 119, 108, 66 }, new byte[] { 155, 4, 190, 55, 100, 35, 251, 46, 21, 198, 65, 50, 32, 28, 207, 127, 241, 17, 68, 249, 91, 72, 153, 68, 54, 36, 138, 252, 155, 155, 148, 93, 240, 196, 64, 203, 142, 19, 118, 217, 2, 213, 96, 156, 178, 77, 161, 42, 197, 223, 9, 46, 121, 106, 216, 132, 217, 159, 99, 154, 217, 247, 78, 147, 208, 80, 95, 139, 80, 126, 28, 108, 70, 63, 149, 209, 125, 170, 0, 54, 60, 96, 64, 235, 29, 43, 118, 80, 223, 109, 172, 121, 10, 193, 18, 51, 201, 217, 45, 35, 246, 74, 155, 177, 13, 172, 28, 62, 89, 3, 61, 95, 105, 57, 82, 187, 42, 197, 45, 39, 233, 219, 115, 59, 50, 140, 6, 11 }, "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 8, 5, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", new byte[] { 248, 199, 189, 22, 217, 155, 1, 171, 246, 175, 159, 49, 118, 240, 114, 53, 225, 128, 253, 250, 245, 89, 91, 229, 167, 83, 138, 155, 94, 86, 222, 75, 182, 234, 19, 157, 63, 143, 92, 166, 215, 255, 241, 152, 101, 237, 248, 231, 224, 209, 154, 170, 15, 112, 59, 32, 167, 51, 130, 188, 144, 144, 75, 175 }, new byte[] { 115, 90, 56, 163, 252, 34, 113, 163, 78, 2, 188, 170, 245, 19, 191, 153, 71, 18, 39, 142, 51, 137, 143, 243, 85, 120, 186, 156, 3, 169, 192, 155, 64, 181, 59, 77, 236, 149, 188, 89, 26, 175, 147, 120, 227, 84, 181, 23, 235, 12, 192, 34, 2, 73, 136, 7, 234, 229, 43, 152, 9, 168, 139, 236, 58, 8, 248, 99, 158, 206, 137, 187, 210, 254, 73, 137, 236, 194, 78, 226, 147, 187, 115, 163, 56, 154, 175, 24, 70, 141, 163, 230, 14, 68, 234, 49, 63, 229, 190, 66, 118, 179, 110, 157, 213, 205, 104, 28, 232, 20, 247, 243, 223, 151, 67, 247, 215, 102, 201, 134, 167, 242, 225, 70, 132, 123, 140, 177 }, "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 9, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", new byte[] { 220, 150, 250, 61, 78, 227, 203, 140, 166, 233, 1, 3, 199, 48, 202, 1, 84, 113, 215, 24, 152, 106, 49, 166, 100, 204, 115, 173, 48, 35, 233, 25, 111, 20, 176, 248, 49, 210, 16, 162, 161, 253, 12, 154, 208, 124, 19, 108, 123, 90, 18, 158, 52, 217, 132, 28, 221, 205, 40, 149, 83, 31, 74, 106 }, new byte[] { 102, 131, 254, 208, 58, 123, 210, 15, 159, 215, 220, 214, 160, 59, 2, 56, 100, 121, 93, 130, 103, 45, 229, 32, 126, 148, 138, 89, 57, 84, 244, 52, 197, 92, 168, 177, 159, 66, 48, 203, 249, 154, 140, 34, 254, 189, 154, 57, 141, 220, 125, 149, 247, 44, 9, 154, 195, 110, 194, 61, 94, 154, 143, 133, 238, 249, 164, 92, 21, 1, 36, 88, 27, 8, 110, 222, 91, 232, 31, 252, 60, 44, 59, 20, 129, 60, 106, 213, 116, 100, 228, 76, 47, 46, 68, 8, 18, 219, 150, 110, 223, 37, 228, 188, 19, 32, 74, 121, 99, 74, 86, 18, 218, 191, 90, 146, 60, 156, 40, 88, 42, 96, 186, 121, 66, 0, 135, 71 }, "0123456789", 2, 3 }
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
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
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
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 7);

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

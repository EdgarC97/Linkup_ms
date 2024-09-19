using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linkup_ms.Migrations
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
                    { 2, "español" },
                    { 3, "francés" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
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
                    { 2, "resolución de problemas" },
                    { 3, "liderazgo" }
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
                    { 1, "java" },
                    { 2, "c#" },
                    { 3, "nextJs" },
                    { 4, "nodeJs" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
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
                    { 1, new DateTime(1997, 5, 22, 1, 17, 51, 0, DateTimeKind.Utc), 1, "desarrollador de software con experiencia en diseño de soluciones digitales, modelado de datos y metodologías ágiles. me destaco en resolver problemas complejos y en comunicación efectiva.", 1, "edgar cardona", "https://media.licdn.com/dms/image/v2/D4E03AQH22ztGRhoM2g/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1677008729241?e=1731542400&v=beta&t=89RVHJpVnq8_m5ObsEU3CEs0KVrBraYI4gGWdIEuXEM" },
                    { 2, new DateTime(2006, 9, 30, 1, 17, 51, 0, DateTimeKind.Utc), 2, "desarrollador backend con aptitudes en c#, .net. especializado en aplicaciones del servidor e integración de api. buen trabajo en equipo y solucion de problemas", 1, "nicolas martinez", "https://avatars.githubusercontent.com/u/164014608?v=4" },
                    { 3, new DateTime(1995, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), 2, "actualmente, aprendo y aplico .net, typescript, react, next.js y sql, desarrollando habilidades en aplicaciones web y manejo de bases de datos.", 1, "brayan acosta", "https://media.licdn.com/dms/image/v2/C4D03AQHAwWzaQDI6gw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1641180503207?e=1731542400&v=beta&t=A7lWrZBzJ84ZlLdFsvKA73tbZKdP1vfPGuvf3Ah6XH4" },
                    { 4, new DateTime(2003, 7, 18, 1, 17, 51, 0, DateTimeKind.Utc), 3, "apasionado por crear y resolver problemas. me encanta aprender y enfrentar desafíos, compartir conocimientos y desarrollar soluciones innovadoras que impacten positivamente.", 1, "jose barreto", "https://media.licdn.com/dms/image/v2/D4E03AQEqn-8BGpvfaw/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1724345138906?e=1731542400&v=beta&t=wWL1nKrccb9DfJVg8Dz6v49L3AIpunv8gkovi5BpqgQ" },
                    { 5, new DateTime(2002, 11, 5, 1, 17, 51, 0, DateTimeKind.Utc), 4, "desarrollador frontend con experiencia en react, typescript y next.js, creando aplicaciones web seguras, eficientes y con arquitectura modular.", 1, "juan arias", "https://media.licdn.com/dms/image/v2/D4E03AQGXb8dGisr-wQ/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1724327950529?e=1731542400&v=beta&t=uCMHF7cJT2SfM-4acPddFycPWzAUYFWYr_WofvG2Cf8" },
                    { 6, new DateTime(1997, 2, 28, 1, 17, 51, 0, DateTimeKind.Utc), 1, "científico de datos en aprendizaje automático y análisis de datos. experto en python, r y visualización de datos.", 1, "juan rojas", "https://media.licdn.com/dms/image/v2/D4E03AQGyhYNRLL9edg/profile-displayphoto-shrink_200_200/profile-displayphoto-shrink_200_200/0/1681701914743?e=1731542400&v=beta&t=0aYfJifoDREE5dhY4dCSD8IECOotdQqJ5HwtLfAKkxw" },
                    { 7, new DateTime(1994, 6, 12, 1, 17, 51, 0, DateTimeKind.Utc), 4, "especialista en seguridad informática con experiencia en hacking ético y auditorías de seguridad de sistemas y datos.", 2, "ava martinez", "https://tse1.mm.bing.net/th?id=OIG4.KgiAsoOxSdFdiFJvih.W&pid=ImgGn" },
                    { 8, new DateTime(1987, 10, 8, 1, 17, 51, 0, DateTimeKind.Utc), 1, "desarrollador de videojuegos en unity y unreal engine. especializado en crear experiencias inmersivas y entornos interactivos.", 2, "noah anderson", "https://tse3.mm.bing.net/th?id=OIG4.BdR6gNaEahI_dGinSr75&pid=ImgGn" },
                    { 9, new DateTime(1996, 4, 25, 1, 17, 51, 0, DateTimeKind.Utc), 2, "desarrolladora de blockchain con experiencia en ethereum y solidity para contratos inteligentes y aplicaciones descentralizadas.", 2, "isabella white", "https://tse1.mm.bing.net/th?id=OIG4.xpBYsldYYgGJy_7if8T1&pid=ImgGn" },
                    { 10, new DateTime(1990, 1, 15, 1, 17, 51, 0, DateTimeKind.Utc), 3, "desarrollador full-stack con experiencia en javascript, node.js y frameworks web modernos. experto en desarrollo cliente y servidor.", 1, "alex johnson", "https://tse4.mm.bing.net/th?id=OIG3.zDCj3kinyaUjd0kHGTbh&pid=ImgGn" },
                    { 11, new DateTime(1992, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), 1, "ingeniera de software con experiencia en java y spring boot. enfocada en construir aplicaciones web escalables y código limpio.", 2, "maria gomez", "https://tse4.mm.bing.net/th?id=OIG4..woi4PcXMJrWci3PHx.1&pid=ImgGn" },
                    { 12, new DateTime(1994, 8, 22, 1, 17, 51, 0, DateTimeKind.Utc), 2, "consultor devops con experiencia en automatización y servicios en la nube. experto en configurar pipelines ci/cd y gestionar infraestructura.", 1, "joseph kim", "https://tse2.mm.bing.net/th?id=OIG3.g2nXDL0zV1p0rTcvZOHY&pid=ImgGn" },
                    { 13, new DateTime(1989, 12, 30, 1, 17, 51, 0, DateTimeKind.Utc), 3, "diseñadora de productos con experiencia en investigación de usuarios y prototipado. experta en usabilidad y sistemas de diseño.", 1, "elena rodriguez", "https://tse1.mm.bing.net/th?id=OIG4.cxyneb3Z34jIy_OLnI45&pid=ImgGn" },
                    { 14, new DateTime(1995, 11, 3, 1, 17, 51, 0, DateTimeKind.Utc), 4, "desarrollador backend especializado en arquitectura de microservicios y desarrollo de api en java y spring cloud.", 1, "luis fernandez", "https://tse4.mm.bing.net/th?id=OIG3.qynXeqPsRs8Lov_9_gIi&pid=ImgGn" },
                    { 15, new DateTime(1991, 5, 25, 1, 17, 51, 0, DateTimeKind.Utc), 1, "ingeniera front-end especializada en vue.js y diseño responsivo. experta en crear aplicaciones web dinámicas y accesibles.", 2, "natalie o'connor", "https://tse1.mm.bing.net/th?id=OIG4.wzqtcIUhErA8sGbNbu76&pid=ImgGn" },
                    { 16, new DateTime(1990, 9, 17, 1, 17, 51, 0, DateTimeKind.Utc), 2, "analista de datos con habilidades en sql y herramientas de visualización como tableau. experto en extraer insights para decisiones.", 1, "damian lee", "https://tse1.mm.bing.net/th?id=OIG3.5zeLHiPCO7K2Mh8UZoUG&pid=ImgGn" },
                    { 17, new DateTime(1993, 4, 9, 1, 17, 51, 0, DateTimeKind.Utc), 3, "investigadora en inteligencia artificial con foco en procesamiento de lenguaje natural y algoritmos de aprendizaje automático.", 2, "zoe wilson", "https://tse4.mm.bing.net/th?id=OIG4.dyXC5j5LkJq0TE_mtSMA&pid=ImgGn" },
                    { 18, new DateTime(1988, 11, 18, 1, 17, 51, 0, DateTimeKind.Utc), 4, "administrador de sistemas con experiencia en seguridad de redes y gestión de servidores a gran escala.", 1, "omar harris", "https://tse3.mm.bing.net/th?id=OIG3.cKPpvOrNYcEWjI.dS6vw&pid=ImgGn" },
                    { 19, new DateTime(1996, 6, 21, 1, 17, 51, 0, DateTimeKind.Utc), 1, "desarrolladora web especializada en front-end y diseño ux. experta en crear sitios web dinámicos y mejorar la experiencia del usuario.", 2, "julia patel", "https://tse2.mm.bing.net/th?id=OIG4.co0F_z3mYCkQ.RjY69sX&pid=ImgGn" },
                    { 20, new DateTime(1992, 12, 2, 1, 17, 51, 0, DateTimeKind.Utc), 2, "ingeniero en la nube con experiencia en aws y azure. experto en diseñar soluciones y optimizar infraestructura en la nube.", 1, "antonio martinez", "https://tse3.mm.bing.net/th?id=OIG3.YXT9SEBhS2aviUM5zMrC&pid=ImgGn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsConfirmed", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleId", "SectorId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", new byte[] { 44, 171, 159, 44, 156, 146, 238, 206, 247, 206, 239, 138, 17, 252, 0, 244, 162, 233, 91, 151, 100, 164, 83, 91, 185, 25, 79, 73, 111, 146, 37, 185, 30, 193, 61, 0, 62, 51, 9, 234, 134, 89, 15, 168, 183, 44, 73, 15, 143, 91, 161, 50, 157, 19, 89, 243, 46, 134, 202, 226, 184, 131, 199, 110 }, new byte[] { 66, 231, 24, 97, 175, 131, 79, 41, 115, 69, 123, 84, 168, 172, 102, 248, 7, 133, 197, 112, 161, 99, 48, 200, 122, 203, 142, 103, 190, 17, 99, 188, 43, 78, 100, 126, 120, 157, 64, 37, 240, 127, 218, 79, 82, 12, 182, 139, 171, 164, 33, 17, 253, 152, 2, 183, 5, 229, 4, 150, 25, 152, 13, 138, 105, 154, 163, 92, 87, 248, 78, 181, 170, 82, 253, 251, 157, 203, 11, 127, 82, 228, 149, 222, 75, 149, 37, 222, 157, 89, 214, 158, 188, 95, 145, 68, 36, 1, 21, 125, 153, 11, 42, 140, 165, 233, 83, 26, 123, 234, 72, 56, 149, 202, 90, 114, 75, 20, 172, 204, 60, 146, 114, 145, 76, 135, 21, 248 }, "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", new byte[] { 101, 169, 95, 216, 251, 72, 143, 130, 60, 130, 181, 101, 65, 216, 197, 86, 219, 86, 61, 190, 81, 199, 197, 153, 158, 230, 196, 132, 30, 161, 227, 17, 76, 92, 200, 172, 201, 13, 26, 154, 162, 152, 2, 156, 239, 156, 212, 83, 228, 81, 117, 174, 244, 181, 8, 77, 13, 26, 156, 100, 124, 76, 103, 53 }, new byte[] { 83, 182, 231, 130, 248, 37, 193, 182, 29, 245, 203, 97, 176, 169, 30, 176, 185, 42, 243, 225, 219, 91, 240, 14, 23, 53, 76, 172, 207, 19, 216, 138, 126, 104, 250, 197, 124, 94, 115, 74, 108, 85, 237, 102, 93, 156, 94, 69, 240, 54, 214, 125, 127, 66, 2, 90, 207, 82, 114, 27, 82, 201, 15, 253, 234, 179, 7, 57, 194, 197, 49, 25, 84, 2, 114, 163, 123, 22, 224, 230, 210, 162, 236, 60, 117, 204, 212, 240, 85, 179, 109, 11, 241, 191, 179, 122, 82, 116, 91, 29, 191, 51, 21, 122, 49, 120, 66, 189, 143, 253, 249, 184, 239, 246, 67, 72, 196, 133, 115, 81, 124, 239, 65, 167, 30, 216, 9, 180 }, "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 7, 20, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", new byte[] { 196, 103, 90, 134, 226, 8, 5, 150, 67, 46, 47, 198, 241, 229, 26, 90, 1, 211, 50, 179, 122, 242, 92, 238, 173, 29, 6, 231, 180, 239, 100, 135, 162, 99, 67, 227, 60, 240, 77, 137, 24, 42, 142, 48, 141, 167, 121, 52, 204, 252, 183, 237, 51, 190, 142, 125, 70, 237, 41, 101, 192, 2, 76, 101 }, new byte[] { 78, 18, 61, 68, 22, 194, 119, 122, 246, 56, 123, 243, 178, 158, 107, 114, 29, 193, 32, 177, 123, 162, 46, 64, 156, 114, 131, 4, 113, 33, 164, 141, 196, 161, 127, 101, 31, 111, 133, 161, 91, 52, 190, 49, 191, 220, 187, 236, 172, 148, 209, 173, 138, 14, 196, 148, 76, 113, 225, 51, 32, 151, 156, 90, 10, 240, 210, 51, 105, 205, 115, 234, 213, 48, 62, 175, 201, 65, 75, 239, 212, 93, 245, 30, 83, 203, 98, 219, 178, 22, 156, 145, 110, 251, 29, 19, 47, 183, 116, 209, 36, 140, 244, 61, 203, 107, 228, 78, 80, 170, 23, 192, 61, 177, 81, 33, 67, 59, 127, 29, 115, 59, 188, 170, 226, 8, 4, 120 }, "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 6, 1, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", new byte[] { 254, 178, 250, 153, 82, 131, 7, 140, 187, 49, 163, 187, 49, 84, 40, 142, 132, 128, 134, 111, 137, 219, 158, 184, 27, 5, 2, 254, 118, 251, 168, 168, 220, 253, 156, 219, 234, 150, 12, 123, 189, 208, 59, 230, 43, 200, 40, 61, 137, 68, 38, 131, 237, 90, 21, 20, 90, 53, 208, 148, 132, 96, 21, 76 }, new byte[] { 199, 30, 132, 251, 29, 122, 190, 99, 248, 84, 72, 206, 59, 253, 69, 153, 28, 153, 60, 205, 119, 126, 247, 187, 65, 71, 0, 205, 153, 224, 131, 75, 61, 52, 110, 131, 241, 9, 62, 200, 42, 16, 192, 143, 220, 208, 190, 61, 113, 171, 225, 144, 215, 183, 203, 124, 160, 95, 232, 71, 228, 38, 13, 82, 208, 159, 162, 49, 17, 239, 186, 109, 211, 46, 96, 132, 80, 237, 125, 95, 108, 96, 80, 31, 185, 77, 227, 243, 19, 54, 122, 52, 65, 123, 16, 75, 157, 253, 244, 28, 12, 145, 170, 112, 235, 37, 78, 131, 119, 129, 164, 81, 94, 51, 187, 198, 138, 161, 96, 120, 162, 61, 243, 87, 142, 177, 62, 151 }, "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 5, 15, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", new byte[] { 193, 28, 32, 51, 0, 244, 196, 60, 89, 204, 50, 93, 103, 68, 206, 192, 60, 192, 80, 238, 123, 111, 167, 229, 175, 83, 179, 221, 79, 209, 138, 84, 198, 21, 188, 85, 106, 45, 20, 119, 7, 92, 230, 203, 0, 156, 16, 101, 127, 8, 34, 207, 222, 199, 86, 135, 100, 75, 56, 68, 229, 226, 206, 202 }, new byte[] { 4, 7, 0, 103, 186, 62, 136, 89, 76, 235, 35, 91, 246, 66, 11, 190, 150, 214, 113, 160, 232, 206, 59, 231, 198, 194, 171, 5, 7, 145, 24, 165, 236, 42, 207, 24, 242, 47, 132, 217, 72, 69, 155, 227, 41, 48, 22, 44, 103, 16, 47, 39, 231, 189, 186, 177, 27, 59, 174, 164, 96, 0, 103, 193, 7, 9, 169, 56, 170, 0, 4, 172, 212, 117, 247, 39, 116, 38, 211, 248, 124, 106, 32, 153, 161, 83, 41, 192, 137, 188, 223, 203, 224, 175, 185, 196, 115, 53, 107, 47, 113, 27, 187, 210, 214, 231, 51, 157, 100, 17, 166, 193, 25, 70, 141, 56, 5, 42, 188, 111, 175, 60, 129, 234, 76, 189, 173, 180 }, "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 5, 25, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", new byte[] { 0, 105, 4, 169, 178, 82, 213, 82, 89, 208, 160, 148, 127, 110, 35, 203, 39, 33, 117, 156, 1, 177, 147, 238, 206, 82, 65, 54, 11, 12, 84, 204, 50, 1, 188, 60, 133, 82, 160, 156, 191, 236, 69, 108, 222, 36, 150, 134, 10, 21, 100, 185, 219, 226, 129, 151, 84, 106, 113, 251, 20, 108, 161, 199 }, new byte[] { 239, 68, 4, 101, 40, 216, 203, 103, 1, 114, 196, 198, 52, 60, 145, 43, 202, 169, 63, 13, 251, 30, 189, 219, 73, 123, 5, 132, 135, 24, 195, 233, 180, 205, 177, 208, 139, 17, 210, 54, 124, 125, 166, 121, 88, 94, 65, 224, 42, 67, 31, 11, 3, 105, 66, 69, 187, 141, 119, 244, 79, 246, 69, 237, 50, 89, 73, 194, 214, 38, 39, 111, 214, 34, 31, 185, 210, 236, 238, 77, 2, 78, 9, 216, 69, 32, 164, 79, 152, 71, 194, 42, 198, 211, 165, 204, 129, 192, 68, 205, 45, 171, 193, 139, 94, 223, 183, 98, 65, 51, 225, 146, 127, 188, 116, 117, 127, 98, 254, 239, 97, 97, 45, 146, 105, 90, 202, 218 }, "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 9, 1, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", new byte[] { 231, 227, 98, 244, 117, 195, 13, 242, 53, 236, 32, 45, 228, 245, 23, 158, 53, 123, 229, 227, 38, 15, 223, 144, 53, 46, 196, 107, 113, 86, 138, 117, 66, 30, 130, 138, 124, 58, 163, 39, 161, 95, 160, 145, 80, 56, 50, 149, 248, 31, 166, 185, 181, 253, 135, 186, 115, 73, 96, 147, 33, 197, 182, 16 }, new byte[] { 93, 7, 249, 155, 49, 237, 228, 174, 39, 184, 223, 209, 96, 217, 104, 163, 24, 100, 249, 224, 224, 195, 88, 253, 32, 48, 111, 218, 23, 220, 78, 244, 188, 231, 178, 47, 122, 251, 28, 30, 227, 249, 131, 232, 207, 28, 37, 26, 98, 139, 130, 102, 156, 12, 120, 32, 32, 230, 254, 154, 35, 82, 20, 7, 121, 65, 159, 251, 10, 181, 77, 244, 229, 228, 36, 234, 50, 217, 29, 242, 185, 122, 87, 85, 134, 48, 240, 160, 189, 211, 199, 10, 254, 106, 76, 246, 88, 48, 75, 11, 126, 97, 122, 108, 77, 139, 147, 195, 68, 137, 132, 217, 137, 225, 105, 200, 16, 110, 147, 130, 17, 91, 216, 64, 54, 217, 233, 15 }, "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 6, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", new byte[] { 183, 157, 38, 184, 170, 218, 149, 171, 112, 55, 202, 203, 45, 191, 250, 40, 198, 204, 175, 73, 11, 117, 78, 181, 205, 107, 251, 122, 255, 1, 230, 36, 187, 152, 33, 184, 160, 238, 129, 80, 130, 113, 23, 182, 68, 230, 167, 42, 90, 140, 254, 150, 59, 60, 202, 3, 4, 234, 205, 93, 99, 207, 15, 28 }, new byte[] { 232, 251, 134, 46, 105, 203, 250, 177, 69, 37, 129, 252, 40, 133, 81, 215, 175, 200, 186, 245, 143, 173, 241, 55, 104, 138, 10, 25, 148, 64, 187, 145, 59, 65, 134, 205, 229, 101, 14, 61, 164, 34, 74, 35, 3, 216, 225, 54, 181, 37, 217, 136, 25, 242, 181, 120, 170, 118, 73, 105, 43, 148, 222, 174, 170, 185, 14, 69, 45, 121, 23, 134, 173, 48, 115, 153, 252, 172, 117, 246, 206, 95, 179, 183, 194, 16, 130, 163, 178, 1, 79, 51, 111, 213, 213, 76, 243, 251, 207, 149, 254, 142, 172, 151, 176, 64, 172, 70, 83, 56, 148, 125, 143, 2, 129, 137, 187, 69, 95, 22, 83, 165, 1, 10, 130, 147, 240, 226 }, "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", new byte[] { 152, 109, 249, 98, 180, 101, 20, 246, 51, 80, 232, 60, 158, 37, 151, 198, 246, 20, 126, 236, 170, 44, 236, 35, 243, 65, 5, 38, 53, 128, 88, 235, 134, 207, 86, 149, 200, 138, 232, 204, 8, 164, 165, 13, 151, 104, 117, 140, 58, 27, 204, 95, 166, 201, 154, 137, 89, 82, 8, 234, 46, 191, 127, 246 }, new byte[] { 111, 73, 155, 150, 145, 213, 231, 209, 115, 7, 157, 105, 61, 132, 94, 46, 76, 43, 93, 159, 54, 254, 236, 99, 85, 178, 134, 132, 202, 227, 202, 159, 89, 165, 85, 236, 118, 56, 111, 139, 134, 54, 129, 186, 50, 3, 179, 83, 240, 112, 202, 145, 77, 248, 69, 129, 171, 55, 121, 177, 243, 178, 245, 98, 144, 208, 5, 107, 215, 104, 174, 167, 101, 40, 148, 57, 142, 68, 80, 58, 205, 221, 134, 160, 126, 118, 140, 83, 244, 220, 172, 147, 255, 138, 179, 24, 130, 30, 216, 224, 100, 20, 33, 212, 232, 197, 54, 244, 17, 71, 246, 30, 191, 62, 74, 109, 11, 145, 134, 195, 44, 54, 251, 7, 160, 30, 164, 210 }, "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 5, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", new byte[] { 135, 241, 44, 102, 121, 197, 231, 119, 10, 149, 56, 23, 227, 161, 211, 45, 125, 124, 227, 111, 116, 158, 244, 194, 118, 140, 86, 215, 248, 201, 199, 184, 77, 158, 218, 70, 162, 91, 200, 139, 190, 104, 8, 37, 219, 74, 21, 25, 182, 187, 68, 149, 221, 73, 123, 235, 254, 226, 193, 185, 11, 165, 240, 149 }, new byte[] { 117, 90, 71, 67, 145, 90, 161, 193, 154, 67, 56, 17, 111, 26, 178, 72, 228, 144, 51, 246, 143, 113, 54, 214, 229, 175, 139, 132, 44, 126, 80, 91, 15, 193, 176, 54, 34, 206, 164, 216, 192, 232, 88, 241, 195, 213, 137, 184, 204, 252, 106, 151, 196, 219, 178, 175, 10, 194, 182, 88, 247, 97, 85, 49, 138, 200, 184, 178, 250, 0, 40, 202, 135, 81, 2, 83, 156, 197, 36, 117, 27, 138, 6, 113, 100, 201, 223, 93, 28, 90, 187, 165, 49, 28, 10, 168, 3, 140, 157, 205, 129, 39, 100, 161, 20, 233, 192, 108, 153, 67, 156, 204, 197, 31, 88, 17, 246, 171, 220, 148, 104, 84, 225, 134, 218, 52, 205, 131 }, "0123456789", 2, 3 },
                    { 11, new DateTime(2024, 8, 10, 1, 17, 51, 0, DateTimeKind.Utc), "isaac.lewis@example.com", true, "isaac lewis", new byte[] { 131, 170, 50, 176, 113, 97, 235, 91, 77, 86, 88, 182, 58, 194, 64, 155, 99, 139, 50, 67, 197, 252, 215, 135, 96, 104, 88, 212, 78, 17, 191, 201, 196, 54, 73, 224, 158, 65, 176, 155, 84, 37, 239, 255, 104, 220, 44, 250, 17, 80, 23, 99, 57, 50, 38, 155, 212, 148, 132, 75, 238, 74, 217, 115 }, new byte[] { 177, 209, 111, 120, 32, 13, 119, 178, 249, 88, 3, 9, 149, 102, 20, 164, 41, 26, 161, 91, 51, 202, 33, 132, 63, 108, 142, 230, 46, 35, 167, 119, 90, 83, 60, 216, 172, 5, 139, 50, 202, 25, 242, 12, 67, 101, 250, 210, 138, 98, 47, 141, 194, 153, 149, 59, 247, 45, 23, 101, 28, 35, 196, 86, 0, 172, 66, 150, 199, 88, 156, 84, 3, 31, 90, 80, 193, 110, 254, 141, 44, 109, 211, 76, 38, 207, 155, 0, 47, 146, 151, 193, 148, 239, 3, 129, 110, 255, 45, 10, 199, 121, 77, 142, 84, 6, 137, 9, 251, 159, 185, 181, 250, 184, 211, 182, 63, 58, 95, 82, 180, 224, 184, 115, 131, 69, 190, 114 }, "1234567891", 2, 2 },
                    { 12, new DateTime(2024, 6, 20, 1, 17, 51, 0, DateTimeKind.Utc), "julia.martinez@example.com", true, "julia martinez", new byte[] { 108, 215, 8, 196, 122, 18, 144, 3, 174, 129, 31, 155, 30, 60, 242, 148, 61, 113, 8, 169, 216, 252, 76, 92, 167, 66, 200, 123, 165, 42, 173, 143, 210, 181, 82, 34, 252, 52, 66, 142, 124, 217, 168, 192, 35, 197, 41, 144, 101, 242, 161, 246, 53, 165, 33, 243, 183, 194, 218, 178, 66, 188, 205, 24 }, new byte[] { 231, 73, 159, 157, 151, 127, 133, 10, 95, 6, 64, 114, 246, 15, 93, 162, 100, 169, 155, 146, 16, 26, 50, 122, 50, 100, 166, 157, 19, 56, 0, 4, 227, 57, 49, 203, 154, 234, 3, 177, 130, 251, 223, 43, 138, 46, 167, 243, 33, 182, 195, 81, 2, 94, 225, 221, 36, 28, 41, 73, 19, 212, 68, 222, 23, 135, 30, 116, 144, 146, 118, 5, 61, 99, 170, 149, 128, 179, 119, 163, 58, 117, 225, 45, 43, 26, 231, 197, 217, 252, 42, 24, 32, 248, 10, 127, 238, 98, 130, 33, 108, 226, 14, 162, 113, 198, 176, 83, 157, 194, 205, 187, 202, 75, 132, 114, 25, 222, 15, 228, 138, 211, 157, 192, 19, 201, 17, 238 }, "2345678902", 2, 4 },
                    { 13, new DateTime(2024, 7, 1, 1, 17, 51, 0, DateTimeKind.Utc), "kyle.wilson@example.com", true, "kyle wilson", new byte[] { 143, 145, 247, 244, 17, 232, 137, 15, 108, 72, 162, 61, 28, 9, 51, 83, 150, 39, 109, 168, 133, 251, 26, 86, 97, 104, 39, 128, 254, 153, 28, 212, 251, 184, 114, 142, 120, 213, 198, 131, 79, 10, 196, 183, 252, 8, 148, 1, 235, 92, 81, 138, 101, 75, 118, 27, 175, 87, 53, 41, 8, 200, 239, 82 }, new byte[] { 249, 178, 8, 144, 42, 95, 68, 29, 127, 77, 137, 162, 21, 118, 249, 128, 188, 198, 190, 234, 179, 40, 77, 128, 152, 188, 33, 128, 184, 233, 138, 165, 181, 33, 216, 78, 49, 157, 173, 103, 82, 74, 234, 241, 16, 60, 184, 62, 148, 123, 68, 86, 78, 119, 246, 213, 92, 205, 22, 159, 176, 84, 57, 155, 234, 103, 217, 105, 144, 234, 218, 158, 98, 233, 17, 35, 119, 216, 40, 221, 152, 165, 168, 135, 229, 43, 45, 241, 83, 183, 123, 75, 10, 122, 79, 222, 167, 176, 50, 243, 240, 155, 145, 217, 208, 188, 81, 51, 12, 150, 55, 52, 62, 206, 158, 190, 212, 234, 237, 165, 163, 90, 243, 92, 54, 183, 247, 91 }, "3456789013", 2, 5 },
                    { 14, new DateTime(2024, 9, 10, 1, 17, 51, 0, DateTimeKind.Utc), "laura.johnson@example.com", true, "laura johnson", new byte[] { 90, 238, 53, 111, 84, 230, 116, 140, 129, 169, 123, 126, 87, 70, 11, 204, 210, 168, 208, 130, 237, 214, 233, 54, 132, 86, 166, 241, 44, 191, 232, 1, 165, 55, 195, 190, 167, 141, 6, 91, 40, 189, 102, 30, 65, 231, 163, 130, 43, 164, 55, 11, 196, 168, 228, 15, 151, 25, 209, 220, 66, 103, 35, 116 }, new byte[] { 219, 157, 51, 22, 75, 238, 89, 240, 191, 218, 3, 240, 146, 21, 91, 124, 59, 41, 100, 189, 9, 28, 90, 245, 73, 154, 244, 218, 68, 22, 184, 168, 217, 100, 238, 227, 252, 22, 18, 229, 19, 98, 59, 12, 217, 225, 115, 172, 51, 131, 127, 103, 185, 42, 28, 120, 19, 158, 136, 133, 112, 214, 88, 72, 194, 43, 97, 137, 165, 159, 100, 133, 45, 144, 164, 93, 152, 22, 78, 236, 221, 171, 53, 149, 196, 10, 32, 94, 243, 113, 6, 233, 133, 44, 106, 184, 66, 25, 179, 234, 95, 67, 9, 89, 109, 57, 192, 143, 79, 170, 135, 2, 181, 181, 40, 195, 124, 237, 19, 126, 185, 5, 231, 93, 246, 163, 227, 54 }, "4567890124", 2, 1 },
                    { 15, new DateTime(2024, 7, 20, 1, 17, 51, 0, DateTimeKind.Utc), "michael.brown@example.com", true, "michael brown", new byte[] { 212, 38, 190, 23, 111, 95, 132, 233, 44, 9, 161, 101, 189, 54, 78, 220, 171, 206, 55, 29, 59, 49, 144, 13, 6, 176, 162, 174, 91, 99, 135, 132, 77, 86, 31, 162, 123, 236, 195, 193, 229, 235, 88, 138, 201, 232, 135, 175, 201, 65, 154, 145, 200, 184, 132, 96, 198, 84, 77, 90, 147, 244, 136, 250 }, new byte[] { 197, 105, 0, 80, 56, 45, 50, 207, 72, 203, 194, 92, 205, 174, 98, 52, 55, 130, 204, 238, 21, 178, 235, 35, 250, 209, 108, 89, 214, 170, 137, 19, 152, 234, 76, 207, 10, 85, 17, 80, 201, 87, 31, 106, 151, 203, 59, 161, 54, 200, 192, 239, 47, 143, 253, 81, 80, 60, 211, 235, 166, 182, 247, 42, 69, 68, 36, 16, 178, 94, 152, 230, 185, 24, 115, 19, 140, 28, 78, 202, 20, 224, 90, 235, 170, 205, 2, 202, 169, 189, 10, 74, 22, 216, 76, 8, 224, 242, 214, 97, 74, 99, 110, 240, 251, 140, 89, 216, 150, 53, 119, 199, 117, 161, 108, 220, 81, 218, 4, 25, 13, 4, 23, 182, 167, 226, 147, 77 }, "5678901235", 2, 3 },
                    { 16, new DateTime(2024, 5, 1, 1, 17, 51, 0, DateTimeKind.Utc), "natalie.moore@example.com", true, "natalie moore", new byte[] { 95, 81, 249, 208, 95, 158, 18, 222, 38, 25, 178, 181, 212, 36, 176, 78, 220, 50, 255, 88, 103, 11, 209, 161, 252, 46, 135, 239, 55, 208, 122, 46, 248, 176, 44, 0, 178, 77, 61, 83, 197, 157, 53, 143, 88, 241, 136, 155, 18, 237, 99, 98, 89, 243, 204, 17, 166, 172, 237, 54, 134, 200, 161, 91 }, new byte[] { 10, 110, 51, 169, 151, 110, 103, 49, 34, 23, 139, 216, 219, 225, 111, 225, 17, 227, 222, 52, 146, 95, 170, 25, 174, 160, 241, 52, 93, 248, 61, 64, 51, 189, 35, 113, 53, 126, 64, 145, 231, 208, 217, 151, 44, 132, 82, 231, 118, 66, 15, 220, 126, 211, 50, 146, 202, 46, 123, 104, 126, 229, 30, 1, 232, 129, 120, 119, 123, 100, 197, 158, 139, 241, 166, 191, 183, 113, 38, 114, 22, 178, 190, 151, 220, 178, 235, 232, 41, 19, 62, 188, 184, 38, 242, 5, 159, 201, 158, 65, 2, 65, 148, 9, 118, 0, 191, 242, 34, 36, 185, 121, 247, 34, 197, 125, 40, 21, 138, 215, 199, 186, 1, 88, 73, 100, 207, 154 }, "6789012346", 2, 4 },
                    { 17, new DateTime(2024, 8, 10, 1, 17, 51, 0, DateTimeKind.Utc), "oliver.taylor@example.com", true, "oliver taylor", new byte[] { 1, 84, 209, 211, 110, 230, 36, 232, 214, 248, 93, 81, 188, 253, 110, 71, 83, 156, 131, 75, 178, 182, 101, 124, 4, 224, 112, 154, 214, 166, 189, 31, 59, 222, 69, 33, 19, 14, 186, 139, 108, 165, 52, 197, 171, 121, 208, 101, 32, 166, 190, 160, 40, 58, 178, 251, 166, 159, 250, 176, 80, 139, 136, 138 }, new byte[] { 100, 219, 120, 118, 227, 68, 162, 35, 53, 71, 146, 239, 101, 74, 88, 74, 117, 28, 27, 64, 203, 138, 152, 114, 39, 42, 30, 183, 33, 48, 47, 248, 164, 101, 20, 78, 217, 98, 248, 17, 15, 234, 35, 139, 194, 128, 43, 191, 248, 226, 246, 246, 13, 101, 225, 241, 246, 94, 226, 96, 141, 40, 192, 102, 108, 212, 224, 170, 102, 206, 56, 126, 237, 116, 156, 231, 255, 63, 132, 189, 153, 77, 151, 234, 171, 231, 214, 191, 216, 214, 149, 98, 189, 109, 69, 87, 225, 142, 136, 214, 135, 140, 80, 98, 74, 99, 139, 210, 40, 95, 188, 158, 142, 161, 117, 125, 78, 204, 174, 55, 16, 10, 219, 255, 168, 207, 42, 88 }, "7890123457", 2, 5 },
                    { 18, new DateTime(2024, 8, 20, 1, 17, 51, 0, DateTimeKind.Utc), "penelope.anderson@example.com", true, "penelope anderson", new byte[] { 78, 232, 196, 75, 52, 134, 108, 62, 247, 192, 35, 99, 150, 253, 94, 95, 164, 37, 189, 199, 43, 206, 186, 14, 227, 98, 116, 106, 59, 6, 124, 148, 240, 2, 92, 206, 222, 53, 35, 111, 1, 82, 179, 4, 65, 79, 45, 206, 189, 194, 115, 12, 131, 74, 8, 162, 197, 79, 223, 9, 19, 233, 172, 183 }, new byte[] { 171, 223, 247, 125, 193, 169, 38, 11, 125, 200, 252, 225, 7, 59, 210, 241, 55, 107, 136, 136, 246, 156, 141, 44, 247, 42, 166, 202, 126, 18, 62, 233, 99, 107, 176, 50, 101, 118, 1, 38, 32, 168, 45, 246, 203, 105, 254, 8, 237, 201, 225, 53, 55, 208, 193, 51, 249, 33, 94, 17, 34, 248, 190, 2, 230, 146, 4, 121, 101, 185, 29, 80, 62, 244, 143, 107, 243, 56, 4, 110, 99, 81, 211, 167, 71, 43, 166, 61, 212, 234, 254, 56, 70, 26, 181, 186, 24, 156, 40, 83, 252, 188, 111, 135, 182, 171, 71, 18, 12, 67, 254, 192, 171, 172, 126, 119, 192, 189, 58, 166, 223, 99, 70, 58, 132, 73, 22, 190 }, "8901234568", 2, 2 },
                    { 19, new DateTime(2024, 8, 1, 1, 17, 51, 0, DateTimeKind.Utc), "quinn.harris@example.com", true, "quinn harris", new byte[] { 1, 175, 185, 56, 62, 15, 165, 182, 75, 132, 114, 76, 170, 172, 0, 251, 88, 170, 109, 116, 127, 79, 63, 208, 131, 34, 37, 33, 153, 141, 232, 12, 107, 210, 12, 64, 27, 168, 255, 37, 183, 177, 248, 9, 248, 169, 253, 188, 21, 125, 148, 68, 104, 82, 168, 213, 217, 43, 55, 71, 115, 145, 107, 209 }, new byte[] { 142, 2, 247, 167, 216, 40, 99, 205, 110, 106, 172, 53, 146, 103, 36, 251, 61, 4, 163, 24, 221, 166, 138, 194, 243, 205, 3, 81, 108, 36, 82, 250, 209, 95, 31, 228, 233, 156, 19, 246, 68, 108, 134, 58, 184, 162, 170, 123, 22, 161, 156, 104, 247, 195, 246, 226, 155, 63, 15, 34, 51, 195, 7, 64, 74, 75, 219, 57, 113, 162, 3, 169, 129, 217, 213, 197, 181, 203, 184, 18, 122, 238, 44, 149, 89, 42, 189, 69, 109, 157, 174, 34, 135, 203, 70, 223, 145, 18, 24, 218, 78, 185, 16, 49, 111, 172, 20, 134, 170, 154, 135, 244, 162, 172, 16, 34, 151, 221, 86, 93, 134, 202, 212, 11, 8, 207, 188, 161 }, "9012345679", 2, 3 },
                    { 20, new DateTime(2024, 9, 15, 1, 17, 51, 0, DateTimeKind.Utc), "rachel.scott@example.com", true, "rachel scott", new byte[] { 207, 214, 135, 202, 137, 29, 75, 199, 58, 116, 55, 48, 84, 165, 36, 46, 205, 88, 99, 191, 101, 224, 212, 102, 62, 48, 213, 237, 136, 69, 50, 37, 125, 146, 149, 223, 186, 202, 105, 212, 153, 64, 213, 72, 118, 213, 175, 245, 32, 201, 213, 139, 14, 68, 53, 56, 231, 0, 190, 228, 28, 24, 149, 102 }, new byte[] { 213, 83, 152, 209, 116, 118, 56, 106, 118, 65, 62, 105, 29, 95, 81, 136, 192, 164, 9, 88, 42, 21, 243, 29, 167, 182, 108, 96, 37, 166, 59, 245, 156, 34, 79, 166, 235, 166, 73, 210, 222, 130, 53, 252, 148, 5, 43, 4, 24, 24, 193, 30, 67, 178, 79, 100, 91, 162, 207, 27, 9, 160, 155, 237, 104, 37, 209, 124, 241, 60, 197, 220, 185, 195, 212, 85, 23, 170, 58, 82, 186, 22, 124, 131, 157, 113, 214, 167, 88, 145, 13, 17, 15, 155, 114, 184, 29, 92, 251, 68, 57, 218, 4, 70, 134, 164, 211, 236, 120, 219, 123, 192, 208, 186, 157, 247, 136, 132, 124, 32, 58, 58, 126, 154, 124, 40, 135, 84 }, "0123456790", 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "CoderLanguages",
                columns: new[] { "Id", "CoderId", "LanguageId", "LanguageLevelId" },
                values: new object[,]
                {
                    { 1, 1, 1, 4 },
                    { 2, 1, 3, 1 },
                    { 3, 2, 2, 3 },
                    { 4, 3, 1, 2 },
                    { 5, 4, 3, 4 },
                    { 6, 5, 2, 5 },
                    { 7, 6, 1, 3 },
                    { 8, 7, 3, 2 },
                    { 9, 8, 2, 4 },
                    { 10, 9, 1, 5 },
                    { 11, 10, 2, 6 },
                    { 12, 11, 3, 1 },
                    { 13, 12, 1, 3 },
                    { 14, 13, 2, 5 },
                    { 15, 14, 3, 2 },
                    { 16, 15, 1, 4 },
                    { 17, 16, 2, 6 },
                    { 18, 17, 3, 3 },
                    { 19, 18, 1, 2 },
                    { 20, 19, 2, 5 },
                    { 21, 20, 3, 4 }
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
                    { 4, 1, 5 },
                    { 5, 2, 6 },
                    { 6, 3, 7 },
                    { 7, 1, 8 },
                    { 8, 2, 9 },
                    { 9, 3, 10 },
                    { 10, 1, 11 },
                    { 11, 2, 12 },
                    { 12, 3, 13 },
                    { 13, 1, 14 },
                    { 14, 2, 15 },
                    { 15, 3, 16 },
                    { 16, 1, 17 },
                    { 17, 2, 18 },
                    { 18, 3, 19 },
                    { 19, 1, 20 },
                    { 20, 2, 21 }
                });

            migrationBuilder.InsertData(
                table: "CoderTechnicalSkills",
                columns: new[] { "Id", "CoderId", "TechnicalSkillId", "TechnicalSkillLevelId" },
                values: new object[,]
                {
                    { 1, 1, 2, 1 },
                    { 2, 1, 3, 1 },
                    { 3, 2, 2, 1 },
                    { 4, 3, 1, 1 },
                    { 5, 4, 4, 1 },
                    { 6, 5, 3, 1 },
                    { 7, 6, 2, 1 },
                    { 8, 7, 1, 1 },
                    { 9, 8, 4, 1 },
                    { 10, 9, 1, 1 },
                    { 11, 10, 3, 1 },
                    { 12, 11, 2, 1 },
                    { 13, 12, 1, 1 },
                    { 14, 13, 4, 1 },
                    { 15, 14, 3, 1 },
                    { 16, 15, 2, 1 },
                    { 17, 16, 4, 1 },
                    { 18, 17, 1, 1 },
                    { 19, 18, 3, 1 },
                    { 20, 19, 2, 1 },
                    { 21, 20, 1, 1 }
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
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CoderLanguages",
                keyColumn: "Id",
                keyValue: 21);

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
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 20, 2 });

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
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

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
                table: "Coders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Coders",
                keyColumn: "Id",
                keyValue: 20);

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
                table: "Sectors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sectors",
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
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
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

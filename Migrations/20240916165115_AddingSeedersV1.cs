using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Linkup_ms.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedersV1 : Migration
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
                    { 1, new DateTime(2024, 3, 1, 1, 17, 51, 0, DateTimeKind.Utc), "jackeline.cardona@example.com", true, "jackeline cardona", new byte[] { 199, 28, 218, 184, 77, 206, 37, 182, 106, 61, 188, 175, 237, 67, 151, 0, 33, 82, 228, 1, 13, 80, 124, 179, 100, 51, 135, 109, 150, 166, 162, 130, 125, 180, 236, 163, 142, 107, 164, 74, 31, 205, 11, 65, 231, 32, 73, 148, 102, 99, 52, 4, 32, 42, 109, 17, 38, 223, 221, 67, 118, 244, 6, 19 }, new byte[] { 227, 206, 63, 128, 105, 255, 166, 49, 38, 88, 76, 0, 188, 35, 121, 24, 190, 207, 242, 175, 13, 255, 196, 160, 154, 124, 12, 42, 42, 216, 198, 32, 71, 17, 63, 138, 68, 162, 240, 14, 235, 173, 180, 99, 211, 21, 236, 146, 65, 141, 45, 191, 124, 191, 3, 58, 8, 140, 177, 168, 45, 5, 31, 231, 52, 219, 161, 4, 182, 63, 34, 155, 50, 137, 166, 238, 166, 178, 30, 159, 14, 116, 7, 247, 199, 42, 87, 62, 82, 191, 78, 243, 158, 149, 163, 122, 67, 237, 221, 50, 122, 187, 135, 226, 1, 236, 12, 85, 30, 203, 213, 235, 197, 117, 19, 12, 173, 7, 254, 79, 33, 55, 140, 41, 234, 37, 67, 121 }, "1234567890", 1, 1 },
                    { 2, new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc), "jane.smith@example.com", true, "jane smith", new byte[] { 254, 81, 23, 150, 151, 212, 251, 220, 191, 10, 123, 254, 165, 30, 81, 105, 97, 192, 201, 219, 18, 129, 55, 223, 141, 97, 24, 210, 82, 239, 62, 23, 55, 62, 131, 35, 1, 133, 149, 181, 87, 177, 223, 1, 119, 163, 202, 196, 142, 32, 144, 5, 100, 86, 208, 96, 245, 39, 16, 225, 232, 191, 109, 19 }, new byte[] { 183, 16, 119, 255, 34, 204, 88, 62, 41, 1, 169, 180, 180, 177, 211, 90, 250, 246, 138, 93, 17, 250, 199, 0, 255, 152, 134, 247, 117, 79, 195, 97, 219, 16, 225, 169, 2, 213, 29, 229, 208, 14, 22, 30, 223, 203, 92, 27, 181, 191, 216, 210, 125, 43, 67, 195, 224, 137, 106, 240, 200, 240, 74, 133, 140, 152, 141, 73, 160, 206, 59, 161, 158, 4, 17, 215, 119, 239, 97, 109, 233, 76, 229, 181, 240, 48, 225, 24, 210, 129, 251, 250, 213, 154, 167, 35, 198, 71, 76, 249, 241, 15, 32, 128, 5, 3, 154, 159, 174, 212, 135, 181, 131, 199, 207, 188, 27, 186, 85, 187, 213, 101, 130, 58, 30, 4, 222, 234 }, "2345678901", 2, 2 },
                    { 3, new DateTime(2024, 3, 20, 1, 17, 51, 0, DateTimeKind.Utc), "alice.johnson@example.com", true, "alice johnson", new byte[] { 111, 238, 102, 113, 116, 186, 126, 125, 82, 43, 42, 240, 2, 249, 129, 110, 114, 119, 176, 111, 6, 29, 183, 193, 15, 253, 70, 120, 166, 74, 92, 235, 187, 114, 12, 182, 189, 0, 185, 107, 15, 207, 70, 96, 52, 82, 215, 156, 216, 72, 108, 63, 64, 15, 24, 250, 51, 72, 109, 49, 99, 86, 64, 170 }, new byte[] { 185, 58, 9, 205, 212, 136, 205, 110, 112, 175, 73, 38, 101, 207, 114, 65, 138, 130, 245, 91, 65, 190, 92, 54, 25, 80, 233, 21, 24, 126, 16, 206, 158, 50, 146, 143, 218, 6, 115, 64, 133, 201, 97, 67, 99, 133, 166, 78, 43, 196, 174, 213, 96, 208, 253, 14, 181, 21, 101, 65, 226, 186, 184, 36, 101, 241, 162, 0, 201, 230, 250, 84, 247, 151, 183, 152, 142, 213, 17, 208, 71, 236, 66, 137, 85, 183, 137, 19, 173, 95, 11, 52, 227, 180, 230, 163, 119, 208, 85, 213, 8, 36, 54, 189, 128, 185, 251, 238, 191, 151, 200, 245, 247, 153, 34, 129, 79, 78, 69, 28, 4, 45, 254, 78, 157, 112, 155, 21 }, "3456789012", 2, 4 },
                    { 4, new DateTime(2024, 4, 1, 1, 17, 51, 0, DateTimeKind.Utc), "bob.williams@example.com", true, "bob williams", new byte[] { 249, 238, 5, 225, 33, 19, 47, 156, 7, 89, 142, 125, 8, 65, 214, 114, 227, 234, 210, 124, 10, 197, 119, 45, 230, 173, 94, 152, 30, 107, 249, 88, 12, 176, 228, 8, 219, 46, 157, 70, 27, 27, 154, 37, 50, 95, 24, 233, 108, 251, 164, 198, 29, 187, 231, 186, 106, 101, 156, 17, 114, 96, 42, 44 }, new byte[] { 221, 45, 6, 15, 131, 254, 42, 41, 116, 255, 168, 164, 69, 217, 105, 151, 251, 172, 103, 243, 12, 91, 22, 47, 198, 33, 193, 150, 239, 224, 209, 6, 132, 166, 154, 132, 3, 66, 208, 131, 31, 69, 117, 44, 211, 169, 81, 107, 13, 145, 172, 73, 214, 231, 37, 175, 92, 14, 95, 93, 99, 249, 154, 186, 115, 110, 136, 97, 202, 128, 37, 193, 192, 124, 50, 52, 111, 209, 255, 156, 15, 73, 148, 209, 21, 167, 97, 209, 38, 197, 159, 102, 241, 67, 19, 22, 0, 242, 182, 183, 206, 147, 207, 180, 44, 207, 163, 57, 1, 221, 200, 228, 173, 246, 105, 39, 6, 239, 58, 96, 83, 196, 212, 114, 58, 105, 100, 230 }, "4567890123", 2, 3 },
                    { 5, new DateTime(2024, 4, 15, 1, 17, 51, 0, DateTimeKind.Utc), "charlie.brown@example.com", true, "charlie brown", new byte[] { 20, 49, 136, 17, 13, 221, 156, 251, 160, 243, 0, 129, 197, 89, 104, 62, 102, 243, 206, 212, 241, 23, 233, 71, 174, 42, 108, 63, 96, 156, 104, 41, 235, 182, 102, 49, 76, 194, 12, 181, 124, 61, 188, 23, 92, 161, 108, 160, 140, 243, 45, 235, 239, 216, 123, 177, 83, 126, 21, 148, 20, 178, 201, 87 }, new byte[] { 82, 109, 47, 134, 113, 74, 205, 56, 252, 185, 226, 222, 240, 96, 99, 153, 147, 242, 182, 81, 173, 174, 244, 93, 106, 144, 169, 118, 206, 102, 80, 52, 72, 103, 111, 1, 7, 178, 26, 52, 220, 168, 125, 13, 82, 156, 127, 168, 123, 127, 117, 137, 219, 251, 73, 238, 172, 226, 13, 188, 14, 193, 125, 158, 209, 246, 110, 202, 86, 38, 78, 234, 41, 68, 153, 140, 223, 238, 177, 13, 202, 57, 204, 73, 15, 15, 1, 133, 23, 36, 128, 187, 114, 248, 97, 240, 133, 119, 160, 56, 254, 68, 1, 178, 43, 114, 195, 181, 142, 149, 217, 84, 36, 144, 47, 105, 108, 135, 221, 62, 161, 18, 237, 5, 250, 44, 213, 127 }, "5678901234", 2, 2 },
                    { 6, new DateTime(2024, 4, 25, 1, 17, 51, 0, DateTimeKind.Utc), "diana.clark@example.com", true, "diana clark", new byte[] { 32, 153, 173, 208, 167, 25, 240, 180, 41, 41, 225, 138, 14, 89, 51, 228, 122, 223, 23, 209, 110, 151, 139, 75, 220, 218, 213, 7, 155, 12, 25, 76, 15, 235, 106, 69, 57, 105, 83, 192, 219, 46, 70, 44, 95, 94, 46, 48, 65, 124, 159, 98, 194, 36, 156, 26, 248, 213, 211, 249, 71, 28, 114, 141 }, new byte[] { 140, 16, 89, 72, 130, 72, 25, 203, 242, 242, 225, 235, 254, 183, 102, 135, 225, 241, 160, 76, 249, 218, 227, 125, 218, 121, 141, 152, 84, 87, 50, 62, 118, 173, 96, 156, 249, 55, 47, 180, 7, 98, 52, 152, 15, 159, 176, 15, 149, 39, 255, 158, 178, 160, 59, 228, 92, 25, 227, 118, 98, 64, 3, 50, 25, 238, 20, 21, 11, 211, 29, 44, 187, 117, 54, 91, 17, 110, 218, 62, 50, 126, 28, 38, 39, 127, 45, 21, 70, 169, 152, 210, 22, 243, 186, 87, 211, 234, 175, 220, 50, 167, 109, 246, 76, 47, 54, 54, 218, 25, 72, 216, 74, 63, 52, 227, 131, 58, 217, 216, 224, 80, 151, 0, 77, 134, 141, 189 }, "6789012345", 2, 1 },
                    { 7, new DateTime(2024, 5, 1, 1, 17, 51, 0, DateTimeKind.Utc), "edward.davis@example.com", true, "edward davis", new byte[] { 46, 236, 9, 67, 118, 140, 86, 210, 104, 147, 141, 93, 172, 238, 140, 228, 26, 140, 36, 215, 136, 103, 190, 164, 158, 190, 59, 174, 209, 61, 202, 109, 244, 147, 214, 91, 41, 170, 228, 123, 255, 225, 130, 8, 247, 65, 218, 148, 167, 166, 77, 195, 11, 159, 169, 248, 128, 59, 113, 55, 198, 147, 176, 224 }, new byte[] { 12, 54, 177, 33, 231, 44, 237, 229, 119, 238, 173, 180, 0, 164, 145, 97, 72, 77, 248, 5, 50, 127, 251, 212, 30, 246, 186, 117, 26, 206, 212, 138, 53, 106, 90, 126, 231, 111, 128, 54, 240, 159, 31, 150, 113, 173, 27, 206, 122, 133, 116, 177, 12, 128, 247, 123, 92, 195, 37, 101, 202, 7, 250, 11, 46, 217, 159, 202, 176, 29, 233, 204, 112, 143, 26, 68, 104, 189, 126, 99, 248, 214, 68, 225, 227, 228, 134, 77, 122, 144, 167, 43, 67, 184, 94, 101, 16, 175, 122, 129, 165, 200, 182, 161, 155, 142, 218, 66, 23, 196, 99, 83, 255, 233, 207, 81, 150, 215, 98, 41, 114, 5, 142, 195, 250, 208, 94, 204 }, "7890123456", 2, 5 },
                    { 8, new DateTime(2024, 5, 10, 1, 17, 51, 0, DateTimeKind.Utc), "fiona.evans@example.com", true, "fiona evans", new byte[] { 138, 0, 166, 105, 240, 11, 104, 105, 179, 228, 152, 110, 179, 183, 97, 9, 252, 177, 100, 93, 150, 214, 207, 166, 98, 74, 11, 20, 34, 73, 33, 96, 92, 109, 181, 130, 74, 199, 139, 64, 89, 52, 213, 30, 222, 62, 54, 222, 33, 123, 29, 171, 33, 160, 161, 227, 130, 55, 149, 239, 195, 9, 29, 83 }, new byte[] { 22, 10, 136, 0, 204, 50, 215, 85, 124, 90, 11, 248, 20, 3, 11, 146, 214, 240, 37, 109, 99, 216, 232, 183, 87, 54, 208, 162, 54, 132, 85, 90, 114, 239, 161, 41, 28, 213, 17, 165, 100, 35, 65, 34, 156, 3, 8, 11, 137, 116, 181, 227, 160, 23, 253, 246, 9, 191, 41, 181, 93, 4, 189, 230, 229, 253, 201, 147, 154, 217, 201, 133, 215, 48, 87, 136, 225, 112, 227, 241, 8, 128, 66, 68, 164, 141, 183, 125, 210, 114, 22, 209, 168, 212, 168, 188, 60, 41, 97, 195, 173, 115, 22, 232, 198, 110, 53, 102, 174, 199, 1, 171, 59, 253, 109, 35, 174, 239, 235, 204, 234, 37, 44, 101, 157, 231, 120, 107 }, "8901234567", 2, 2 },
                    { 9, new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc), "george.fisher@example.com", true, "george fisher", new byte[] { 105, 88, 124, 185, 209, 51, 176, 72, 15, 115, 231, 213, 122, 238, 89, 1, 190, 194, 148, 180, 223, 213, 185, 159, 144, 73, 214, 204, 56, 247, 101, 23, 82, 31, 86, 36, 105, 213, 20, 113, 146, 196, 106, 223, 57, 78, 8, 38, 28, 73, 23, 194, 127, 60, 94, 189, 61, 15, 85, 54, 254, 163, 41, 49 }, new byte[] { 132, 158, 228, 130, 135, 45, 38, 82, 158, 100, 151, 146, 232, 90, 20, 125, 68, 188, 231, 235, 202, 7, 189, 217, 237, 18, 159, 247, 123, 63, 252, 44, 112, 155, 232, 88, 54, 16, 108, 138, 213, 245, 127, 90, 187, 103, 5, 132, 85, 27, 115, 244, 218, 236, 44, 120, 140, 132, 78, 31, 119, 211, 30, 232, 167, 112, 217, 173, 216, 126, 25, 251, 249, 109, 215, 231, 208, 232, 22, 124, 206, 114, 30, 47, 198, 83, 123, 105, 172, 140, 143, 57, 142, 131, 78, 158, 175, 183, 71, 226, 169, 155, 232, 217, 55, 12, 193, 37, 94, 192, 54, 246, 8, 237, 55, 172, 91, 60, 55, 197, 126, 39, 158, 234, 20, 12, 210, 133 }, "9012345678", 2, 5 },
                    { 10, new DateTime(2024, 6, 1, 1, 17, 51, 0, DateTimeKind.Utc), "hannah.green@example.com", true, "hannah green", new byte[] { 190, 254, 36, 93, 0, 101, 76, 243, 238, 69, 222, 7, 49, 131, 182, 178, 87, 193, 136, 182, 12, 252, 11, 73, 244, 162, 99, 159, 178, 115, 21, 36, 33, 123, 132, 27, 92, 45, 101, 224, 130, 34, 160, 143, 150, 62, 148, 33, 210, 142, 94, 123, 220, 90, 83, 254, 86, 233, 98, 205, 42, 128, 56, 60 }, new byte[] { 218, 179, 45, 101, 44, 124, 254, 249, 23, 62, 176, 170, 202, 231, 252, 175, 49, 114, 186, 200, 90, 28, 80, 157, 194, 127, 143, 219, 159, 193, 217, 176, 161, 125, 115, 61, 66, 63, 168, 64, 98, 61, 1, 183, 202, 193, 81, 204, 120, 11, 19, 233, 63, 93, 197, 164, 203, 33, 66, 225, 45, 237, 100, 57, 128, 98, 119, 56, 79, 127, 58, 81, 8, 204, 233, 40, 39, 223, 126, 212, 251, 234, 116, 179, 48, 162, 20, 185, 145, 69, 68, 48, 190, 86, 41, 239, 116, 180, 135, 30, 10, 208, 56, 231, 25, 146, 19, 239, 102, 49, 158, 176, 19, 71, 172, 244, 129, 98, 116, 59, 85, 188, 57, 69, 226, 184, 16, 228 }, "0123456789", 2, 3 },
                    { 11, new DateTime(2024, 6, 10, 1, 17, 51, 0, DateTimeKind.Utc), "isaac.lewis@example.com", true, "isaac lewis", new byte[] { 136, 254, 203, 125, 188, 19, 177, 104, 196, 158, 225, 168, 246, 10, 64, 32, 89, 93, 101, 122, 90, 185, 21, 206, 180, 25, 161, 48, 74, 115, 158, 141, 98, 12, 205, 197, 102, 113, 166, 98, 239, 250, 111, 186, 211, 12, 33, 103, 184, 100, 117, 86, 58, 93, 24, 63, 163, 132, 2, 63, 78, 240, 175, 228 }, new byte[] { 242, 112, 105, 54, 138, 44, 146, 102, 187, 186, 104, 150, 129, 126, 169, 135, 61, 117, 225, 75, 172, 5, 200, 62, 85, 42, 176, 83, 176, 81, 104, 11, 196, 178, 29, 59, 199, 68, 6, 250, 44, 214, 3, 89, 115, 193, 34, 232, 0, 50, 217, 172, 65, 183, 197, 212, 156, 195, 72, 144, 234, 95, 159, 19, 138, 15, 107, 146, 98, 17, 98, 80, 164, 114, 255, 160, 39, 93, 66, 236, 186, 98, 30, 216, 202, 156, 184, 75, 3, 155, 193, 31, 163, 180, 230, 29, 65, 89, 52, 25, 41, 180, 200, 58, 147, 22, 127, 42, 44, 203, 221, 66, 212, 76, 177, 47, 169, 89, 156, 226, 97, 206, 32, 146, 238, 134, 239, 135 }, "1234567891", 2, 2 },
                    { 12, new DateTime(2024, 6, 20, 1, 17, 51, 0, DateTimeKind.Utc), "julia.martinez@example.com", true, "julia martinez", new byte[] { 193, 123, 42, 93, 78, 108, 250, 214, 100, 253, 208, 162, 181, 120, 14, 186, 70, 201, 240, 90, 177, 117, 247, 114, 4, 119, 122, 129, 98, 71, 74, 14, 4, 116, 129, 53, 191, 247, 234, 194, 185, 190, 172, 126, 255, 67, 139, 82, 61, 243, 96, 139, 213, 238, 148, 20, 136, 197, 52, 250, 84, 99, 65, 253 }, new byte[] { 87, 181, 80, 237, 137, 123, 66, 162, 32, 38, 53, 187, 193, 176, 187, 8, 250, 234, 35, 214, 227, 90, 183, 118, 40, 128, 78, 107, 93, 48, 27, 111, 135, 110, 80, 125, 199, 68, 70, 6, 128, 219, 86, 229, 9, 27, 175, 231, 71, 94, 164, 123, 118, 146, 68, 247, 238, 70, 169, 109, 159, 11, 130, 189, 227, 191, 39, 14, 146, 109, 62, 144, 15, 74, 17, 79, 194, 219, 227, 193, 95, 115, 26, 111, 125, 251, 199, 8, 237, 83, 114, 31, 35, 74, 163, 44, 198, 236, 174, 241, 37, 75, 251, 249, 166, 1, 105, 13, 34, 110, 186, 88, 125, 61, 1, 24, 168, 234, 18, 71, 231, 156, 32, 195, 26, 31, 152, 113 }, "2345678902", 2, 4 },
                    { 13, new DateTime(2024, 7, 1, 1, 17, 51, 0, DateTimeKind.Utc), "kyle.wilson@example.com", true, "kyle wilson", new byte[] { 15, 58, 37, 27, 20, 227, 98, 21, 249, 184, 218, 105, 12, 14, 157, 29, 96, 132, 54, 41, 97, 142, 77, 52, 37, 130, 69, 238, 193, 237, 49, 206, 164, 17, 2, 77, 95, 220, 7, 68, 250, 104, 45, 236, 131, 6, 203, 156, 24, 56, 185, 217, 170, 246, 203, 121, 99, 117, 208, 63, 181, 89, 222, 92 }, new byte[] { 59, 15, 247, 119, 253, 235, 255, 81, 105, 197, 240, 108, 72, 111, 52, 79, 222, 203, 34, 147, 22, 50, 34, 43, 136, 244, 38, 23, 141, 82, 112, 176, 163, 156, 119, 202, 252, 103, 33, 90, 186, 2, 245, 229, 251, 118, 224, 128, 149, 110, 13, 118, 169, 109, 4, 243, 16, 33, 222, 79, 17, 5, 140, 93, 126, 0, 191, 93, 54, 201, 119, 186, 123, 94, 246, 15, 167, 180, 234, 186, 219, 102, 11, 20, 191, 34, 25, 90, 122, 124, 163, 168, 68, 248, 50, 174, 225, 204, 52, 202, 200, 2, 212, 100, 48, 251, 180, 30, 244, 175, 46, 121, 245, 211, 58, 156, 199, 92, 29, 90, 51, 126, 112, 17, 65, 45, 204, 32 }, "3456789013", 2, 5 },
                    { 14, new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc), "laura.johnson@example.com", true, "laura johnson", new byte[] { 54, 102, 203, 13, 86, 238, 189, 37, 125, 224, 196, 1, 238, 179, 185, 94, 205, 44, 47, 51, 243, 115, 212, 243, 14, 56, 71, 225, 143, 189, 24, 232, 10, 107, 230, 148, 84, 89, 241, 67, 111, 97, 203, 166, 136, 162, 195, 145, 9, 69, 90, 179, 77, 148, 107, 82, 231, 43, 164, 119, 83, 48, 187, 233 }, new byte[] { 253, 187, 242, 108, 103, 101, 35, 211, 172, 220, 191, 220, 25, 15, 145, 227, 168, 184, 244, 144, 175, 189, 48, 101, 144, 20, 206, 167, 55, 250, 1, 225, 11, 153, 175, 59, 170, 127, 94, 62, 152, 91, 89, 134, 82, 222, 84, 70, 170, 36, 43, 49, 115, 92, 201, 57, 138, 115, 236, 173, 247, 54, 49, 171, 169, 246, 253, 3, 177, 203, 222, 9, 26, 12, 219, 134, 185, 192, 170, 4, 210, 18, 28, 138, 213, 15, 63, 111, 96, 225, 76, 151, 235, 73, 90, 147, 151, 107, 183, 145, 138, 244, 146, 147, 250, 40, 139, 205, 225, 4, 187, 90, 176, 76, 6, 239, 191, 248, 181, 180, 214, 15, 108, 213, 250, 122, 70, 79 }, "4567890124", 2, 1 },
                    { 15, new DateTime(2024, 7, 20, 1, 17, 51, 0, DateTimeKind.Utc), "michael.brown@example.com", true, "michael brown", new byte[] { 249, 21, 23, 44, 100, 157, 209, 244, 10, 20, 133, 245, 134, 202, 84, 33, 199, 113, 184, 198, 121, 230, 96, 149, 111, 14, 157, 67, 197, 11, 2, 204, 118, 207, 126, 104, 48, 210, 6, 160, 83, 71, 196, 20, 190, 113, 10, 40, 105, 79, 24, 96, 68, 19, 218, 57, 136, 186, 150, 233, 61, 104, 103, 85 }, new byte[] { 66, 19, 177, 6, 62, 243, 131, 110, 165, 23, 190, 204, 133, 226, 135, 107, 240, 74, 230, 179, 132, 129, 105, 203, 136, 33, 148, 94, 71, 253, 118, 143, 133, 23, 222, 228, 188, 237, 163, 234, 43, 213, 127, 95, 167, 20, 123, 197, 219, 236, 85, 129, 58, 68, 14, 175, 66, 237, 241, 151, 209, 248, 131, 248, 82, 74, 25, 37, 194, 58, 81, 215, 45, 108, 55, 204, 81, 86, 165, 46, 153, 177, 130, 62, 20, 131, 204, 251, 135, 78, 57, 235, 213, 234, 237, 89, 129, 166, 29, 197, 10, 24, 19, 191, 186, 136, 100, 137, 232, 135, 94, 109, 78, 109, 189, 118, 136, 193, 26, 189, 211, 236, 34, 147, 233, 253, 203, 115 }, "5678901235", 2, 3 },
                    { 16, new DateTime(2024, 8, 1, 1, 17, 51, 0, DateTimeKind.Utc), "natalie.moore@example.com", true, "natalie moore", new byte[] { 130, 245, 72, 165, 181, 25, 213, 11, 116, 195, 165, 151, 168, 82, 110, 227, 75, 204, 52, 60, 199, 191, 217, 182, 194, 62, 193, 108, 180, 58, 120, 176, 184, 149, 191, 16, 59, 14, 29, 108, 252, 32, 177, 37, 224, 2, 207, 193, 204, 179, 243, 29, 245, 124, 72, 114, 240, 229, 76, 211, 120, 123, 164, 124 }, new byte[] { 97, 175, 236, 31, 179, 73, 242, 210, 187, 145, 39, 220, 80, 175, 35, 254, 106, 134, 230, 133, 134, 249, 151, 91, 180, 88, 44, 245, 75, 3, 219, 255, 56, 214, 135, 87, 92, 217, 155, 137, 233, 220, 78, 33, 24, 52, 90, 227, 141, 154, 97, 91, 121, 3, 163, 22, 67, 145, 70, 177, 161, 196, 7, 137, 123, 81, 49, 172, 240, 31, 109, 112, 40, 6, 93, 61, 184, 132, 158, 114, 121, 25, 6, 18, 122, 241, 87, 183, 193, 78, 214, 180, 178, 58, 25, 183, 199, 212, 255, 249, 197, 103, 81, 96, 148, 183, 247, 214, 163, 242, 53, 171, 164, 57, 185, 235, 184, 169, 66, 164, 193, 110, 65, 218, 82, 108, 37, 224 }, "6789012346", 2, 4 },
                    { 17, new DateTime(2024, 8, 10, 1, 17, 51, 0, DateTimeKind.Utc), "oliver.taylor@example.com", true, "oliver taylor", new byte[] { 108, 165, 37, 125, 45, 180, 90, 200, 145, 96, 5, 128, 166, 242, 204, 32, 7, 171, 82, 211, 254, 146, 190, 5, 115, 149, 215, 168, 77, 118, 87, 31, 141, 103, 68, 153, 229, 94, 77, 171, 42, 101, 160, 206, 238, 78, 33, 146, 180, 121, 46, 79, 254, 82, 189, 119, 26, 185, 65, 252, 63, 98, 45, 249 }, new byte[] { 78, 21, 116, 231, 14, 250, 154, 190, 195, 145, 223, 231, 13, 181, 31, 107, 21, 248, 23, 69, 25, 151, 201, 17, 131, 101, 123, 103, 141, 156, 207, 186, 150, 86, 39, 171, 171, 37, 116, 209, 152, 42, 200, 193, 73, 60, 233, 153, 99, 83, 57, 135, 11, 38, 230, 69, 63, 196, 23, 45, 86, 229, 137, 169, 181, 217, 205, 77, 218, 131, 14, 238, 196, 0, 226, 66, 76, 33, 215, 180, 124, 123, 189, 129, 177, 208, 73, 127, 164, 65, 114, 160, 219, 223, 172, 208, 104, 168, 187, 50, 35, 115, 137, 71, 61, 178, 130, 33, 175, 30, 198, 120, 120, 115, 130, 244, 32, 132, 19, 64, 63, 54, 117, 199, 165, 38, 178, 106 }, "7890123457", 2, 5 },
                    { 18, new DateTime(2024, 8, 20, 1, 17, 51, 0, DateTimeKind.Utc), "penelope.anderson@example.com", true, "penelope anderson", new byte[] { 65, 143, 11, 82, 178, 102, 160, 19, 180, 189, 94, 74, 165, 30, 15, 94, 185, 119, 176, 228, 7, 125, 117, 65, 141, 92, 128, 45, 88, 34, 101, 175, 31, 207, 19, 16, 156, 221, 251, 70, 27, 26, 145, 104, 171, 49, 128, 247, 231, 67, 194, 100, 153, 246, 86, 248, 214, 131, 172, 163, 101, 116, 122, 153 }, new byte[] { 31, 151, 92, 214, 192, 82, 231, 152, 117, 100, 80, 19, 0, 89, 154, 16, 137, 183, 91, 22, 131, 139, 124, 30, 238, 160, 91, 182, 179, 152, 73, 176, 105, 155, 193, 9, 228, 94, 7, 166, 167, 126, 131, 46, 61, 185, 49, 66, 125, 59, 152, 170, 103, 243, 203, 249, 254, 2, 111, 128, 196, 71, 73, 3, 60, 33, 115, 47, 231, 185, 202, 116, 174, 129, 203, 84, 188, 218, 177, 62, 212, 92, 64, 16, 136, 32, 88, 101, 94, 85, 104, 34, 178, 234, 2, 30, 168, 185, 24, 165, 241, 157, 135, 95, 127, 254, 38, 24, 199, 175, 140, 151, 76, 17, 252, 41, 226, 16, 143, 102, 65, 239, 177, 125, 56, 194, 103, 147 }, "8901234568", 2, 2 },
                    { 19, new DateTime(2024, 9, 1, 1, 17, 51, 0, DateTimeKind.Utc), "quinn.harris@example.com", true, "quinn harris", new byte[] { 0, 219, 60, 98, 146, 222, 255, 164, 49, 88, 225, 184, 3, 220, 235, 137, 12, 62, 26, 139, 123, 14, 180, 231, 191, 253, 25, 88, 171, 152, 159, 71, 79, 214, 254, 192, 198, 185, 144, 71, 69, 57, 132, 83, 37, 226, 239, 216, 96, 250, 12, 253, 139, 100, 136, 251, 132, 190, 8, 98, 163, 100, 75, 26 }, new byte[] { 215, 101, 21, 218, 77, 127, 78, 236, 114, 110, 43, 65, 110, 189, 100, 216, 82, 234, 46, 138, 16, 80, 126, 166, 60, 28, 158, 204, 1, 242, 178, 161, 37, 102, 240, 139, 70, 154, 84, 145, 50, 0, 151, 212, 34, 71, 14, 200, 182, 58, 203, 7, 206, 150, 105, 8, 46, 176, 177, 58, 35, 186, 21, 4, 54, 87, 140, 136, 231, 215, 218, 111, 49, 176, 66, 184, 95, 72, 158, 82, 209, 77, 212, 191, 42, 81, 143, 36, 196, 44, 89, 231, 145, 95, 245, 52, 250, 121, 232, 214, 151, 186, 95, 202, 155, 46, 85, 68, 45, 110, 146, 118, 89, 214, 184, 50, 139, 200, 112, 124, 26, 180, 36, 144, 26, 129, 227, 33 }, "9012345679", 2, 3 },
                    { 20, new DateTime(2024, 9, 15, 1, 17, 51, 0, DateTimeKind.Utc), "rachel.scott@example.com", true, "rachel scott", new byte[] { 178, 123, 38, 243, 38, 246, 30, 224, 218, 239, 241, 217, 231, 4, 231, 248, 176, 93, 184, 126, 137, 29, 175, 45, 11, 3, 226, 31, 70, 80, 41, 148, 119, 243, 93, 1, 84, 149, 138, 143, 90, 71, 240, 175, 239, 216, 75, 7, 218, 137, 226, 82, 229, 47, 171, 215, 25, 39, 37, 188, 68, 188, 27, 125 }, new byte[] { 43, 19, 219, 226, 27, 11, 122, 29, 223, 250, 166, 246, 164, 102, 99, 152, 127, 174, 225, 150, 95, 223, 113, 167, 43, 36, 200, 191, 139, 36, 102, 144, 54, 93, 47, 107, 236, 168, 60, 250, 119, 201, 167, 35, 120, 153, 187, 190, 249, 161, 181, 36, 111, 124, 128, 172, 242, 181, 60, 165, 154, 51, 141, 7, 55, 106, 21, 99, 191, 102, 30, 215, 106, 87, 173, 177, 66, 170, 220, 247, 249, 105, 246, 28, 16, 204, 79, 77, 26, 252, 4, 187, 63, 72, 222, 236, 162, 160, 26, 108, 146, 111, 9, 210, 130, 140, 61, 148, 170, 70, 129, 168, 107, 252, 101, 251, 84, 207, 24, 40, 115, 104, 21, 33, 106, 65, 190, 69 }, "0123456790", 2, 4 }
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

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Riwi_LinkUp.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedersV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoderLanguages_LanguageLevels_LanguageLevelId",
                table: "CoderLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_CoderTechnicalSkills_TechnicalSkillLevels_TechnicalSkillLev~",
                table: "CoderTechnicalSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoderTechnicalSkills",
                table: "CoderTechnicalSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoderLanguages",
                table: "CoderLanguages");

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoderTechnicalSkills",
                table: "CoderTechnicalSkills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoderLanguages",
                table: "CoderLanguages",
                column: "Id");

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
                table: "TechnicalSkillLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "junior" },
                    { 2, "semi-senior" },
                    { 3, "senior" }
                });

            migrationBuilder.UpdateData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "nodeJs");

            migrationBuilder.InsertData(
                table: "TechnicalSkills",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "nextJs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 27, 200, 77, 25, 233, 45, 139, 183, 219, 126, 54, 60, 126, 53, 195, 166, 203, 39, 212, 212, 217, 22, 233, 31, 2, 9, 138, 124, 221, 137, 142, 143, 168, 147, 5, 131, 24, 147, 181, 74, 214, 2, 192, 147, 1, 186, 87, 174, 61, 149, 77, 66, 138, 142, 63, 81, 122, 63, 151, 54, 18, 214, 30 }, new byte[] { 149, 232, 35, 174, 107, 82, 24, 234, 124, 203, 186, 122, 173, 88, 50, 144, 17, 34, 10, 121, 217, 43, 118, 88, 230, 113, 158, 184, 23, 210, 30, 137, 12, 53, 112, 46, 101, 5, 50, 211, 65, 236, 136, 92, 43, 154, 75, 139, 90, 107, 61, 104, 239, 223, 62, 25, 206, 23, 157, 251, 183, 40, 36, 215, 241, 200, 207, 2, 249, 75, 14, 173, 164, 233, 214, 176, 74, 195, 227, 146, 27, 218, 245, 178, 224, 53, 146, 73, 72, 156, 246, 147, 133, 26, 156, 164, 123, 65, 153, 54, 54, 86, 153, 245, 67, 37, 138, 213, 44, 113, 168, 139, 144, 47, 108, 130, 60, 137, 251, 250, 130, 65, 72, 210, 211, 91, 182, 222 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 234, 180, 79, 49, 60, 99, 129, 116, 113, 71, 158, 227, 233, 157, 189, 102, 115, 187, 89, 114, 213, 211, 1, 105, 182, 3, 245, 20, 206, 249, 135, 167, 206, 50, 99, 22, 114, 218, 250, 84, 81, 20, 131, 165, 205, 192, 251, 219, 98, 2, 16, 7, 228, 120, 245, 89, 34, 22, 123, 231, 142, 112, 134, 254 }, new byte[] { 41, 251, 237, 82, 97, 187, 76, 225, 139, 111, 190, 168, 174, 96, 219, 122, 201, 82, 105, 228, 210, 182, 244, 232, 242, 241, 198, 226, 45, 213, 140, 243, 139, 174, 41, 227, 42, 86, 180, 149, 153, 37, 111, 191, 179, 217, 111, 54, 147, 112, 162, 224, 190, 255, 170, 116, 245, 64, 164, 95, 229, 156, 83, 172, 190, 211, 204, 110, 103, 148, 159, 210, 216, 37, 212, 167, 254, 32, 145, 45, 148, 194, 39, 124, 224, 205, 62, 205, 127, 154, 148, 250, 71, 51, 51, 17, 170, 147, 76, 44, 174, 81, 8, 31, 121, 201, 181, 77, 42, 165, 14, 9, 70, 250, 251, 147, 188, 98, 227, 236, 240, 55, 240, 77, 79, 8, 142, 198 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 94, 202, 61, 35, 26, 228, 211, 29, 153, 105, 24, 134, 131, 61, 130, 117, 76, 138, 193, 120, 175, 131, 175, 180, 129, 216, 227, 255, 214, 38, 240, 50, 181, 171, 183, 3, 197, 62, 62, 30, 138, 37, 104, 42, 103, 120, 84, 214, 131, 49, 173, 163, 132, 38, 133, 85, 192, 103, 26, 167, 175, 117, 217 }, new byte[] { 144, 30, 156, 254, 74, 141, 40, 13, 195, 162, 111, 31, 151, 162, 116, 40, 116, 204, 42, 174, 112, 18, 29, 86, 74, 244, 126, 159, 202, 143, 182, 94, 239, 58, 4, 27, 144, 171, 230, 202, 7, 73, 143, 178, 159, 193, 189, 101, 193, 206, 93, 44, 121, 43, 182, 120, 126, 204, 30, 158, 38, 103, 52, 139, 248, 61, 217, 135, 10, 156, 15, 68, 5, 50, 103, 35, 240, 217, 164, 195, 152, 74, 75, 188, 90, 200, 130, 136, 121, 78, 18, 53, 53, 143, 227, 30, 181, 41, 88, 23, 171, 207, 11, 100, 72, 129, 59, 4, 220, 188, 182, 116, 156, 110, 109, 108, 28, 117, 60, 130, 85, 171, 230, 189, 142, 246, 223, 74 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 253, 123, 26, 168, 54, 93, 239, 221, 29, 212, 241, 58, 212, 206, 90, 217, 97, 71, 190, 226, 197, 181, 187, 125, 230, 137, 40, 131, 100, 199, 248, 72, 75, 147, 134, 27, 82, 113, 168, 248, 172, 71, 248, 185, 114, 99, 70, 245, 64, 69, 181, 60, 68, 130, 219, 179, 48, 237, 105, 40, 148, 21, 235 }, new byte[] { 146, 131, 122, 173, 36, 94, 102, 129, 5, 204, 191, 17, 15, 22, 98, 139, 3, 62, 81, 126, 123, 69, 41, 4, 59, 217, 147, 249, 222, 17, 207, 43, 231, 29, 99, 167, 28, 162, 230, 97, 2, 89, 210, 64, 214, 182, 198, 18, 235, 4, 253, 150, 23, 224, 230, 226, 11, 90, 24, 115, 208, 193, 134, 137, 11, 226, 71, 118, 148, 111, 255, 209, 209, 101, 150, 182, 200, 49, 165, 76, 220, 232, 127, 235, 160, 197, 128, 84, 10, 153, 15, 119, 80, 253, 198, 166, 37, 56, 176, 97, 71, 82, 72, 172, 214, 61, 62, 234, 120, 7, 30, 187, 252, 159, 6, 140, 140, 5, 128, 213, 137, 150, 209, 233, 54, 206, 217, 238 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 37, 247, 19, 137, 111, 122, 49, 101, 36, 214, 18, 205, 228, 92, 132, 29, 241, 55, 127, 241, 211, 188, 151, 81, 244, 204, 111, 14, 65, 145, 97, 62, 77, 92, 193, 95, 35, 206, 155, 3, 234, 20, 198, 64, 15, 60, 159, 34, 84, 62, 22, 13, 185, 24, 221, 94, 253, 103, 192, 139, 192, 4, 127 }, new byte[] { 189, 105, 100, 115, 23, 48, 69, 80, 52, 159, 111, 80, 3, 18, 122, 188, 125, 201, 34, 12, 84, 124, 199, 18, 226, 238, 181, 189, 41, 156, 212, 159, 116, 109, 232, 0, 86, 167, 93, 79, 156, 232, 30, 47, 201, 15, 70, 108, 215, 164, 73, 186, 50, 206, 161, 204, 212, 215, 253, 42, 133, 185, 174, 186, 4, 212, 200, 156, 49, 163, 224, 98, 64, 215, 173, 163, 28, 61, 107, 192, 43, 127, 23, 232, 245, 77, 221, 146, 26, 12, 68, 36, 47, 237, 171, 162, 183, 134, 244, 9, 233, 198, 82, 87, 203, 24, 196, 39, 33, 60, 226, 245, 200, 233, 216, 170, 200, 246, 14, 81, 202, 197, 28, 169, 147, 223, 209, 206 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 88, 240, 171, 89, 1, 23, 53, 86, 150, 238, 170, 84, 149, 59, 226, 118, 61, 168, 77, 251, 224, 57, 74, 230, 81, 131, 95, 220, 121, 162, 49, 139, 64, 164, 24, 139, 100, 106, 177, 250, 41, 240, 16, 231, 154, 27, 180, 11, 212, 139, 247, 144, 157, 120, 83, 103, 81, 214, 237, 166, 22, 134, 246 }, new byte[] { 94, 169, 178, 141, 23, 3, 128, 81, 105, 40, 161, 63, 148, 229, 174, 246, 43, 50, 197, 38, 158, 179, 111, 116, 63, 10, 121, 200, 207, 85, 203, 197, 70, 111, 189, 189, 70, 64, 164, 46, 204, 26, 0, 40, 234, 68, 173, 242, 125, 232, 118, 193, 32, 25, 197, 236, 39, 94, 120, 13, 201, 59, 20, 211, 58, 106, 40, 162, 95, 236, 68, 114, 254, 48, 84, 235, 182, 87, 49, 102, 78, 42, 199, 170, 226, 221, 11, 251, 139, 46, 214, 112, 235, 251, 115, 227, 80, 111, 136, 198, 133, 251, 33, 56, 180, 146, 111, 40, 26, 14, 173, 21, 42, 16, 192, 173, 217, 211, 242, 209, 230, 83, 229, 89, 97, 23, 183, 171 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 181, 223, 238, 123, 100, 82, 78, 35, 225, 216, 159, 189, 72, 38, 133, 78, 138, 2, 85, 182, 210, 120, 90, 67, 70, 123, 30, 22, 117, 90, 17, 154, 194, 242, 217, 230, 107, 230, 111, 207, 91, 218, 158, 116, 16, 201, 206, 78, 108, 206, 64, 144, 211, 242, 216, 219, 18, 56, 151, 93, 106, 149, 130, 129 }, new byte[] { 93, 34, 161, 203, 124, 241, 177, 77, 249, 17, 99, 10, 151, 54, 177, 251, 12, 30, 53, 153, 10, 83, 214, 28, 96, 189, 38, 194, 31, 171, 83, 163, 192, 5, 111, 181, 167, 98, 202, 130, 252, 118, 126, 238, 176, 121, 233, 129, 168, 108, 232, 140, 56, 189, 67, 154, 86, 96, 222, 151, 161, 6, 124, 247, 83, 84, 161, 20, 186, 224, 121, 161, 38, 196, 131, 139, 195, 87, 73, 10, 30, 92, 183, 170, 252, 210, 202, 132, 61, 203, 10, 104, 253, 214, 101, 81, 231, 63, 226, 9, 26, 218, 237, 59, 11, 154, 225, 169, 230, 229, 3, 81, 254, 36, 46, 41, 139, 34, 6, 2, 182, 190, 129, 81, 245, 241, 2, 227 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 82, 121, 206, 192, 202, 198, 193, 134, 126, 219, 236, 221, 68, 133, 76, 131, 113, 242, 16, 111, 195, 150, 39, 64, 198, 97, 200, 132, 191, 230, 183, 68, 87, 142, 193, 206, 134, 59, 165, 138, 40, 66, 134, 53, 104, 128, 15, 170, 67, 220, 25, 58, 26, 1, 218, 78, 156, 12, 3, 195, 133, 127, 48 }, new byte[] { 26, 51, 78, 222, 149, 79, 134, 247, 169, 152, 12, 175, 69, 107, 69, 235, 204, 125, 27, 93, 240, 98, 234, 148, 49, 100, 148, 217, 62, 209, 136, 165, 204, 90, 111, 120, 251, 17, 85, 200, 158, 135, 121, 174, 131, 19, 21, 23, 198, 248, 11, 147, 9, 208, 171, 200, 238, 21, 174, 213, 113, 82, 1, 53, 161, 107, 245, 150, 125, 251, 169, 31, 5, 32, 77, 34, 35, 20, 134, 66, 138, 129, 171, 123, 50, 122, 94, 18, 165, 80, 111, 208, 157, 63, 40, 31, 84, 228, 51, 173, 85, 125, 72, 136, 115, 97, 225, 241, 191, 241, 173, 145, 107, 149, 113, 51, 102, 232, 42, 221, 106, 223, 180, 56, 234, 25, 148, 244 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 144, 97, 178, 26, 254, 195, 36, 91, 42, 34, 118, 116, 19, 211, 77, 97, 188, 0, 170, 53, 143, 114, 233, 5, 5, 42, 48, 235, 4, 123, 200, 19, 232, 190, 209, 236, 223, 141, 238, 45, 64, 106, 141, 108, 241, 138, 113, 123, 198, 206, 132, 29, 140, 179, 246, 198, 232, 116, 172, 113, 46, 239, 232 }, new byte[] { 181, 61, 141, 140, 247, 208, 52, 167, 43, 20, 119, 208, 143, 148, 54, 144, 13, 142, 118, 179, 162, 81, 134, 97, 5, 231, 120, 78, 72, 113, 71, 128, 54, 81, 212, 33, 198, 144, 173, 109, 22, 80, 160, 0, 231, 247, 137, 199, 208, 145, 241, 65, 68, 93, 83, 232, 225, 115, 60, 7, 200, 23, 150, 61, 101, 227, 131, 82, 127, 173, 171, 184, 67, 139, 255, 61, 161, 49, 100, 235, 214, 113, 82, 160, 16, 253, 154, 227, 32, 194, 163, 92, 199, 172, 80, 229, 243, 181, 122, 96, 94, 170, 4, 192, 140, 188, 181, 8, 85, 150, 63, 126, 86, 48, 139, 110, 25, 93, 29, 21, 219, 19, 98, 105, 73, 177, 44, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 43, 91, 53, 228, 2, 12, 20, 10, 253, 210, 38, 105, 8, 122, 32, 234, 226, 130, 152, 25, 238, 214, 51, 93, 1, 233, 67, 198, 195, 5, 18, 63, 120, 212, 29, 208, 110, 167, 139, 145, 11, 245, 129, 96, 237, 191, 31, 187, 43, 6, 212, 31, 196, 221, 11, 78, 97, 109, 56, 249, 149, 175, 51 }, new byte[] { 114, 97, 179, 254, 154, 192, 146, 236, 210, 59, 152, 172, 225, 147, 31, 157, 243, 87, 62, 235, 240, 240, 172, 25, 192, 140, 203, 150, 121, 4, 254, 126, 91, 125, 207, 147, 216, 249, 166, 211, 242, 85, 242, 210, 71, 198, 251, 117, 66, 22, 245, 178, 123, 159, 130, 142, 11, 160, 254, 130, 41, 251, 32, 228, 88, 141, 77, 211, 3, 119, 36, 194, 120, 174, 151, 91, 149, 157, 5, 141, 37, 169, 109, 250, 43, 83, 179, 239, 194, 169, 89, 39, 127, 150, 18, 12, 60, 244, 110, 130, 242, 249, 233, 172, 44, 188, 121, 247, 55, 247, 121, 249, 68, 182, 176, 120, 105, 56, 111, 109, 151, 213, 150, 199, 103, 220, 11, 127 } });

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

            migrationBuilder.CreateIndex(
                name: "IX_CoderTechnicalSkills_CoderId",
                table: "CoderTechnicalSkills",
                column: "CoderId");

            migrationBuilder.CreateIndex(
                name: "IX_CoderLanguages_CoderId",
                table: "CoderLanguages",
                column: "CoderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoderLanguages_LanguageLevels_LanguageLevelId",
                table: "CoderLanguages",
                column: "LanguageLevelId",
                principalTable: "LanguageLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CoderTechnicalSkills_TechnicalSkillLevels_TechnicalSkillLev~",
                table: "CoderTechnicalSkills",
                column: "TechnicalSkillLevelId",
                principalTable: "TechnicalSkillLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoderLanguages_LanguageLevels_LanguageLevelId",
                table: "CoderLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_CoderTechnicalSkills_TechnicalSkillLevels_TechnicalSkillLev~",
                table: "CoderTechnicalSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoderTechnicalSkills",
                table: "CoderTechnicalSkills");

            migrationBuilder.DropIndex(
                name: "IX_CoderTechnicalSkills_CoderId",
                table: "CoderTechnicalSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoderLanguages",
                table: "CoderLanguages");

            migrationBuilder.DropIndex(
                name: "IX_CoderLanguages_CoderId",
                table: "CoderLanguages");

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
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoderTechnicalSkills",
                table: "CoderTechnicalSkills",
                columns: new[] { "CoderId", "TechnicalSkillId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoderLanguages",
                table: "CoderLanguages",
                columns: new[] { "CoderId", "LanguageId" });

            migrationBuilder.UpdateData(
                table: "TechnicalSkills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "nextJs");

            migrationBuilder.InsertData(
                table: "TechnicalSkills",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "nodeJs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 83, 182, 195, 218, 140, 165, 246, 128, 3, 170, 135, 153, 246, 238, 52, 172, 144, 122, 43, 101, 28, 174, 139, 131, 223, 133, 208, 68, 125, 60, 56, 209, 255, 182, 97, 60, 94, 92, 84, 13, 194, 215, 105, 127, 41, 4, 73, 8, 15, 105, 141, 50, 196, 46, 39, 218, 179, 30, 94, 191, 55, 247, 134, 199 }, new byte[] { 12, 3, 135, 112, 248, 116, 212, 171, 85, 232, 185, 82, 214, 14, 217, 222, 49, 180, 168, 56, 187, 120, 55, 22, 156, 119, 224, 247, 98, 255, 224, 249, 41, 29, 14, 50, 73, 129, 74, 247, 56, 118, 171, 86, 161, 141, 196, 246, 222, 54, 200, 141, 237, 253, 155, 208, 177, 241, 0, 234, 29, 86, 220, 202, 121, 58, 42, 18, 57, 145, 174, 83, 254, 142, 25, 82, 252, 114, 172, 216, 134, 102, 129, 115, 196, 194, 250, 16, 228, 137, 88, 187, 155, 177, 76, 120, 81, 191, 212, 95, 218, 104, 107, 159, 245, 3, 73, 123, 166, 49, 17, 87, 237, 117, 98, 167, 126, 34, 147, 55, 226, 43, 215, 246, 227, 220, 214, 127 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 2, 50, 10, 59, 109, 143, 161, 100, 42, 37, 146, 26, 122, 149, 164, 141, 240, 10, 242, 32, 55, 144, 108, 164, 198, 90, 215, 33, 122, 166, 100, 96, 210, 251, 50, 93, 76, 221, 41, 30, 75, 217, 172, 195, 135, 199, 19, 210, 172, 139, 83, 109, 177, 186, 73, 135, 18, 105, 5, 186, 35, 146, 29 }, new byte[] { 130, 97, 144, 116, 76, 24, 204, 97, 142, 117, 209, 130, 208, 90, 62, 5, 198, 221, 186, 226, 161, 151, 167, 240, 252, 8, 20, 58, 85, 50, 143, 91, 135, 92, 52, 99, 170, 224, 185, 97, 0, 47, 183, 222, 89, 33, 107, 133, 247, 5, 95, 72, 149, 119, 135, 182, 135, 36, 135, 148, 21, 63, 53, 68, 71, 42, 144, 185, 88, 222, 255, 127, 218, 46, 100, 178, 230, 88, 104, 4, 159, 59, 77, 96, 109, 5, 180, 167, 212, 57, 130, 24, 96, 187, 19, 204, 197, 165, 125, 82, 236, 250, 217, 5, 58, 119, 177, 24, 213, 29, 53, 74, 181, 52, 167, 230, 214, 54, 23, 115, 58, 71, 183, 88, 174, 215, 210, 30 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 27, 62, 108, 61, 186, 47, 63, 10, 199, 164, 129, 25, 219, 79, 220, 150, 7, 172, 61, 41, 143, 116, 10, 132, 58, 18, 168, 246, 74, 70, 213, 164, 247, 75, 14, 206, 5, 98, 102, 180, 247, 185, 158, 108, 220, 190, 2, 193, 243, 237, 186, 31, 91, 45, 196, 160, 191, 124, 107, 198, 136, 139, 243 }, new byte[] { 40, 105, 186, 210, 129, 121, 73, 43, 0, 13, 63, 134, 62, 138, 54, 30, 248, 0, 27, 157, 107, 48, 26, 234, 149, 110, 134, 35, 158, 107, 110, 154, 175, 56, 247, 71, 154, 235, 80, 95, 37, 10, 204, 202, 233, 133, 167, 25, 14, 53, 3, 14, 111, 202, 92, 255, 13, 244, 123, 8, 11, 187, 52, 254, 160, 192, 40, 211, 45, 33, 29, 11, 103, 88, 154, 69, 71, 79, 132, 144, 170, 114, 183, 212, 60, 93, 109, 91, 69, 186, 108, 105, 213, 108, 103, 150, 131, 108, 218, 11, 131, 52, 115, 135, 1, 54, 7, 1, 82, 9, 120, 66, 86, 166, 230, 214, 152, 59, 175, 146, 86, 148, 91, 186, 166, 143, 75, 142 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 253, 148, 187, 3, 33, 242, 205, 247, 213, 102, 45, 13, 154, 82, 199, 87, 10, 3, 141, 39, 112, 184, 142, 249, 90, 20, 75, 233, 38, 178, 120, 101, 38, 147, 244, 111, 127, 21, 124, 53, 212, 49, 44, 2, 207, 208, 121, 162, 209, 236, 234, 5, 244, 47, 214, 189, 157, 123, 94, 126, 218, 123, 165, 170 }, new byte[] { 35, 59, 46, 132, 205, 13, 69, 105, 33, 167, 63, 172, 218, 154, 92, 111, 96, 15, 229, 49, 137, 13, 20, 188, 111, 82, 189, 135, 23, 59, 38, 183, 168, 10, 8, 35, 104, 81, 83, 118, 124, 118, 58, 115, 36, 110, 193, 133, 15, 23, 196, 178, 171, 142, 243, 25, 193, 51, 201, 49, 102, 222, 208, 83, 67, 143, 98, 163, 8, 94, 180, 84, 243, 169, 163, 132, 231, 43, 95, 11, 28, 73, 81, 170, 69, 97, 39, 6, 241, 15, 172, 149, 81, 168, 53, 253, 175, 5, 71, 179, 110, 241, 128, 119, 137, 245, 85, 138, 42, 20, 29, 173, 216, 176, 71, 117, 183, 230, 24, 132, 250, 197, 51, 25, 141, 50, 80, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 203, 136, 178, 87, 1, 185, 65, 215, 44, 91, 205, 121, 99, 254, 50, 250, 122, 152, 156, 76, 251, 131, 170, 169, 1, 172, 76, 70, 74, 94, 239, 6, 53, 254, 38, 48, 161, 162, 115, 100, 85, 50, 97, 54, 92, 226, 86, 93, 125, 240, 153, 39, 111, 229, 140, 122, 194, 213, 193, 158, 73, 37, 192, 232 }, new byte[] { 89, 157, 15, 244, 206, 216, 245, 101, 202, 161, 158, 123, 160, 230, 107, 224, 108, 14, 254, 34, 253, 39, 71, 38, 155, 32, 87, 184, 144, 17, 237, 137, 251, 239, 203, 93, 30, 156, 179, 157, 87, 70, 89, 236, 69, 228, 43, 174, 94, 141, 247, 133, 95, 210, 68, 67, 66, 42, 5, 18, 92, 117, 159, 99, 147, 32, 90, 100, 137, 255, 13, 80, 71, 203, 105, 30, 91, 193, 68, 126, 128, 176, 15, 47, 144, 24, 252, 184, 14, 41, 28, 11, 28, 131, 125, 149, 234, 111, 79, 6, 240, 60, 78, 235, 231, 66, 31, 63, 126, 31, 234, 253, 92, 241, 113, 99, 55, 45, 226, 94, 3, 215, 21, 226, 38, 3, 171, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 80, 2, 225, 211, 182, 202, 100, 226, 140, 5, 129, 61, 19, 105, 151, 216, 187, 222, 52, 107, 55, 195, 134, 242, 189, 95, 127, 166, 235, 118, 34, 2, 214, 218, 244, 252, 159, 98, 177, 29, 149, 235, 22, 234, 132, 74, 124, 62, 205, 76, 91, 59, 112, 43, 132, 155, 157, 78, 183, 24, 239, 188, 205, 152 }, new byte[] { 146, 109, 204, 114, 155, 102, 222, 68, 232, 253, 28, 102, 239, 47, 211, 73, 73, 91, 105, 47, 216, 103, 226, 114, 117, 221, 133, 198, 219, 69, 227, 225, 234, 242, 118, 30, 13, 190, 236, 11, 254, 245, 43, 70, 126, 211, 164, 24, 92, 195, 139, 184, 37, 51, 225, 219, 162, 148, 46, 167, 97, 156, 144, 122, 88, 44, 43, 115, 68, 155, 186, 222, 11, 3, 81, 49, 253, 197, 224, 35, 15, 137, 70, 116, 155, 23, 30, 139, 211, 247, 214, 99, 132, 188, 53, 62, 109, 198, 87, 254, 53, 86, 251, 8, 104, 232, 178, 108, 2, 130, 25, 92, 151, 110, 112, 109, 48, 222, 131, 9, 153, 226, 67, 72, 139, 212, 46, 170 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 195, 157, 125, 134, 44, 247, 224, 124, 79, 151, 223, 166, 197, 40, 76, 166, 50, 196, 173, 234, 243, 105, 117, 172, 160, 63, 233, 209, 130, 124, 209, 158, 241, 88, 7, 206, 187, 161, 165, 48, 42, 14, 144, 52, 143, 247, 84, 30, 240, 143, 242, 137, 167, 243, 174, 158, 155, 176, 212, 183, 102, 195, 151, 34 }, new byte[] { 6, 207, 115, 162, 145, 146, 187, 253, 198, 167, 118, 234, 129, 149, 149, 239, 143, 12, 170, 249, 202, 230, 156, 197, 59, 10, 222, 69, 116, 86, 197, 137, 255, 208, 249, 240, 16, 247, 10, 73, 19, 225, 69, 139, 9, 100, 40, 54, 98, 120, 193, 254, 35, 27, 29, 230, 46, 221, 151, 164, 5, 14, 68, 184, 131, 204, 226, 7, 226, 144, 90, 103, 89, 123, 212, 22, 194, 241, 174, 149, 31, 35, 35, 46, 101, 236, 254, 30, 171, 149, 59, 232, 41, 101, 168, 149, 226, 241, 253, 216, 71, 171, 20, 146, 79, 181, 79, 53, 181, 171, 80, 209, 160, 232, 31, 194, 73, 87, 60, 107, 53, 180, 240, 101, 137, 67, 170, 53 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 52, 224, 226, 193, 2, 161, 158, 161, 15, 133, 114, 30, 254, 44, 169, 198, 124, 173, 112, 72, 30, 88, 197, 129, 200, 156, 119, 19, 135, 37, 240, 231, 103, 182, 157, 140, 178, 46, 111, 11, 94, 250, 240, 71, 215, 119, 242, 197, 63, 237, 176, 224, 32, 60, 144, 219, 160, 136, 236, 108, 119, 108, 66 }, new byte[] { 155, 4, 190, 55, 100, 35, 251, 46, 21, 198, 65, 50, 32, 28, 207, 127, 241, 17, 68, 249, 91, 72, 153, 68, 54, 36, 138, 252, 155, 155, 148, 93, 240, 196, 64, 203, 142, 19, 118, 217, 2, 213, 96, 156, 178, 77, 161, 42, 197, 223, 9, 46, 121, 106, 216, 132, 217, 159, 99, 154, 217, 247, 78, 147, 208, 80, 95, 139, 80, 126, 28, 108, 70, 63, 149, 209, 125, 170, 0, 54, 60, 96, 64, 235, 29, 43, 118, 80, 223, 109, 172, 121, 10, 193, 18, 51, 201, 217, 45, 35, 246, 74, 155, 177, 13, 172, 28, 62, 89, 3, 61, 95, 105, 57, 82, 187, 42, 197, 45, 39, 233, 219, 115, 59, 50, 140, 6, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 199, 189, 22, 217, 155, 1, 171, 246, 175, 159, 49, 118, 240, 114, 53, 225, 128, 253, 250, 245, 89, 91, 229, 167, 83, 138, 155, 94, 86, 222, 75, 182, 234, 19, 157, 63, 143, 92, 166, 215, 255, 241, 152, 101, 237, 248, 231, 224, 209, 154, 170, 15, 112, 59, 32, 167, 51, 130, 188, 144, 144, 75, 175 }, new byte[] { 115, 90, 56, 163, 252, 34, 113, 163, 78, 2, 188, 170, 245, 19, 191, 153, 71, 18, 39, 142, 51, 137, 143, 243, 85, 120, 186, 156, 3, 169, 192, 155, 64, 181, 59, 77, 236, 149, 188, 89, 26, 175, 147, 120, 227, 84, 181, 23, 235, 12, 192, 34, 2, 73, 136, 7, 234, 229, 43, 152, 9, 168, 139, 236, 58, 8, 248, 99, 158, 206, 137, 187, 210, 254, 73, 137, 236, 194, 78, 226, 147, 187, 115, 163, 56, 154, 175, 24, 70, 141, 163, 230, 14, 68, 234, 49, 63, 229, 190, 66, 118, 179, 110, 157, 213, 205, 104, 28, 232, 20, 247, 243, 223, 151, 67, 247, 215, 102, 201, 134, 167, 242, 225, 70, 132, 123, 140, 177 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 220, 150, 250, 61, 78, 227, 203, 140, 166, 233, 1, 3, 199, 48, 202, 1, 84, 113, 215, 24, 152, 106, 49, 166, 100, 204, 115, 173, 48, 35, 233, 25, 111, 20, 176, 248, 49, 210, 16, 162, 161, 253, 12, 154, 208, 124, 19, 108, 123, 90, 18, 158, 52, 217, 132, 28, 221, 205, 40, 149, 83, 31, 74, 106 }, new byte[] { 102, 131, 254, 208, 58, 123, 210, 15, 159, 215, 220, 214, 160, 59, 2, 56, 100, 121, 93, 130, 103, 45, 229, 32, 126, 148, 138, 89, 57, 84, 244, 52, 197, 92, 168, 177, 159, 66, 48, 203, 249, 154, 140, 34, 254, 189, 154, 57, 141, 220, 125, 149, 247, 44, 9, 154, 195, 110, 194, 61, 94, 154, 143, 133, 238, 249, 164, 92, 21, 1, 36, 88, 27, 8, 110, 222, 91, 232, 31, 252, 60, 44, 59, 20, 129, 60, 106, 213, 116, 100, 228, 76, 47, 46, 68, 8, 18, 219, 150, 110, 223, 37, 228, 188, 19, 32, 74, 121, 99, 74, 86, 18, 218, 191, 90, 146, 60, 156, 40, 88, 42, 96, 186, 121, 66, 0, 135, 71 } });

            migrationBuilder.AddForeignKey(
                name: "FK_CoderLanguages_LanguageLevels_LanguageLevelId",
                table: "CoderLanguages",
                column: "LanguageLevelId",
                principalTable: "LanguageLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoderTechnicalSkills_TechnicalSkillLevels_TechnicalSkillLev~",
                table: "CoderTechnicalSkills",
                column: "TechnicalSkillLevelId",
                principalTable: "TechnicalSkillLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

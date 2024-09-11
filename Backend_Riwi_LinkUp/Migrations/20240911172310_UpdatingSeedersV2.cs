using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Riwi_LinkUp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingSeedersV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoderSoftSkills",
                columns: new[] { "CoderId", "SoftSkillId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "LanguageLevels",
                columns: new[] { "Id", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "a1" },
                    { 2, 2, "a2" },
                    { 3, 3, "b1" },
                    { 4, 2, "b2" },
                    { 5, 3, "c1" },
                    { 6, 1, "c2" }
                });

            migrationBuilder.InsertData(
                table: "TechnicalSkillLevels",
                columns: new[] { "Id", "Name", "TechnicalSkillId" },
                values: new object[,]
                {
                    { 1, "junior", 1 },
                    { 2, "semi-senior", 2 },
                    { 3, "senior", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 69, 46, 212, 58, 113, 133, 5, 112, 189, 85, 33, 22, 105, 160, 122, 208, 60, 64, 221, 226, 245, 121, 179, 108, 223, 251, 176, 23, 187, 7, 180, 186, 102, 151, 133, 241, 98, 144, 14, 84, 255, 204, 164, 61, 13, 45, 148, 48, 233, 184, 45, 133, 243, 235, 220, 123, 80, 255, 76, 136, 48, 167, 193 }, new byte[] { 84, 114, 201, 231, 43, 117, 236, 122, 191, 26, 60, 185, 50, 188, 206, 180, 150, 80, 118, 178, 151, 10, 151, 17, 131, 42, 142, 201, 108, 193, 80, 47, 195, 126, 129, 191, 45, 62, 141, 105, 36, 107, 107, 151, 174, 122, 78, 142, 92, 136, 9, 136, 138, 204, 90, 26, 208, 182, 61, 171, 67, 5, 179, 75, 184, 86, 92, 171, 157, 10, 229, 67, 246, 74, 165, 116, 169, 75, 6, 157, 163, 69, 9, 97, 177, 245, 102, 7, 142, 222, 136, 126, 70, 67, 194, 153, 94, 144, 174, 198, 20, 222, 209, 121, 189, 142, 229, 41, 199, 189, 247, 49, 24, 52, 19, 72, 232, 53, 236, 245, 207, 91, 121, 190, 100, 183, 72, 4 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 183, 194, 242, 170, 86, 34, 252, 212, 170, 149, 196, 245, 63, 171, 217, 171, 144, 8, 109, 224, 118, 41, 219, 35, 157, 129, 226, 88, 207, 242, 171, 215, 112, 199, 223, 126, 9, 47, 30, 26, 187, 174, 62, 203, 226, 100, 157, 30, 1, 185, 226, 190, 194, 254, 97, 178, 142, 127, 57, 211, 133, 69, 221, 73 }, new byte[] { 170, 39, 19, 216, 240, 152, 52, 12, 158, 28, 246, 22, 150, 174, 189, 118, 1, 176, 225, 66, 216, 142, 31, 229, 93, 110, 43, 18, 170, 98, 45, 46, 234, 4, 209, 107, 235, 198, 145, 66, 163, 140, 136, 95, 50, 130, 154, 9, 170, 83, 121, 100, 140, 240, 236, 75, 201, 216, 220, 179, 171, 48, 114, 163, 216, 86, 108, 188, 85, 197, 31, 49, 123, 123, 47, 103, 65, 236, 212, 206, 253, 88, 86, 109, 148, 169, 215, 94, 51, 137, 2, 80, 56, 89, 199, 125, 13, 140, 78, 16, 67, 144, 199, 152, 86, 243, 67, 36, 5, 231, 173, 126, 226, 82, 157, 26, 149, 61, 116, 177, 207, 27, 6, 8, 90, 2, 136, 243 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 35, 106, 225, 187, 59, 13, 86, 188, 96, 248, 152, 96, 238, 40, 86, 161, 222, 255, 248, 226, 239, 230, 49, 136, 137, 33, 32, 115, 96, 212, 252, 189, 112, 17, 105, 17, 211, 225, 235, 141, 171, 71, 129, 116, 31, 148, 6, 118, 185, 9, 201, 150, 135, 206, 177, 60, 232, 155, 31, 61, 66, 137, 87, 169 }, new byte[] { 56, 77, 159, 74, 184, 55, 224, 241, 138, 94, 254, 71, 255, 52, 213, 221, 114, 93, 212, 54, 0, 61, 219, 225, 42, 72, 240, 180, 39, 238, 0, 111, 245, 210, 178, 6, 30, 4, 181, 235, 115, 97, 175, 41, 215, 51, 177, 24, 123, 231, 104, 117, 68, 32, 147, 125, 199, 189, 36, 84, 177, 88, 14, 54, 144, 3, 120, 59, 12, 36, 115, 252, 104, 197, 70, 56, 57, 217, 101, 63, 110, 119, 168, 181, 244, 34, 188, 0, 152, 127, 245, 222, 43, 143, 127, 149, 226, 196, 235, 10, 113, 140, 77, 109, 99, 69, 14, 180, 231, 1, 226, 244, 121, 14, 144, 106, 105, 96, 99, 235, 89, 146, 44, 38, 70, 250, 215, 3 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 33, 35, 236, 47, 127, 44, 5, 228, 227, 65, 245, 133, 131, 47, 11, 94, 35, 47, 254, 62, 230, 4, 77, 176, 141, 19, 62, 88, 114, 22, 109, 88, 123, 97, 49, 148, 150, 230, 95, 250, 37, 136, 179, 223, 241, 27, 64, 163, 70, 170, 160, 167, 154, 24, 250, 119, 210, 7, 0, 74, 127, 73, 69 }, new byte[] { 60, 159, 28, 98, 92, 181, 101, 34, 146, 128, 148, 146, 250, 84, 57, 41, 84, 207, 13, 239, 31, 232, 178, 80, 125, 42, 180, 23, 184, 116, 58, 161, 43, 161, 64, 41, 189, 28, 126, 170, 205, 12, 143, 111, 112, 78, 196, 72, 59, 24, 129, 68, 230, 83, 182, 156, 229, 135, 211, 233, 90, 120, 171, 166, 134, 84, 124, 61, 189, 136, 189, 54, 2, 226, 43, 52, 17, 143, 245, 98, 238, 22, 211, 226, 13, 126, 52, 84, 2, 179, 131, 218, 21, 199, 146, 208, 100, 235, 251, 18, 38, 41, 157, 237, 179, 212, 4, 88, 150, 136, 115, 172, 161, 240, 174, 134, 17, 125, 165, 145, 70, 122, 210, 60, 161, 26, 88, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 32, 65, 0, 43, 58, 167, 124, 106, 82, 232, 21, 117, 235, 186, 214, 206, 169, 67, 136, 79, 155, 4, 78, 190, 32, 97, 113, 194, 25, 35, 51, 90, 108, 109, 96, 254, 60, 72, 5, 177, 86, 134, 47, 61, 220, 104, 221, 113, 24, 25, 59, 3, 199, 223, 246, 118, 204, 98, 255, 194, 21, 168, 131, 235 }, new byte[] { 12, 15, 216, 93, 233, 19, 201, 127, 62, 143, 97, 34, 170, 250, 0, 202, 51, 126, 4, 222, 71, 189, 184, 167, 229, 116, 66, 119, 161, 216, 216, 246, 109, 18, 84, 143, 208, 81, 16, 235, 87, 61, 33, 127, 18, 231, 76, 187, 6, 66, 143, 245, 108, 221, 86, 85, 183, 60, 25, 14, 63, 56, 42, 223, 181, 103, 13, 3, 175, 60, 183, 135, 189, 199, 251, 167, 64, 166, 158, 27, 137, 40, 63, 59, 191, 61, 200, 207, 100, 96, 20, 182, 62, 1, 243, 100, 45, 29, 151, 229, 86, 56, 39, 39, 157, 216, 25, 255, 87, 109, 170, 69, 100, 175, 55, 191, 188, 210, 11, 131, 146, 237, 203, 82, 5, 142, 241, 207 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 69, 226, 137, 73, 30, 128, 1, 235, 213, 217, 18, 215, 61, 23, 85, 155, 191, 125, 150, 181, 147, 93, 17, 16, 213, 117, 119, 28, 163, 82, 6, 193, 162, 48, 35, 71, 248, 38, 200, 135, 202, 75, 177, 239, 4, 50, 212, 98, 0, 211, 18, 203, 172, 196, 93, 16, 101, 243, 120, 238, 89, 201, 82 }, new byte[] { 34, 245, 140, 116, 240, 63, 97, 179, 252, 54, 70, 168, 22, 87, 128, 180, 121, 31, 149, 106, 19, 65, 125, 192, 102, 136, 43, 97, 149, 54, 222, 205, 207, 165, 25, 106, 123, 120, 135, 95, 174, 65, 84, 98, 226, 205, 32, 150, 131, 55, 75, 11, 212, 93, 150, 95, 65, 252, 124, 47, 194, 131, 142, 81, 65, 159, 7, 153, 69, 39, 49, 182, 31, 246, 1, 217, 211, 172, 217, 242, 164, 138, 109, 143, 112, 99, 47, 21, 0, 237, 55, 102, 126, 24, 92, 43, 55, 26, 45, 183, 213, 173, 144, 87, 95, 15, 141, 167, 59, 86, 121, 72, 49, 70, 110, 23, 172, 189, 236, 218, 176, 101, 155, 188, 91, 252, 173, 221 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 188, 245, 176, 29, 36, 145, 68, 9, 179, 80, 195, 130, 6, 58, 100, 239, 89, 109, 80, 105, 110, 29, 17, 60, 111, 35, 75, 204, 145, 201, 135, 87, 113, 6, 108, 41, 181, 95, 76, 129, 194, 39, 182, 5, 7, 82, 10, 249, 169, 73, 70, 86, 217, 110, 175, 49, 153, 193, 68, 244, 240, 203, 219 }, new byte[] { 156, 235, 229, 21, 172, 194, 221, 76, 190, 163, 185, 129, 89, 25, 68, 243, 224, 20, 158, 60, 27, 137, 73, 152, 251, 148, 153, 90, 44, 208, 106, 137, 246, 56, 193, 32, 37, 18, 179, 245, 69, 92, 77, 151, 51, 123, 43, 225, 53, 245, 181, 221, 231, 148, 144, 34, 19, 6, 111, 159, 64, 106, 119, 53, 219, 88, 41, 231, 17, 243, 78, 83, 47, 31, 107, 26, 165, 58, 140, 15, 30, 60, 165, 60, 20, 176, 250, 238, 153, 199, 198, 175, 58, 196, 15, 159, 156, 170, 234, 219, 108, 123, 19, 255, 187, 189, 231, 2, 247, 189, 84, 122, 159, 8, 55, 34, 31, 222, 142, 189, 223, 141, 44, 29, 153, 121, 119, 209 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 114, 61, 106, 115, 254, 175, 148, 195, 22, 95, 28, 20, 178, 105, 74, 167, 190, 141, 212, 155, 79, 56, 13, 146, 173, 228, 60, 153, 53, 136, 82, 83, 0, 43, 200, 210, 152, 26, 149, 17, 85, 181, 89, 31, 121, 193, 76, 38, 5, 68, 21, 140, 178, 130, 213, 190, 46, 133, 126, 86, 71, 119, 236 }, new byte[] { 119, 45, 132, 241, 109, 60, 23, 221, 123, 205, 99, 255, 103, 60, 143, 244, 208, 130, 123, 21, 247, 80, 200, 174, 186, 10, 245, 42, 23, 28, 111, 198, 64, 102, 160, 249, 181, 87, 149, 37, 104, 24, 204, 188, 41, 4, 115, 164, 12, 30, 209, 184, 130, 67, 208, 211, 205, 243, 179, 220, 136, 87, 20, 248, 252, 204, 69, 70, 245, 225, 46, 153, 143, 197, 161, 131, 50, 219, 3, 76, 150, 114, 54, 19, 39, 240, 62, 137, 11, 72, 240, 93, 98, 35, 168, 10, 3, 135, 151, 61, 117, 195, 97, 182, 133, 39, 229, 240, 252, 233, 48, 12, 43, 25, 143, 187, 47, 56, 253, 7, 88, 44, 59, 224, 83, 72, 98, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 215, 105, 98, 10, 76, 234, 110, 208, 86, 55, 231, 5, 72, 51, 99, 170, 85, 140, 8, 26, 30, 134, 245, 234, 84, 217, 238, 183, 69, 232, 224, 255, 199, 201, 225, 161, 0, 137, 82, 252, 143, 165, 32, 129, 193, 208, 50, 72, 95, 171, 22, 201, 226, 175, 100, 31, 63, 147, 223, 176, 202, 28, 25, 199 }, new byte[] { 102, 63, 242, 108, 202, 39, 209, 160, 96, 134, 29, 20, 156, 110, 170, 29, 99, 248, 229, 98, 221, 112, 254, 137, 182, 112, 89, 159, 223, 7, 132, 220, 51, 140, 200, 66, 47, 29, 157, 99, 47, 67, 238, 115, 162, 240, 212, 13, 128, 221, 154, 159, 201, 68, 194, 210, 221, 242, 78, 77, 128, 224, 236, 136, 109, 222, 113, 242, 122, 148, 207, 118, 39, 216, 203, 173, 73, 171, 28, 208, 107, 41, 175, 63, 133, 106, 219, 76, 45, 15, 63, 51, 143, 10, 176, 121, 71, 217, 130, 219, 116, 24, 155, 187, 232, 38, 224, 111, 118, 218, 203, 72, 173, 135, 9, 170, 199, 219, 150, 209, 230, 22, 33, 85, 213, 227, 103, 112 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 84, 101, 121, 27, 252, 4, 226, 224, 191, 210, 95, 65, 102, 8, 64, 247, 60, 176, 30, 38, 1, 75, 149, 111, 68, 28, 135, 139, 171, 195, 42, 171, 247, 7, 171, 234, 8, 161, 244, 160, 190, 169, 161, 2, 64, 160, 16, 193, 11, 71, 144, 137, 32, 118, 101, 97, 109, 14, 127, 173, 42, 189, 83, 35 }, new byte[] { 247, 185, 199, 183, 184, 191, 180, 199, 254, 158, 49, 41, 221, 155, 211, 254, 194, 176, 202, 252, 97, 92, 44, 36, 130, 28, 31, 197, 193, 37, 207, 152, 66, 213, 51, 205, 192, 244, 157, 243, 130, 233, 22, 28, 51, 106, 250, 17, 46, 137, 21, 196, 34, 250, 63, 134, 240, 8, 167, 70, 169, 221, 234, 6, 104, 170, 152, 142, 149, 83, 127, 118, 26, 52, 58, 133, 236, 34, 142, 78, 121, 205, 110, 180, 96, 86, 198, 151, 164, 29, 94, 241, 190, 248, 152, 74, 63, 90, 208, 5, 221, 59, 157, 238, 107, 167, 38, 137, 137, 78, 96, 65, 43, 128, 134, 151, 178, 15, 145, 211, 138, 46, 99, 221, 234, 19, 51, 147 } });

            migrationBuilder.InsertData(
                table: "CoderLanguageLevels",
                columns: new[] { "CoderId", "LanguageLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 4 },
                    { 9, 6 },
                    { 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "CoderTechnicalSkillLevels",
                columns: new[] { "CoderId", "TechnicalSkillLevelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 1 },
                    { 5, 3 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "CoderLanguageLevels",
                keyColumns: new[] { "CoderId", "LanguageLevelId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CoderSoftSkills",
                keyColumns: new[] { "CoderId", "SoftSkillId" },
                keyValues: new object[] { 1, 1 });

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
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "CoderTechnicalSkillLevels",
                keyColumns: new[] { "CoderId", "TechnicalSkillLevelId" },
                keyValues: new object[] { 10, 3 });

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
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechnicalSkillLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 121, 20, 239, 9, 179, 38, 120, 135, 158, 251, 220, 207, 172, 144, 64, 127, 238, 55, 141, 9, 177, 228, 161, 100, 65, 177, 127, 178, 143, 253, 113, 12, 159, 212, 17, 124, 66, 54, 11, 245, 185, 198, 141, 68, 187, 47, 99, 182, 9, 19, 43, 158, 155, 37, 178, 215, 49, 31, 237, 146, 177, 61, 42, 246 }, new byte[] { 211, 220, 150, 37, 104, 29, 176, 94, 6, 137, 20, 134, 7, 251, 252, 167, 5, 154, 254, 81, 204, 7, 244, 133, 61, 68, 124, 139, 186, 119, 51, 173, 93, 228, 173, 217, 222, 127, 31, 114, 239, 20, 162, 152, 251, 6, 142, 16, 36, 111, 224, 130, 6, 84, 234, 133, 13, 226, 41, 138, 53, 14, 41, 113, 17, 140, 21, 82, 46, 216, 20, 237, 240, 22, 5, 2, 46, 151, 41, 230, 5, 89, 39, 139, 49, 57, 9, 14, 133, 20, 194, 163, 61, 17, 141, 4, 239, 213, 220, 183, 57, 60, 122, 231, 193, 223, 24, 186, 201, 202, 173, 5, 31, 187, 50, 35, 236, 219, 238, 205, 183, 231, 32, 233, 58, 178, 134, 101 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 152, 209, 223, 51, 75, 164, 121, 52, 9, 82, 75, 9, 142, 232, 0, 16, 32, 111, 251, 19, 187, 52, 57, 176, 201, 152, 139, 158, 37, 219, 238, 131, 186, 183, 10, 208, 56, 159, 46, 35, 233, 235, 165, 52, 113, 151, 220, 57, 2, 106, 105, 70, 35, 233, 243, 53, 41, 36, 197, 238, 182, 136, 116, 251 }, new byte[] { 185, 138, 226, 56, 249, 121, 203, 224, 21, 164, 187, 200, 69, 76, 52, 22, 140, 149, 240, 179, 52, 55, 188, 205, 10, 75, 187, 29, 217, 63, 137, 169, 121, 74, 125, 45, 16, 114, 173, 97, 63, 88, 141, 183, 96, 130, 225, 172, 244, 222, 63, 0, 41, 92, 174, 200, 230, 137, 192, 50, 113, 117, 88, 142, 70, 12, 27, 78, 26, 13, 95, 37, 149, 209, 181, 24, 162, 235, 82, 156, 65, 218, 103, 232, 189, 130, 147, 103, 33, 186, 205, 236, 220, 196, 120, 134, 193, 97, 89, 48, 0, 240, 125, 200, 123, 84, 189, 162, 156, 34, 139, 88, 212, 229, 64, 36, 192, 223, 15, 162, 133, 118, 75, 209, 228, 30, 246, 139 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 153, 61, 248, 140, 113, 164, 255, 15, 189, 149, 208, 98, 47, 198, 186, 12, 67, 114, 96, 195, 62, 10, 177, 212, 60, 38, 158, 170, 226, 89, 183, 194, 5, 69, 50, 83, 93, 136, 27, 38, 65, 200, 198, 138, 25, 84, 48, 138, 234, 151, 227, 211, 146, 27, 143, 173, 250, 14, 36, 146, 92, 64, 19 }, new byte[] { 165, 128, 170, 86, 112, 49, 28, 128, 186, 149, 161, 218, 218, 206, 250, 42, 101, 144, 123, 18, 216, 147, 11, 71, 19, 88, 121, 116, 202, 209, 140, 199, 219, 117, 42, 153, 160, 58, 178, 230, 96, 141, 201, 156, 125, 51, 42, 18, 60, 2, 168, 56, 69, 239, 71, 147, 188, 212, 73, 111, 215, 169, 198, 12, 245, 34, 139, 89, 11, 228, 173, 192, 26, 36, 121, 232, 73, 205, 249, 179, 188, 191, 2, 124, 221, 14, 224, 215, 133, 228, 196, 176, 25, 5, 190, 193, 194, 200, 147, 29, 12, 142, 175, 116, 212, 69, 2, 36, 198, 51, 50, 228, 70, 209, 223, 144, 30, 35, 110, 239, 36, 215, 164, 162, 112, 211, 227, 67 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 111, 219, 141, 168, 159, 2, 65, 137, 120, 65, 5, 80, 5, 31, 214, 17, 255, 192, 98, 182, 106, 124, 195, 225, 30, 10, 208, 75, 110, 162, 81, 217, 182, 207, 50, 157, 103, 35, 202, 114, 96, 254, 239, 58, 47, 187, 74, 14, 23, 1, 69, 117, 245, 220, 73, 91, 232, 92, 193, 173, 16, 221, 230, 189 }, new byte[] { 4, 78, 180, 246, 241, 143, 38, 154, 193, 98, 15, 139, 238, 41, 127, 166, 238, 175, 112, 188, 239, 41, 253, 102, 20, 119, 134, 95, 103, 222, 203, 97, 60, 46, 243, 244, 57, 252, 12, 163, 138, 139, 244, 78, 137, 86, 74, 239, 124, 141, 39, 156, 48, 85, 209, 231, 212, 90, 105, 175, 7, 51, 164, 188, 136, 155, 172, 64, 167, 101, 237, 101, 220, 242, 214, 212, 183, 149, 23, 62, 100, 47, 174, 113, 7, 77, 117, 157, 113, 43, 62, 16, 68, 188, 213, 164, 61, 13, 160, 131, 111, 255, 45, 186, 84, 142, 115, 2, 102, 195, 226, 131, 18, 109, 36, 77, 137, 25, 139, 148, 173, 7, 93, 220, 136, 7, 52, 251 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 224, 185, 41, 64, 146, 134, 77, 173, 219, 220, 99, 152, 169, 90, 147, 179, 109, 218, 46, 17, 123, 42, 76, 104, 173, 188, 139, 124, 239, 44, 169, 176, 110, 250, 36, 97, 42, 135, 213, 183, 65, 173, 64, 185, 126, 190, 120, 145, 88, 51, 180, 21, 139, 251, 0, 140, 213, 137, 85, 235, 214, 132, 185, 55 }, new byte[] { 47, 96, 47, 180, 131, 132, 77, 68, 116, 255, 231, 58, 108, 195, 250, 251, 149, 32, 87, 83, 70, 102, 102, 173, 87, 253, 207, 153, 152, 105, 128, 72, 4, 254, 44, 215, 254, 16, 73, 243, 81, 103, 172, 19, 249, 177, 121, 128, 99, 45, 109, 93, 37, 91, 89, 32, 140, 196, 192, 101, 55, 199, 162, 2, 145, 113, 251, 34, 34, 139, 135, 208, 150, 214, 136, 231, 118, 170, 9, 48, 16, 255, 202, 167, 182, 209, 250, 108, 68, 40, 12, 209, 216, 140, 220, 66, 210, 204, 109, 12, 199, 39, 242, 19, 95, 130, 206, 249, 70, 144, 158, 195, 35, 202, 239, 206, 178, 255, 213, 157, 33, 216, 114, 148, 10, 156, 211, 68 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 35, 43, 18, 14, 240, 121, 118, 171, 219, 86, 200, 40, 179, 205, 144, 5, 154, 238, 11, 232, 40, 110, 207, 254, 225, 31, 37, 225, 239, 218, 65, 146, 44, 180, 75, 34, 46, 208, 168, 123, 106, 249, 84, 205, 93, 111, 14, 99, 2, 232, 212, 187, 166, 157, 106, 240, 26, 215, 3, 26, 125, 118, 2, 80 }, new byte[] { 156, 226, 6, 189, 161, 164, 131, 113, 248, 133, 193, 169, 146, 135, 20, 10, 230, 174, 118, 8, 238, 204, 112, 249, 45, 61, 197, 198, 60, 165, 246, 161, 67, 100, 3, 246, 82, 183, 85, 202, 183, 25, 251, 43, 254, 53, 31, 204, 30, 143, 51, 50, 30, 134, 133, 255, 127, 130, 239, 63, 32, 114, 92, 212, 126, 140, 149, 79, 15, 144, 242, 191, 242, 112, 37, 90, 83, 109, 137, 43, 166, 118, 90, 40, 119, 70, 138, 53, 82, 209, 53, 88, 19, 156, 204, 44, 196, 108, 77, 35, 205, 166, 41, 69, 84, 252, 211, 221, 241, 164, 23, 85, 47, 241, 137, 207, 147, 122, 119, 238, 179, 44, 201, 57, 143, 3, 78, 254 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 242, 51, 202, 3, 14, 168, 54, 25, 92, 35, 88, 46, 81, 207, 103, 27, 41, 251, 37, 155, 32, 159, 8, 242, 241, 231, 21, 198, 213, 171, 172, 11, 238, 171, 244, 110, 149, 169, 58, 172, 229, 245, 224, 114, 100, 89, 105, 184, 232, 90, 209, 220, 212, 170, 39, 130, 23, 209, 74, 10, 36, 200, 51 }, new byte[] { 70, 164, 144, 220, 42, 95, 206, 135, 210, 140, 17, 160, 43, 86, 119, 247, 243, 110, 49, 159, 125, 165, 159, 212, 141, 126, 85, 1, 19, 230, 62, 134, 85, 248, 144, 32, 69, 133, 132, 110, 175, 127, 108, 212, 124, 211, 54, 63, 94, 111, 93, 152, 132, 148, 74, 218, 85, 63, 57, 113, 135, 75, 218, 5, 167, 246, 109, 178, 79, 23, 52, 167, 146, 213, 87, 75, 188, 238, 89, 46, 206, 77, 169, 95, 240, 58, 216, 239, 52, 179, 195, 232, 183, 227, 65, 204, 92, 134, 108, 146, 234, 61, 110, 143, 127, 192, 203, 46, 33, 206, 20, 75, 52, 10, 207, 178, 222, 190, 156, 145, 129, 29, 183, 73, 225, 95, 125, 36 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 176, 171, 148, 175, 217, 192, 91, 119, 5, 129, 0, 59, 197, 136, 69, 45, 183, 117, 19, 174, 55, 138, 229, 99, 74, 148, 242, 100, 52, 119, 239, 130, 243, 95, 172, 221, 214, 148, 196, 85, 116, 125, 96, 161, 115, 200, 83, 51, 70, 104, 43, 6, 175, 16, 11, 164, 230, 171, 172, 98, 46, 31, 180 }, new byte[] { 248, 228, 9, 102, 111, 165, 93, 20, 76, 211, 52, 188, 73, 203, 201, 234, 219, 208, 170, 8, 134, 156, 168, 23, 201, 141, 112, 178, 3, 229, 139, 185, 208, 170, 36, 148, 141, 230, 184, 120, 53, 91, 58, 111, 204, 162, 94, 66, 216, 71, 146, 238, 131, 182, 77, 90, 30, 86, 123, 139, 251, 87, 166, 161, 56, 222, 35, 228, 123, 75, 204, 160, 213, 220, 128, 185, 19, 40, 138, 101, 178, 109, 19, 86, 40, 123, 125, 121, 97, 98, 232, 101, 209, 49, 167, 172, 186, 27, 97, 121, 248, 250, 87, 92, 121, 196, 139, 203, 220, 179, 173, 243, 124, 83, 205, 253, 120, 1, 174, 252, 55, 75, 89, 238, 50, 75, 169, 139 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 174, 236, 102, 196, 195, 167, 27, 173, 191, 77, 216, 250, 44, 13, 155, 148, 68, 118, 124, 68, 143, 75, 159, 64, 96, 204, 243, 64, 168, 16, 241, 140, 255, 54, 113, 57, 171, 137, 201, 106, 7, 147, 9, 74, 67, 238, 98, 210, 168, 27, 212, 232, 134, 135, 24, 97, 7, 60, 137, 60, 190, 55, 149 }, new byte[] { 76, 78, 131, 13, 134, 207, 171, 131, 83, 16, 144, 137, 243, 225, 25, 7, 148, 20, 246, 150, 20, 251, 32, 251, 97, 203, 36, 187, 173, 253, 43, 63, 33, 217, 181, 243, 78, 118, 67, 211, 42, 227, 78, 33, 116, 73, 209, 108, 85, 184, 246, 201, 125, 245, 134, 116, 255, 48, 129, 243, 81, 63, 178, 140, 56, 196, 181, 177, 142, 160, 249, 248, 160, 161, 47, 201, 70, 52, 201, 230, 158, 91, 45, 41, 83, 49, 183, 249, 174, 73, 139, 77, 119, 211, 233, 10, 231, 200, 217, 253, 97, 16, 180, 104, 7, 177, 58, 62, 121, 166, 82, 69, 63, 185, 77, 193, 165, 243, 2, 68, 77, 41, 106, 222, 232, 210, 151, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 129, 224, 180, 226, 76, 25, 153, 106, 88, 126, 45, 42, 225, 28, 173, 153, 243, 195, 68, 155, 198, 179, 173, 73, 49, 223, 183, 120, 104, 169, 3, 51, 84, 209, 32, 103, 164, 46, 33, 88, 193, 254, 226, 87, 45, 235, 30, 236, 122, 213, 120, 200, 249, 170, 239, 47, 93, 101, 25, 156, 3, 244, 16 }, new byte[] { 87, 78, 46, 44, 174, 132, 251, 251, 209, 33, 180, 94, 91, 60, 110, 151, 109, 64, 218, 124, 73, 46, 3, 17, 123, 234, 9, 67, 233, 30, 220, 121, 18, 42, 192, 198, 239, 186, 222, 192, 79, 86, 75, 98, 206, 235, 101, 57, 206, 226, 193, 58, 176, 115, 149, 95, 95, 156, 255, 196, 54, 226, 53, 150, 207, 0, 166, 114, 80, 107, 102, 105, 123, 5, 195, 219, 252, 134, 179, 122, 28, 43, 235, 228, 91, 67, 63, 26, 102, 174, 90, 81, 120, 236, 2, 103, 233, 145, 40, 215, 144, 119, 95, 74, 120, 220, 38, 58, 162, 19, 124, 180, 163, 148, 42, 224, 25, 184, 43, 107, 87, 86, 184, 45, 232, 202, 104, 175 } });
        }
    }
}

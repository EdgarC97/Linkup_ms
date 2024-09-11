using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_Riwi_LinkUp.Migrations
{
    /// <inheritdoc />
    public partial class AddingLastSeeders : Migration
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
        }
    }
}

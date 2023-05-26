using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class SeedProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrgPrograms",
                columns: new[] { "ProgramId", "Name" },
                values: new object[,]
                {
                    { 100, "Sponsorship" },
                    { 101, "Scholarship" },
                    { 102, "General" },
                    { 103, "Community Outreach" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrgPrograms",
                keyColumn: "ProgramId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "OrgPrograms",
                keyColumn: "ProgramId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "OrgPrograms",
                keyColumn: "ProgramId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "OrgPrograms",
                keyColumn: "ProgramId",
                keyValue: 103);
        }
    }
}

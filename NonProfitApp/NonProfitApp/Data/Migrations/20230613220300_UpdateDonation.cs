using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class UpdateDonation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_ProgramId",
                table: "Donations");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Donors",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrgProgramProgramId",
                table: "Donations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_OrgProgramProgramId",
                table: "Donations",
                column: "OrgProgramProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_OrgPrograms_OrgProgramProgramId",
                table: "Donations",
                column: "OrgProgramProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_OrgPrograms_OrgProgramProgramId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_OrgProgramProgramId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "OrgProgramProgramId",
                table: "Donations");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_ProgramId",
                table: "Donations",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations",
                column: "ProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId");
        }
    }
}

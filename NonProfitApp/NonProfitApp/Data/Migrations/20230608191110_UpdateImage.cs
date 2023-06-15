using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class UpdateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Fundraisers_FundraiserId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "OrgProgramProgramId",
                table: "FundraiserPrograms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ImageLocation",
                table: "Donors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "FundraiserId",
                table: "Donations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Fundraisers_FundraiserId",
                table: "Donations",
                column: "FundraiserId",
                principalTable: "Fundraisers",
                principalColumn: "FundraiserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms",
                column: "OrgProgramProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Fundraisers_FundraiserId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.AlterColumn<int>(
                name: "OrgProgramProgramId",
                table: "FundraiserPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageLocation",
                table: "Donors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FundraiserId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Fundraisers_FundraiserId",
                table: "Donations",
                column: "FundraiserId",
                principalTable: "Fundraisers",
                principalColumn: "FundraiserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms",
                column: "OrgProgramProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

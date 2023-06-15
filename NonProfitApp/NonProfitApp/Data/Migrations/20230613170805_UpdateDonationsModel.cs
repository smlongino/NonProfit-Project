using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class UpdateDonationsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Channels_ChannelId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Donations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChannelId",
                table: "Donations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Channels_ChannelId",
                table: "Donations",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "ChannelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations",
                column: "ProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Channels_ChannelId",
                table: "Donations");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChannelId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Channels_ChannelId",
                table: "Donations",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "ChannelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_OrgPrograms_ProgramId",
                table: "Donations",
                column: "ProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

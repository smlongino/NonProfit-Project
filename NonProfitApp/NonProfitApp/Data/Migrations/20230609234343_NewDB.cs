using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "OrgPrograms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Fundraisers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Channels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "OrgPrograms");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Fundraisers");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Channels");
        }
    }
}

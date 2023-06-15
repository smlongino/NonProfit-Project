using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class DeleteImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocation",
                table: "Donors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLocation",
                table: "Donors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}

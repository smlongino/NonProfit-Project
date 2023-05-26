using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class SeedDonor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Donors",
                columns: new[] { "DonorId", "City", "Company", "Email", "FirstName", "LastName", "Phone", "State", "StreetAddress", "Zip" },
                values: new object[,]
                {
                    { 1, "Seattle", null, "j.smith@gmail.com", "Jess", "Smith", "256-555-9874", "WA", "4548 South St", "98109" },
                    { 2, "Renton", null, "cristy@gmail.com", "Cristy", "Johnson", "255-879-5555", "WA", "300 Long St", "98056" },
                    { 3, "Bellingham", null, "cjames@yahoo.com", "Carl", "James", "256-548-9910", "WA", "98451 J Place W", "98897" },
                    { 4, "Buffalo", null, "jmsanders@hotmail.com", "John", "Sanders", "888-555-1010", "NY", "46757 College Way", "26544" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "DonorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "DonorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "DonorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "DonorId",
                keyValue: 4);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class SeedDonations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "ChannelId", "DonationAmount", "DonationDate", "DonorId", "FundraiserId", "ProgramId" },
                values: new object[,]
                {
                    { 100, 4, 3000.00m, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000, 100 },
                    { 101, 3, 500.50m, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1001, 101 },
                    { 102, 1, 1000.00m, new DateTime(2022, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1002, 103 },
                    { 103, 2, 10000.88m, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1002, 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 103);
        }
    }
}

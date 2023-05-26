using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class SeedFundraiser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fundraisers",
                columns: new[] { "FundraiserId", "EndDate", "FundraiserName", "StartDate" },
                values: new object[] { 1000, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023 Gala", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Fundraisers",
                columns: new[] { "FundraiserId", "EndDate", "FundraiserName", "StartDate" },
                values: new object[] { 1001, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022 GiveBig", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Fundraisers",
                columns: new[] { "FundraiserId", "EndDate", "FundraiserName", "StartDate" },
                values: new object[] { 1002, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2021 Giving Tuesday", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fundraisers",
                keyColumn: "FundraiserId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Fundraisers",
                keyColumn: "FundraiserId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Fundraisers",
                keyColumn: "FundraiserId",
                keyValue: 1002);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_ProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.DropIndex(
                name: "IX_FundraiserPrograms_ProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 5);

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

            migrationBuilder.DeleteData(
                table: "Donors",
                keyColumn: "DonorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrgPrograms",
                keyColumn: "ProgramId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "ChannelId",
                keyValue: 4);

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
                keyValue: 4);

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
                keyValue: 103);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OrgPrograms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FundraiserName",
                table: "Fundraisers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "OrgProgramProgramId",
                table: "FundraiserPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<decimal>(
                name: "DonationAmount",
                table: "Donations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ChannelType",
                table: "Channels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateIndex(
                name: "IX_FundraiserPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms",
                column: "OrgProgramProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms",
                column: "OrgProgramProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.DropIndex(
                name: "IX_FundraiserPrograms_OrgProgramProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.DropColumn(
                name: "OrgProgramProgramId",
                table: "FundraiserPrograms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OrgPrograms",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FundraiserName",
                table: "Fundraisers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Donors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetAddress",
                table: "Donors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Donors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Donors",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Donors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Donors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Donors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "Donors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Donors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DonationAmount",
                table: "Donations",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ChannelType",
                table: "Channels",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "ChannelId", "ChannelType" },
                values: new object[,]
                {
                    { 1, "Facebook" },
                    { 2, "Direct Mail" },
                    { 3, "Email" },
                    { 4, "Event" },
                    { 5, "Search" }
                });

            migrationBuilder.InsertData(
                table: "Donors",
                columns: new[] { "DonorId", "Active", "City", "Company", "Email", "FirstName", "LastName", "Phone", "State", "StreetAddress", "Zip" },
                values: new object[,]
                {
                    { 1, false, "Seattle", null, "j.smith@gmail.com", "Jess", "Smith", "256-555-9874", "WA", "4548 South St", "98109" },
                    { 2, false, "Renton", null, "cristy@gmail.com", "Cristy", "Johnson", "255-879-5555", "WA", "300 Long St", "98056" },
                    { 3, false, "Bellingham", null, "cjames@yahoo.com", "Carl", "James", "256-548-9910", "WA", "98451 J Place W", "98897" },
                    { 4, false, "Buffalo", null, "jmsanders@hotmail.com", "John", "Sanders", "888-555-1010", "NY", "46757 College Way", "26544" }
                });

            migrationBuilder.InsertData(
                table: "Fundraisers",
                columns: new[] { "FundraiserId", "EndDate", "FundraiserName", "StartDate" },
                values: new object[,]
                {
                    { 1000, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023 Gala", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1001, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "2022 GiveBig", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1002, new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2021 Giving Tuesday", new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FundraiserPrograms_ProgramId",
                table: "FundraiserPrograms",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_FundraiserPrograms_OrgPrograms_ProgramId",
                table: "FundraiserPrograms",
                column: "ProgramId",
                principalTable: "OrgPrograms",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

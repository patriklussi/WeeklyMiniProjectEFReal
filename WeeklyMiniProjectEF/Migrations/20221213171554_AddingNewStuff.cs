using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "CurrencyType", "OfficeName" },
                values: new object[,]
                {
                    { 1, "SEK", "Sweden" },
                    { 2, "USD", "USA" },
                    { 3, "EUR", "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetType", "Model", "Name", "OfficeId", "PurchaseDate", "PurchasePrice" },
                values: new object[,]
                {
                    { 1, "Phone", "S20", "Samsung", 1, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 214551 },
                    { 2, "Laptop", "LG5", "Lenovo", 2, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25144151 },
                    { 3, "Computer", "D0nkey", "Taurus", 3, new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1546 },
                    { 4, "Computer", "Monkey", "Cooler master", 3, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 51951959 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

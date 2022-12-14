using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addedPhonesAndLaptops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Model", "Name", "purchaseDate" },
                values: new object[,]
                {
                    { 1, "G42", "Taurus", new DateTime(2018, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "2", "OfficePC", new DateTime(2011, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "3", "OfficePC", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Model", "Name", "purchaseDate" },
                values: new object[,]
                {
                    { 1, "ROG", "Asus", new DateTime(2018, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Thunderstorm", "Lenovo", new DateTime(2015, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Elitebook", "HP", new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

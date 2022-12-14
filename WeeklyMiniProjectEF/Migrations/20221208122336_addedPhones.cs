using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addedPhones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Model", "Name", "purchaseDate" },
                values: new object[,]
                {
                    { 1, "5s", "Iphone", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "S20", "Samsung", new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Xperia 5s", "Sony", new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

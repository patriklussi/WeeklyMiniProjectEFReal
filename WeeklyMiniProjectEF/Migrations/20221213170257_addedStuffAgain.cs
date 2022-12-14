using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addedStuffAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetType", "Model", "Name", "OfficeId", "PurchaseDate", "PurchasePrice" },
                values: new object[] { 4, "Computer", "Monkey", "Cooler master", 3, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 51951959 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

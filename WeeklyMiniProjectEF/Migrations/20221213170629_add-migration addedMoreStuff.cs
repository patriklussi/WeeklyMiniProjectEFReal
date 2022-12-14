using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationaddedMoreStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "Name", "PurchasePrice" },
                values: new object[] { "S20", "Samsung", 214551 });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "Name", "PurchasePrice" },
                values: new object[] { "LG5", "Lenovo", 25144151 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Model", "Name", "PurchasePrice" },
                values: new object[] { "5s", "Iphone", 256 });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Model", "Name", "PurchasePrice" },
                values: new object[] { "Elitebook", "HP", 2551 });
        }
    }
}

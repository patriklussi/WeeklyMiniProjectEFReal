using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addedStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "purchaseDate",
                table: "Assets",
                newName: "PurchaseDate");

            migrationBuilder.AddColumn<int>(
                name: "PurchasePrice",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchasePrice",
                value: 256);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchasePrice",
                value: 2551);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchasePrice",
                value: 1546);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Assets");

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Assets",
                newName: "purchaseDate");
        }
    }
}

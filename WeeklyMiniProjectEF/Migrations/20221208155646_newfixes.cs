using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class newfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "OfficeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OfficeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "OfficeId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_OfficeId",
                table: "Assets",
                column: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Offices_OfficeId",
                table: "Assets",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Offices_OfficeId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_OfficeId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Assets");
        }
    }
}

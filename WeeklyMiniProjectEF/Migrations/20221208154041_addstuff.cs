using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeeklyMiniProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class addstuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeGermany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeGermany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeSweden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeSweden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeUSA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeUSA", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetType", "Model", "Name", "purchaseDate" },
                values: new object[,]
                {
                    { 1, "Phone", "5s", "Iphone", new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Laptop", "Elitebook", "HP", new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Computer", "Donkey", "Taurus", new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "OfficeGermany");

            migrationBuilder.DropTable(
                name: "OfficeSweden");

            migrationBuilder.DropTable(
                name: "OfficeUSA");

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

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
    }
}

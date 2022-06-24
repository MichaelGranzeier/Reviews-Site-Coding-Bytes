using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class addview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeGroup",
                table: "SchoolSupplies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SchoolSupplies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SchoolSupplies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "SupplyType",
                table: "SchoolSupplies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Opinions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Positive = table.Column<bool>(type: "bit", nullable: false),
                    SchoolSupplyId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_SchoolSupplies_SchoolSupplyId",
                        column: x => x.SchoolSupplyId,
                        principalTable: "SchoolSupplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Author", "Opinions", "Positive", "Postdate", "Rating", "SchoolSupplyId" },
                values: new object[,]
                {
                    { 1, "Thomas", "Very Sharp!", true, new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5138), 4, 1 },
                    { 2, "Michael", "Very Cheap!", false, new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5175), 1, 2 },
                    { 3, "Dina", "Strudy", true, new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5177), 5, 3 },
                    { 4, "Michael", "Good Quality", true, new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5180), 5, 4 },
                    { 5, "Dina", "Fantastic!!", true, new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5182), 5, 5 }
                });

            migrationBuilder.UpdateData(
                table: "SchoolSupplies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Triangular and fun!", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "SchoolSupplies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgeGroup", "Description", "Price" },
                values: new object[] { 1, "Filled with ink!", 1.99 });

            migrationBuilder.UpdateData(
                table: "SchoolSupplies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AgeGroup", "Description", "Price", "SupplyType" },
                values: new object[] { 2, "durable and indestructible", 10.0, 1 });

            migrationBuilder.UpdateData(
                table: "SchoolSupplies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AgeGroup", "Description", "Price", "SupplyType" },
                values: new object[] { 3, "Calculator", 200.0, 2 });

            migrationBuilder.UpdateData(
                table: "SchoolSupplies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AgeGroup", "Description", "Price", "SupplyType" },
                values: new object[] { 4, "Durable and strong", 50.0, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SchoolSupplyId",
                table: "Reviews",
                column: "SchoolSupplyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "SchoolSupplies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SchoolSupplies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SchoolSupplies");

            migrationBuilder.DropColumn(
                name: "SupplyType",
                table: "SchoolSupplies");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class addEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 14, 36, 59, 884, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 14, 36, 59, 884, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 14, 36, 59, 884, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 14, 36, 59, 884, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 14, 36, 59, 884, DateTimeKind.Local).AddTicks(4397));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Postdate",
                value: new DateTime(2022, 6, 24, 11, 55, 29, 419, DateTimeKind.Local).AddTicks(5182));
        }
    }
}

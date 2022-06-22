using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolSupplies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SchoolSupplies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ticonderoga Pencil" },
                    { 2, "Bic Pen" },
                    { 3, "5 star" },
                    { 4, "Texas Insturment" },
                    { 5, "LL Bean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolSupplies");
        }
    }
}

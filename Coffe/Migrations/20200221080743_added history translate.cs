using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class addedhistorytranslate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Histories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRu",
                table: "Histories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionEn", "DescriptionRu" },
                values: new object[] { "History", "История" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "DescriptionRu",
                table: "Histories");
        }
    }
}

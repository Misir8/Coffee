using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class addedvaluetranslate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Values",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRu",
                table: "Values",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionEn", "DescriptionRu" },
                values: new object[] { "Value", "Ценности" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Values");

            migrationBuilder.DropColumn(
                name: "DescriptionRu",
                table: "Values");
        }
    }
}

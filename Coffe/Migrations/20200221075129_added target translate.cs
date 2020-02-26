using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class addedtargettranslate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Targets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRu",
                table: "Targets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionEn", "DescriptionRu" },
                values: new object[] { "Purpose and mission english", "Цель на русском" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Targets");

            migrationBuilder.DropColumn(
                name: "DescriptionRu",
                table: "Targets");
        }
    }
}

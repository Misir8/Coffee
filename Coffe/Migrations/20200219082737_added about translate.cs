using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class addedabouttranslate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnDescription",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RuDescription",
                table: "Abouts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EnDescription", "RuDescription" },
                values: new object[] { "Englis about", "На русском" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnDescription",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "RuDescription",
                table: "Abouts");
        }
    }
}

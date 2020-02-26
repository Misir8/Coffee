using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class addednewstranslate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "Newses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentRu",
                table: "Newses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "Newses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleRu",
                table: "Newses",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContentEn", "ContentRu", "TitleEn", "TitleRu" },
                values: new object[] { "English content", "Rus content", "English", "Rus" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ContentEn", "ContentRu", "TitleEn", "TitleRu" },
                values: new object[] { "English content", "Rus content", "English", "Rus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "ContentRu",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "TitleRu",
                table: "Newses");
        }
    }
}

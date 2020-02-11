using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class Abouts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "“MY ENTERPRISE” Məhdud Məsuliyyətli Cəmiyyət 2019_cu ildə təsis edilmişdir. Müəssisə hal_hazırda öz fəaliyyət sahəsi istiqamətində, ilkin olaraq, Azərbaycan bazarında əhəmiyyətli yer tutmağı planlaşdırır.	“MY ENTERPRISE” MMC_də coxillik iş təcrübəsinə malik, ixtisaslaşmış işçilər çalışmaqdadır. Əsas fəaliyyət sahəsi isə yerli istehsalat və distribusiyadır (dağıtımdır).", "Biz kimik?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}

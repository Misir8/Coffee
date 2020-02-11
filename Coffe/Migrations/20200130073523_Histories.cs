using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class Histories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "2019 - \"MY ENTERPRISE\" MMC fəaliyyətə başlamışdır.Müəssisəmizdə yüksək səviyyəli iş şəraiti, eləcə də davamlı inkişaf üçün böyük potensiallı maddi-texniki baza yaradılmışdır.2019 - Müəssisə ilkin olaraq \"My Coffee\" markasının məhsulları olan \"My Cappuccino\", \"My Original\" çeşidlərini öz alıcılarının istifadəsinə təqdim etdi.2019 Müəssisə il sonunadək \"My Coffee\" markasının digər məhsulları olan \"My Coffee 3in1\", \"My Chocolate\" çeşidlərini öz alıcılarının istifadəsinə təqdim etməyi planlaşdırır." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");
        }
    }
}

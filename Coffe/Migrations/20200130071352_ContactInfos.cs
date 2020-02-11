using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class ContactInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Info = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "Info" },
                values: new object[] { 1, "<span>Phone : </span>(+994 55) 455 66 88" });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "Info" },
                values: new object[] { 2, "<span>Email :</span>Info@myenterprise.az" });

            migrationBuilder.InsertData(
                table: "ContactInfos",
                columns: new[] { "Id", "Info" },
                values: new object[] { 3, "<span>Address :</span>AZ5000, Azərbaycan Respublikası, Sumqayıt şəhəri, Sənaye zonası, Sülh küçəsi, 76-cı məhəllə, 106 b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInfos");
        }
    }
}

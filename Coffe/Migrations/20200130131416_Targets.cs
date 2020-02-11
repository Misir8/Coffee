using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class Targets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "“MY ENTERPRISE” MMC_nin ( müəssisəsinin ) yaradılmasında ən başlıca məqsəd və missiya,yerli məhsulların davamlı istehsalı, xarici bazarlara rəqabət qabiliyyətli məhsullar istehsal edib ixrac etməkdir. Habelə, dünya texnologiya standartlarına əsaslanan yüksək keyfiyyətli məhsullar istehsal edərək, yerli istehsalı gücləndirmək,Azərbaycan bazarında mövcud olan bütün ticarət nöqtələrinə yüksək keyfiyyətli satış xidmətləri göstərərək,tutduğumuz yolda son və ən müasir vasitələrə istinadən, məqsədimizə və missiyamıza çatmaqdır.“MY ENTERPRISE” ailəsi olaraq, yeniliklərə hər zaman açıq olmaq, qloballaşan dünyada rəqabətə davamlı bir şirkət olmaq üçün daima çalışmağın vəən son innovasiyaların tətbiqinin zəruri olduğunu dərk etmək və bu yolda heç bir səylərimizi əsirgəməməkdir.Biz yalnız bazardakı payımızı deyil, ürəklərdəki sevgi payımızı da artıraraq, istehlakçıların rəğbətini qazamağa önəm veririk!Prioritetimiz - Istehlakçıların maraqlarının təminidir!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Targets");
        }
    }
}

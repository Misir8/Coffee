using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class Values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Biz müştərilərimizə düzgün şəkildə xidmət göstərə bilmək üçün, dürüstük və güclü mənəvi prinsiplərə əsaslanan, işimizi yüksək məsuliyyət hissi ilə görərək, cavabdehlik daşıyan bir yerli müəssisəyik. Bundan başqa dəyərlərimizi yaşatmaqla, inkişafımız və peşəkar fəaliyyətimiz, davranışlarımız, təqdim etdiyimiz məhsul və xidmətlərimizlə nümunəvi olmağı özümüzə vəzifə bilirik. Habelə, daima böyümək, yeni bazarlarda təmsil olunmaq və istehsal etdiyimiz məhsul çeşidlərini artırmaq iqtidarındayıq. Yaradılmış müəsisədə, əhval-ruhiyyənin ən yüksək səviyyədə olması üçün, hər zaman bir-birimizə hörmət və ehtiramla yanaşırıq." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}

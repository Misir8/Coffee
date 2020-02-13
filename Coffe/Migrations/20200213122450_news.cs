using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Newses",
                columns: new[] { "Id", "Content", "Image", "Title" },
                values: new object[] { 1, "“Zeytun yağının keyfiyyətli olmasını necə müəyyən edək?” sualının cavabını, ümumilikdə, dad, qoxu və rəng kimi xüsusiyyətlərə baxaraq tapmağa çalışırıq. Unutmaq olmaz ki, bu xüsusiyyətlərə görə zeytun yağını seçmək aldadıcı ola bilir. Çünki duyğu üzvlərimiz bizi yanılda bilir və yuxarıda qeyd olunanlar təkbaşına keyfiyyət müəyyən edən amil deyildir. Hətta vurğulamaq lazımdır ki, gözümüzün axtardığı o yaşıl zeytun yağı görüntüsü bizi ən çox aldadan faktordur.  Sizin də bugünə qədər “həqiqi zeytun yağı yaşıl olur” fikri ilə seçim etdiyiniz zeytun yağı haqqındakı doğru bilinən bu yanlışa gəlin birlikdə aydınlıq gətirək.", "medium_ag-olan592.png", "Əsl zeytun yağının rəngi necə olmalıdır?" });

            migrationBuilder.InsertData(
                table: "Newses",
                columns: new[] { "Id", "Content", "Image", "Title" },
                values: new object[] { 2, "Dünyaca məşhur türk qəhvəsi brendi olan Kurukahveci Mehmet Efendi 24-26 yanvar tarixlərində keçirilən Bakı qəhvə və çay festivalında iştirak etdi. Festival müddətində iştirakçılar türk qəhvəsinin dadına baxaraq 19-cu əsrdən bəri fəaliyyət göstərən brend haqqında, eləcə də, türk qəhvəsinin hazırlanma qaydası haqqında geniş informasiya əldə etdilər. 1871-ci ildən bu günə qədər qəhvə istehsalına bir incəsənət kimi yanaşan “Kurukahveci Mehmet Efendi” dünyanın bir çox ölkəsində - Asiya, Avropa, Amerika və Avstraliya qitələri daxil ən çox istifadə olunan türk qəhvəsi brendidir.əzərinizə çatdıraq ki, Mehmet Efendi markasının ölkə üzrə rəsmi distribütoru Şam-Fi MMC-dir.", null, "Kurukahveci Mehmet Efendi Bakı qəhvə və çay festivalında iştirak etdi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Newses");
        }
    }
}

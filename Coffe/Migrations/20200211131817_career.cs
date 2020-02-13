using Microsoft.EntityFrameworkCore.Migrations;

namespace Coffe.Migrations
{
    public partial class career : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    BirthDay = table.Column<string>(nullable: false),
                    BirthMonth = table.Column<string>(nullable: false),
                    BirthYear = table.Column<string>(nullable: false),
                    BirthCity = table.Column<string>(nullable: false),
                    isArmy = table.Column<bool>(nullable: true),
                    Married = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: false),
                    OthersNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    DriverLicense = table.Column<string>(nullable: true),
                    isCar = table.Column<bool>(nullable: true),
                    isPreviousJob = table.Column<bool>(nullable: true),
                    PositionApply = table.Column<string>(nullable: false),
                    VacancyInfo = table.Column<string>(nullable: false),
                    GuaranteeName = table.Column<string>(nullable: true),
                    GuaranteeCompany = table.Column<string>(nullable: true),
                    GuaranteePosition = table.Column<string>(nullable: true),
                    GuaranteeNumber = table.Column<string>(nullable: true),
                    OthersInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    MainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_MainInfos_MainInfoId",
                        column: x => x.MainInfoId,
                        principalTable: "MainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniName = table.Column<string>(nullable: false),
                    EducationDate = table.Column<string>(nullable: false),
                    Speciality = table.Column<string>(nullable: false),
                    Degree = table.Column<string>(nullable: false),
                    MainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_MainInfos_MainInfoId",
                        column: x => x.MainInfoId,
                        principalTable: "MainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(nullable: false),
                    WorkedDay = table.Column<string>(nullable: false),
                    WorkedMonth = table.Column<string>(nullable: false),
                    WorkedYear = table.Column<string>(nullable: false),
                    PositionAbout = table.Column<string>(nullable: false),
                    Salary = table.Column<string>(nullable: false),
                    LeftJob = table.Column<string>(nullable: true),
                    WorkNumber = table.Column<string>(nullable: true),
                    MainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_MainInfos_MainInfoId",
                        column: x => x.MainInfoId,
                        principalTable: "MainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languanges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangName = table.Column<string>(nullable: true),
                    Read = table.Column<string>(nullable: true),
                    Write = table.Column<string>(nullable: true),
                    Understood = table.Column<string>(nullable: true),
                    MainInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languanges_MainInfos_MainInfoId",
                        column: x => x.MainInfoId,
                        principalTable: "MainInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_MainInfoId",
                table: "Computers",
                column: "MainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_MainInfoId",
                table: "Educations",
                column: "MainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_MainInfoId",
                table: "Experiences",
                column: "MainInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Languanges_MainInfoId",
                table: "Languanges",
                column: "MainInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Languanges");

            migrationBuilder.DropTable(
                name: "MainInfos");
        }
    }
}

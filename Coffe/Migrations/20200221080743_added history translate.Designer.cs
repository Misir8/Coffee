﻿// <auto-generated />
using System;
using Coffe.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coffe.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200221080743_added history translate")]
    partial class addedhistorytranslate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coffe.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("RuDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "“MY ENTERPRISE” Məhdud Məsuliyyətli Cəmiyyət 2019_cu ildə təsis edilmişdir. Müəssisə hal_hazırda öz fəaliyyət sahəsi istiqamətində, ilkin olaraq, Azərbaycan bazarında əhəmiyyətli yer tutmağı planlaşdırır.	“MY ENTERPRISE” MMC_də coxillik iş təcrübəsinə malik, ixtisaslaşmış işçilər çalışmaqdadır. Əsas fəaliyyət sahəsi isə yerli istehsalat və distribusiyadır (dağıtımdır).",
                            EnDescription = "Englis about",
                            Image = "1.jpg",
                            RuDescription = "На русском"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "pinar70.png",
                            Name = "MyCoffee"
                        },
                        new
                        {
                            Id = 2,
                            Image = "elvan.png",
                            Name = "MyTea"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainInfoId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("Coffe.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Coffe.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ContactInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "<span>Phone : </span>(+994 55) 455 66 88"
                        },
                        new
                        {
                            Id = 2,
                            Info = "<span>Email :</span>Info@myenterprise.az"
                        },
                        new
                        {
                            Id = 3,
                            Info = "<span>Address :</span>AZ5000, Azərbaycan Respublikası, Sumqayıt şəhəri, Sənaye zonası, Sülh küçəsi, 76-cı məhəllə, 106 b"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainInfoId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Coffe.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeftJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainInfoId")
                        .HasColumnType("int");

                    b.Property<string>("PositionAbout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkedDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkedMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkedYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainInfoId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Coffe.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Histories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "2019 - \"MY ENTERPRISE\" MMC fəaliyyətə başlamışdır.Müəssisəmizdə yüksək səviyyəli iş şəraiti, eləcə də davamlı inkişaf üçün böyük potensiallı maddi-texniki baza yaradılmışdır.2019 - Müəssisə ilkin olaraq \"My Coffee\" markasının məhsulları olan \"My Cappuccino\", \"My Original\" çeşidlərini öz alıcılarının istifadəsinə təqdim etdi.2019 Müəssisə il sonunadək \"My Coffee\" markasının digər məhsulları olan \"My Coffee 3in1\", \"My Chocolate\" çeşidlərini öz alıcılarının istifadəsinə təqdim etməyi planlaşdırır.",
                            DescriptionEn = "History",
                            DescriptionRu = "История"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Languange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LangName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Read")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Understood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Write")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainInfoId");

                    b.ToTable("Languanges");
                });

            modelBuilder.Entity("Coffe.Models.MainInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Married")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OthersInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OthersNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionApply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacancyInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isArmy")
                        .HasColumnType("bit");

                    b.Property<bool?>("isCar")
                        .HasColumnType("bit");

                    b.Property<bool?>("isPreviousJob")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MainInfos");
                });

            modelBuilder.Entity("Coffe.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Newses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "“Zeytun yağının keyfiyyətli olmasını necə müəyyən edək?” sualının cavabını, ümumilikdə, dad, qoxu və rəng kimi xüsusiyyətlərə baxaraq tapmağa çalışırıq. Unutmaq olmaz ki, bu xüsusiyyətlərə görə zeytun yağını seçmək aldadıcı ola bilir. Çünki duyğu üzvlərimiz bizi yanılda bilir və yuxarıda qeyd olunanlar təkbaşına keyfiyyət müəyyən edən amil deyildir. Hətta vurğulamaq lazımdır ki, gözümüzün axtardığı o yaşıl zeytun yağı görüntüsü bizi ən çox aldadan faktordur.  Sizin də bugünə qədər “həqiqi zeytun yağı yaşıl olur” fikri ilə seçim etdiyiniz zeytun yağı haqqındakı doğru bilinən bu yanlışa gəlin birlikdə aydınlıq gətirək.",
                            Image = "medium_ag-olan592.png",
                            Title = "Əsl zeytun yağının rəngi necə olmalıdır?"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Dünyaca məşhur türk qəhvəsi brendi olan Kurukahveci Mehmet Efendi 24-26 yanvar tarixlərində keçirilən Bakı qəhvə və çay festivalında iştirak etdi. Festival müddətində iştirakçılar türk qəhvəsinin dadına baxaraq 19-cu əsrdən bəri fəaliyyət göstərən brend haqqında, eləcə də, türk qəhvəsinin hazırlanma qaydası haqqında geniş informasiya əldə etdilər. 1871-ci ildən bu günə qədər qəhvə istehsalına bir incəsənət kimi yanaşan “Kurukahveci Mehmet Efendi” dünyanın bir çox ölkəsində - Asiya, Avropa, Amerika və Avstraliya qitələri daxil ən çox istifadə olunan türk qəhvəsi brendidir.əzərinizə çatdıraq ki, Mehmet Efendi markasının ölkə üzrə rəsmi distribütoru Şam-Fi MMC-dir.",
                            Image = "medium_brokoli-sup-sayt851.png",
                            Title = "Kurukahveci Mehmet Efendi Bakı qəhvə və çay festivalında iştirak etdi"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-1.jpg",
                            Name = "Americano koffee"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-2.jpg",
                            Name = "Vanila Latta"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-4.jpg",
                            Name = "Cappuccino koffee"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "1.jpg",
                            Subtitle = "welcome Our Coffee",
                            Title = "Live Your Life With Energy"
                        },
                        new
                        {
                            Id = 2,
                            Image = "2.jpg",
                            Subtitle = "Demo Subtitle",
                            Title = "Demo Title"
                        });
                });

            modelBuilder.Entity("Coffe.Models.Target", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Targets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "“MY ENTERPRISE” MMC_nin ( müəssisəsinin ) yaradılmasında ən başlıca məqsəd və missiya,yerli məhsulların davamlı istehsalı, xarici bazarlara rəqabət qabiliyyətli məhsullar istehsal edib ixrac etməkdir. Habelə, dünya texnologiya standartlarına əsaslanan yüksək keyfiyyətli məhsullar istehsal edərək, yerli istehsalı gücləndirmək,Azərbaycan bazarında mövcud olan bütün ticarət nöqtələrinə yüksək keyfiyyətli satış xidmətləri göstərərək,tutduğumuz yolda son və ən müasir vasitələrə istinadən, məqsədimizə və missiyamıza çatmaqdır.“MY ENTERPRISE” ailəsi olaraq, yeniliklərə hər zaman açıq olmaq, qloballaşan dünyada rəqabətə davamlı bir şirkət olmaq üçün daima çalışmağın vəən son innovasiyaların tətbiqinin zəruri olduğunu dərk etmək və bu yolda heç bir səylərimizi əsirgəməməkdir.Biz yalnız bazardakı payımızı deyil, ürəklərdəki sevgi payımızı da artıraraq, istehlakçıların rəğbətini qazamağa önəm veririk!Prioritetimiz - Istehlakçıların maraqlarının təminidir!",
                            DescriptionEn = "Purpose and mission english",
                            DescriptionRu = "Цель на русском"
                        });
                });

            modelBuilder.Entity("Coffe.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Coffe.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Biz müştərilərimizə düzgün şəkildə xidmət göstərə bilmək üçün, dürüstük və güclü mənəvi prinsiplərə əsaslanan, işimizi yüksək məsuliyyət hissi ilə görərək, cavabdehlik daşıyan bir yerli müəssisəyik. Bundan başqa dəyərlərimizi yaşatmaqla, inkişafımız və peşəkar fəaliyyətimiz, davranışlarımız, təqdim etdiyimiz məhsul və xidmətlərimizlə nümunəvi olmağı özümüzə vəzifə bilirik. Habelə, daima böyümək, yeni bazarlarda təmsil olunmaq və istehsal etdiyimiz məhsul çeşidlərini artırmaq iqtidarındayıq. Yaradılmış müəsisədə, əhval-ruhiyyənin ən yüksək səviyyədə olması üçün, hər zaman bir-birimizə hörmət və ehtiramla yanaşırıq."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Coffe.Models.Computer", b =>
                {
                    b.HasOne("Coffe.Models.MainInfo", "MainInfo")
                        .WithMany("Computers")
                        .HasForeignKey("MainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coffe.Models.Education", b =>
                {
                    b.HasOne("Coffe.Models.MainInfo", "MainInfo")
                        .WithMany("Educations")
                        .HasForeignKey("MainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coffe.Models.Experience", b =>
                {
                    b.HasOne("Coffe.Models.MainInfo", "MainInfo")
                        .WithMany("Experiences")
                        .HasForeignKey("MainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coffe.Models.Languange", b =>
                {
                    b.HasOne("Coffe.Models.MainInfo", "MainInfo")
                        .WithMany("Languanges")
                        .HasForeignKey("MainInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coffe.Models.Product", b =>
                {
                    b.HasOne("Coffe.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Coffe.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Coffe.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coffe.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Coffe.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

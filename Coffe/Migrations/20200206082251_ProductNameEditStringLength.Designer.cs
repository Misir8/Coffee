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
    [Migration("20200206082251_ProductNameEditStringLength")]
    partial class ProductNameEditStringLength
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
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "“MY ENTERPRISE” Məhdud Məsuliyyətli Cəmiyyət 2019_cu ildə təsis edilmişdir. Müəssisə hal_hazırda öz fəaliyyət sahəsi istiqamətində, ilkin olaraq, Azərbaycan bazarında əhəmiyyətli yer tutmağı planlaşdırır.	“MY ENTERPRISE” MMC_də coxillik iş təcrübəsinə malik, ixtisaslaşmış işçilər çalışmaqdadır. Əsas fəaliyyət sahəsi isə yerli istehsalat və distribusiyadır (dağıtımdır).",
                            Image = "1.jpg",
                            Title = "Biz kimik?"
                        });
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

            modelBuilder.Entity("Coffe.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Histories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "2019 - \"MY ENTERPRISE\" MMC fəaliyyətə başlamışdır.Müəssisəmizdə yüksək səviyyəli iş şəraiti, eləcə də davamlı inkişaf üçün böyük potensiallı maddi-texniki baza yaradılmışdır.2019 - Müəssisə ilkin olaraq \"My Coffee\" markasının məhsulları olan \"My Cappuccino\", \"My Original\" çeşidlərini öz alıcılarının istifadəsinə təqdim etdi.2019 Müəssisə il sonunadək \"My Coffee\" markasının digər məhsulları olan \"My Coffee 3in1\", \"My Chocolate\" çeşidlərini öz alıcılarının istifadəsinə təqdim etməyi planlaşdırır."
                        });
                });

            modelBuilder.Entity("Coffe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-1.jpg",
                            Name = "Americano koffee",
                            Price = 20.0m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-2.jpg",
                            Name = "Vanila Latta",
                            Price = 25.50m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Lorem Ipsum is simply dummy text",
                            Image = "s-4.jpg",
                            Name = "Cappuccino koffee",
                            Price = 20.20m
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

                    b.HasKey("Id");

                    b.ToTable("Targets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "“MY ENTERPRISE” MMC_nin ( müəssisəsinin ) yaradılmasında ən başlıca məqsəd və missiya,yerli məhsulların davamlı istehsalı, xarici bazarlara rəqabət qabiliyyətli məhsullar istehsal edib ixrac etməkdir. Habelə, dünya texnologiya standartlarına əsaslanan yüksək keyfiyyətli məhsullar istehsal edərək, yerli istehsalı gücləndirmək,Azərbaycan bazarında mövcud olan bütün ticarət nöqtələrinə yüksək keyfiyyətli satış xidmətləri göstərərək,tutduğumuz yolda son və ən müasir vasitələrə istinadən, məqsədimizə və missiyamıza çatmaqdır.“MY ENTERPRISE” ailəsi olaraq, yeniliklərə hər zaman açıq olmaq, qloballaşan dünyada rəqabətə davamlı bir şirkət olmaq üçün daima çalışmağın vəən son innovasiyaların tətbiqinin zəruri olduğunu dərk etmək və bu yolda heç bir səylərimizi əsirgəməməkdir.Biz yalnız bazardakı payımızı deyil, ürəklərdəki sevgi payımızı da artıraraq, istehlakçıların rəğbətini qazamağa önəm veririk!Prioritetimiz - Istehlakçıların maraqlarının təminidir!"
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

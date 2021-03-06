﻿using Coffe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coffe.DAL
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Target> Targets { get; set; }

        public DbSet<Value> Values { get; set; }

        public DbSet<MainInfo> MainInfos { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Languange> Languanges { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> Newses { get; set; }
        
        //Seed Data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1, Title = "Live Your Life With Energy", Subtitle = "welcome Our Coffee", Image = "1.jpg"
                },
                new Slider {Id = 2, Title = "Demo Title", Subtitle = "Demo Subtitle", Image = "2.jpg"}
            );

            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo {Id = 1, Info = "<span>Phone : </span>(+994 55) 455 66 88"},
                new ContactInfo {Id = 2, Info = "<span>Email :</span>Info@myenterprise.az"},
                new ContactInfo
                {
                    Id = 3,
                    Info =
                        "<span>Address :</span>AZ5000, Azərbaycan Respublikası, Sumqayıt şəhəri, Sənaye zonası, Sülh küçəsi, 76-cı məhəllə, 106 b"
                }
            );

            modelBuilder.Entity<About>().HasData(
                new About
                {
                    Id = 1,
                    Description =
                        "“MY ENTERPRISE” Məhdud Məsuliyyətli Cəmiyyət 2019_cu ildə təsis edilmişdir. Müəssisə hal_hazırda öz fəaliyyət sahəsi istiqamətində, ilkin olaraq, Azərbaycan bazarında əhəmiyyətli yer tutmağı planlaşdırır.	“MY ENTERPRISE” MMC_də coxillik iş təcrübəsinə malik, ixtisaslaşmış işçilər çalışmaqdadır. Əsas fəaliyyət sahəsi isə yerli istehsalat və distribusiyadır (dağıtımdır).",
                    Image = "1.jpg",
                    EnDescription = "Englis about",
                    RuDescription = "На русском"
                }
            );

            modelBuilder.Entity<History>().HasData(
                new History {Id = 1, Description = "2019 - \"MY ENTERPRISE\" MMC fəaliyyətə başlamışdır.Müəssisəmizdə yüksək səviyyəli iş şəraiti, eləcə də davamlı inkişaf üçün böyük potensiallı maddi-texniki baza yaradılmışdır.2019 - Müəssisə ilkin olaraq \"My Coffee\" markasının məhsulları olan \"My Cappuccino\", \"My Original\" çeşidlərini öz alıcılarının istifadəsinə təqdim etdi.2019 Müəssisə il sonunadək \"My Coffee\" markasının digər məhsulları olan \"My Coffee 3in1\", \"My Chocolate\" çeşidlərini öz alıcılarının istifadəsinə təqdim etməyi planlaşdırır.",
                DescriptionEn = "History", DescriptionRu = "История"}
            );

            modelBuilder.Entity<Category>().HasData(
                new Category{Id = 1, Name = "MyCoffee", Image = "pinar70.png", NameEn = "MyCoffee", NameRu = "Мой кофе"},
                new Category{Id = 2, Name = "MyTea", Image = "elvan.png", NameRu = "Мой чай", NameEn = "MyTea"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Americano koffee",
                    Description = "Lorem Ipsum is simply dummy text",
                    Image = "s-1.jpg",
                    CategoryId = 1, 
                    NameEn = "Product Koffe en",
                    NameRu = "Продукт",
                    DescriptionEn = "English",
                    DescriptionRu = "Рус"
                },
                new Product
                {
                    Id = 2,
                    Name = "Vanila Latta",
                    Description = "Lorem Ipsum is simply dummy text",
                    Image = "s-2.jpg",
                    CategoryId = 1,
                    NameEn = "Product Koffe en",
                    NameRu = "Продукт",
                    DescriptionEn = "English",
                    DescriptionRu = "Рус"
                },
                new Product
                {
                    Id = 3, Name = "Cappuccino koffee",
                    Description = "Lorem Ipsum is simply dummy text",
                    Image = "s-4.jpg",
                    CategoryId = 2,
                    NameEn = "Product Koffe en",
                    NameRu = "Продукт",
                    DescriptionEn = "English",
                    DescriptionRu = "Рус"
                }
            );

            modelBuilder.Entity<Target>().HasData(
                new Target{Id = 1, Description = "“MY ENTERPRISE” MMC_nin ( müəssisəsinin ) yaradılmasında ən başlıca məqsəd və missiya,yerli məhsulların davamlı istehsalı, xarici bazarlara rəqabət qabiliyyətli məhsullar istehsal edib ixrac etməkdir. Habelə, dünya texnologiya standartlarına əsaslanan yüksək keyfiyyətli məhsullar istehsal edərək, yerli istehsalı gücləndirmək,Azərbaycan bazarında mövcud olan bütün ticarət nöqtələrinə yüksək keyfiyyətli satış xidmətləri göstərərək,tutduğumuz yolda son və ən müasir vasitələrə istinadən, məqsədimizə və missiyamıza çatmaqdır.“MY ENTERPRISE” ailəsi olaraq, yeniliklərə hər zaman açıq olmaq, qloballaşan dünyada rəqabətə davamlı bir şirkət olmaq üçün daima çalışmağın vəən son innovasiyaların tətbiqinin zəruri olduğunu dərk etmək və bu yolda heç bir səylərimizi əsirgəməməkdir.Biz yalnız bazardakı payımızı deyil, ürəklərdəki sevgi payımızı da artıraraq, istehlakçıların rəğbətini qazamağa önəm veririk!Prioritetimiz - Istehlakçıların maraqlarının təminidir!",
                DescriptionEn = "Purpose and mission english", DescriptionRu = "Цель на русском"}
            );

            modelBuilder.Entity<Value>().HasData(
                new Value{Id = 1, Description = "Biz müştərilərimizə düzgün şəkildə xidmət göstərə bilmək üçün, dürüstük və güclü mənəvi prinsiplərə əsaslanan, işimizi yüksək məsuliyyət hissi ilə görərək, cavabdehlik daşıyan bir yerli müəssisəyik. Bundan başqa dəyərlərimizi yaşatmaqla, inkişafımız və peşəkar fəaliyyətimiz, davranışlarımız, təqdim etdiyimiz məhsul və xidmətlərimizlə nümunəvi olmağı özümüzə vəzifə bilirik. Habelə, daima böyümək, yeni bazarlarda təmsil olunmaq və istehsal etdiyimiz məhsul çeşidlərini artırmaq iqtidarındayıq. Yaradılmış müəsisədə, əhval-ruhiyyənin ən yüksək səviyyədə olması üçün, hər zaman bir-birimizə hörmət və ehtiramla yanaşırıq.",
                DescriptionEn = "Value", DescriptionRu = "Ценности"}
            );

            modelBuilder.Entity<News>().HasData(
                new News
                {
                    Id = 1, Title = "Əsl zeytun yağının rəngi necə olmalıdır?",
                    Content =
                        "“Zeytun yağının keyfiyyətli olmasını necə müəyyən edək?” sualının cavabını, ümumilikdə, dad, qoxu və rəng kimi xüsusiyyətlərə baxaraq tapmağa çalışırıq. Unutmaq olmaz ki, bu xüsusiyyətlərə görə zeytun yağını seçmək aldadıcı ola bilir. Çünki duyğu üzvlərimiz bizi yanılda bilir və yuxarıda qeyd olunanlar təkbaşına keyfiyyət müəyyən edən amil deyildir. Hətta vurğulamaq lazımdır ki, gözümüzün axtardığı o yaşıl zeytun yağı görüntüsü bizi ən çox aldadan faktordur.  Sizin də bugünə qədər “həqiqi zeytun yağı yaşıl olur” fikri ilə seçim etdiyiniz zeytun yağı haqqındakı doğru bilinən bu yanlışa gəlin birlikdə aydınlıq gətirək.",
                    Image = "medium_ag-olan592.png",
                    TitleEn = "English",
                    TitleRu = "Rus",
                    ContentEn = "English content",
                    ContentRu = "Rus content"
                },
                new News
                {
                    Id = 2, Title = "Kurukahveci Mehmet Efendi Bakı qəhvə və çay festivalında iştirak etdi", Content = "Dünyaca məşhur türk qəhvəsi brendi olan Kurukahveci Mehmet Efendi 24-26 yanvar tarixlərində keçirilən Bakı qəhvə və çay festivalında iştirak etdi. Festival müddətində iştirakçılar türk qəhvəsinin dadına baxaraq 19-cu əsrdən bəri fəaliyyət göstərən brend haqqında, eləcə də, türk qəhvəsinin hazırlanma qaydası haqqında geniş informasiya əldə etdilər. 1871-ci ildən bu günə qədər qəhvə istehsalına bir incəsənət kimi yanaşan “Kurukahveci Mehmet Efendi” dünyanın bir çox ölkəsində - Asiya, Avropa, Amerika və Avstraliya qitələri daxil ən çox istifadə olunan türk qəhvəsi brendidir.əzərinizə çatdıraq ki, Mehmet Efendi markasının ölkə üzrə rəsmi distribütoru Şam-Fi MMC-dir.",
                    Image = "medium_brokoli-sup-sayt851.png",
                    TitleEn = "English",
                    TitleRu = "Rus",
                    ContentEn = "English content",
                    ContentRu = "Rus content"
                }
            );
        }
    }
}
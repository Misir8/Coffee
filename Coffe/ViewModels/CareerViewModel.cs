using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class CareerViewModel
    {
        //MAININFO
        [Required(ErrorMessage = "Zəhmət olmasa ad və atanızın adı xanasın doldurun")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa soyad xanasın doldurun")]
        public string Lastname { get; set; }
        
        //Birth
        [Required]
        public string BirthDay { get; set; }
        [Required]
        public string BirthMonth { get; set; }
        [Required]
        public string BirthYear { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa doğulduğunuz yer xanasın doldurun")]
        public string BirthCity { get; set; }
        //Birth
        
        public bool? isArmy { get; set; }
        public string Married { get; set; }
        
        //contact info
        public string HomeNumber { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mobil əlaqə məlumatı xanasın doldurun")]
        public string MobileNumber { get; set; }
        public string OthersNumber { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa email xanasın doldurun")]
        public string Email { get; set; }
        //contact info
        
        [Required(ErrorMessage = "Zəhmət olmasa yaşadığınız ünvan xanasın doldurun")]
        public string Address { get; set; }
        public string DriverLicense { get; set; }
        public bool? isCar { get; set; }
        public bool? isPreviousJob { get; set; }
        [Required (ErrorMessage = "Zəhmət olmasa hansı vəzifə üçün müraciət edirsiniz xanasın doldurun")]
        public string PositionApply { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vakansiya barədə məlumatı hardan əldə etmisiniz xanasın doldurun")]
        public string VacancyInfo { get; set; }
        
        //guarantee 
        public string GuaranteeName { get; set; }

        public string GuaranteeCompany { get; set; }

        public string GuaranteePosition { get; set; }

        public string GuaranteeNumber { get; set; }
        //guarantee
        public string OthersInfo { get; set; }
        //MAININFO
        
        //EDUCATION
        [Required(ErrorMessage = "Zəhmət olmasa ali təhsil aldığı müəssisə xanasın doldurun")]
        public List<string> EducationUniName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa təhsil müddəti xanasın doldurun")]
        public List<string> EducationDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa ixtisas xanasın doldurun")]
        public List<string> EducationSpeciality { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa dərəcə xanasın doldurun")]
        public List<string> EducationDegree { get; set; }

        public Education Education { get; set; }
        //EDUCATION
        
        //COMPUTER
        [Required(ErrorMessage = "Komputer bilikləri seçin")]
        public List<string> ComputerCourseName { get; set; }
        [Required (ErrorMessage = "Komputer bilikləri səviyyəsin seçin")]
        public List<string> CoumputerDegree { get; set; }

        public Computer Computer { get; set; }
        //COMPUTER
        
        //EXPERIENCE
        
        [Required(ErrorMessage = "Zəhmət olmasa işlədiyiniz müəssənin adın xanasın doldurun")]
        public List<string> ExperienceCompany { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işlədiyiniz müddət xanasın doldurun")]
        public List<string> ExperienceWorkedDay { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işlədiyiniz müddət xanasın doldurun")]
        public List<string> ExperienceWorkedMonth { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işlədiyiniz müddət xanasın doldurun")]
        public List<string> ExperienceWorkedYear { get; set; }
        [Required(ErrorMessage = "Zəhmət vəzifəniz və işiniz haqda qısa təsvir xanasın doldurun")]
        public List<string> ExperiencePositionAbout { get; set; }
        [Required(ErrorMessage = "Zəhmət aldığınız əməkhaqqı xanasın doldurun")]
        public List<string> ExperienceSalary { get; set; }

        public List<string> ExperienceLeftJob { get; set; }
        public List<string> ExperienceWorkNumber { get; set; }

        public Experience Experience { get; set; }
        //EXPERIENCE
        
        //Language
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public List<string> LangName { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public List<string> Read { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public List<string> Write { get; set; }
        [Required(ErrorMessage = "Dil bilikləri bölməsin doldurun")]
        public List<string> Understood { get; set; }

        public Languange Languange { get; set; }
        //Language
        
        
    }
}
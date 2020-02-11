using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Coffe.Models
{
    public class MainInfo
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        
        //Birth
        [Required]
        public string BirthDay { get; set; }
        [Required]
        public string BirthMonth { get; set; }
        [Required]
        public string BirthYear { get; set; }
        [Required]
        public string BirthCity { get; set; }
        //Birth
        
        public bool? isArmy { get; set; }
        public string Married { get; set; }
        
        //contact info
        public string HomeNumber { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public string OthersNumber { get; set; }
        [Required]
        public string Email { get; set; }
        //contact info
        
        [Required]
        public string Address { get; set; }
        public string DriverLicense { get; set; }
        public bool? isCar { get; set; }
        public bool? isPreviousJob { get; set; }
        [Required]
        public string PositionApply { get; set; }
        [Required]
        public string VacancyInfo { get; set; }
        
        //guarantee 
        public string GuaranteeName { get; set; }

        public string GuaranteeCompany { get; set; }

        public string GuaranteePosition { get; set; }

        public string GuaranteeNumber { get; set; }
        //guarantee

        public List<Experience> Experiences { get; set; }
    }
}
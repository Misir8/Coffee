using System.Collections.Generic;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class CareerCRUDViewModel
    {
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Languange> Languanges { get; set; }
        public IEnumerable<MainInfo> MainInfos { get; set; }
        public IEnumerable<Computer> Computers { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public MainInfo MainInfo { get; set; }
    }
}
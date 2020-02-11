using System.Collections.Generic;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class VacancyIndexViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; }
    }
}
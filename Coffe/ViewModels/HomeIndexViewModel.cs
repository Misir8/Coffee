using System.Collections.Generic;
using Coffe.Models;

namespace Coffe.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; }
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<History> Histories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Target> Targets { get; set; }
        public IEnumerable<Value> Values { get; set; }
    }
}
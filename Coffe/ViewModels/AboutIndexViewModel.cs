using System.Collections.Generic;
using Coffe.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coffe.ViewModels
{
    public class AboutIndexViewModel 
    {
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<History> Histories { get; set; }
        public IEnumerable<Value> Values { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; }
    }
}
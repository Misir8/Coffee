using System.Collections.Generic;
using Coffe.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Coffe.ViewModels
{
    public class RegisterViewModelFooter
    {
        public RegisterViewModel RegisterViewModels { get; set; }
        public LoginViewModel LoginViewModel { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; }
    }
}
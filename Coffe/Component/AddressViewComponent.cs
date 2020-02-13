using System.Collections.Generic;
using System.Linq;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffe.Component
{
    public class AddressViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public AddressViewComponent(DataContext context)
        {
            _context = context;
        }
        private List<ContactInfo> GetContact()
        {

            return _context.ContactInfos.ToList();
        }
        public string Invoke()
        {
            return GetContact().ElementAt(2).Info;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffe.Component
{
    public class EmailViewComponent : ViewComponent
    {
        private readonly DataContext _context;

        public EmailViewComponent(DataContext context)
        {
            _context = context;
        }
        private List<ContactInfo> GetContact()
        {

            return _context.ContactInfos.ToList();
        }
        public string Invoke()
        {
            return GetContact().ElementAt(1).Info;
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ContactInfoController : Controller
    {
        private readonly DataContext _context;

        public ContactInfoController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var contactInfos = _context.ContactInfos.ToList();
            return View(contactInfos);
        }
        
        //Edit
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                ContactInfo contactInfo = await _context.ContactInfos.FirstOrDefaultAsync(d => d.Id == id);
                if (contactInfo != null)
                {
                    return View(contactInfo);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContactInfo contactInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(contactInfo);
            }

            var contactDb = await _context.ContactInfos.FindAsync(contactInfo.Id);
            

            contactDb.Info = contactInfo.Info;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Əlaqə məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}
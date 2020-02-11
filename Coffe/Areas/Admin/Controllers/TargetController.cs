using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class TargetController : Controller
    {
        private readonly DataContext _context;

        public TargetController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var targets = _context.Targets.ToList();
            return View(targets);
        }
        
        //EDIT
        
        public async Task <IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                Target target = await _context.Targets.FirstOrDefaultAsync(d => d.Id == id);
                if (target != null)
                {
                    return View(target);
                }
            }
            return NotFound();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Target target)
        {
            if (!ModelState.IsValid)
            {
                return View(target);
            }

            var targetDb = await _context.Targets.FindAsync(target.Id);
            

            targetDb.Description = target.Description;
            await _context.SaveChangesAsync();
            TempData["warning"] = "Məqsəd və missiyamız məlumatı uğurla dəyişdirildi";
            return RedirectToAction(nameof(Index));
        }
    }
}
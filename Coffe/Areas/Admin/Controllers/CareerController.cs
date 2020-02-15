using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CareerController : Controller
    {
        private readonly DataContext _context;

        public CareerController(DataContext context)
        {
            _context = context;
        }
        
        // GET
        public async Task<IActionResult> Index()
        {
            var vm = new CareerCRUDViewModel
            {
                MainInfos = await _context.MainInfos.OrderByDescending(m => m.Id).ToListAsync(),
                Experiences = await  _context.Experiences.ToListAsync(),
                Languanges = await _context.Languanges.ToListAsync(),
                Computers = await _context.Computers.ToListAsync()
            };
            return View(vm);
        }
        
        //Details

        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                var vm = new CareerCRUDViewModel
                {
                    MainInfo = await _context.MainInfos.FirstOrDefaultAsync(m => m.Id == id),
                    Experiences = await _context.Experiences.ToListAsync(),
                    Computers = await _context.Computers.ToListAsync(),
                    Languanges = await _context.Languanges.ToListAsync(),
                    Educations = await _context.Educations.ToListAsync()
                };
                if (vm.MainInfo != null)
                {
                    if(vm.MainInfo.isCar == true)
                    {
                        ViewBag.Car = "Bəli";
                    }
                    else
                    {
                        ViewBag.Car = "Xeyr";
                    }
                    if(vm.MainInfo.isPreviousJob == true)
                    {
                        ViewBag.PrevJob = "Bəli";
                    }
                    else
                    {
                        ViewBag.PrevJob = "Xeyr";
                    }
                    if(vm.MainInfo.isArmy == true)
                    {
                        ViewBag.Army = "Bəli";
                    }
                    else
                    {
                        ViewBag.Army = "Xeyr";
                    }
                    return View(vm);
                }
            }

            return NotFound();
        }
        
        //DELETE 
        public async Task<IActionResult> Delete(int ? id)
        {
            if (id != null)
            {
                var cv = await _context.MainInfos.FirstOrDefaultAsync(m => m.Id == id);
                if (cv != null)
                {
                    return View(cv);
                }
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCV(int ? id)
        {
            if (id != null)
            {
                var cv = await _context.MainInfos.FirstOrDefaultAsync(m => m.Id == id);
                if (cv != null)
                {
                    _context.MainInfos.Remove(cv);
                    await _context.SaveChangesAsync();
                    TempData["danger"] = "CV uğurla silindi";
                    return RedirectToAction(nameof(Index));
                }
            }

            return NotFound();
        }
    }
}
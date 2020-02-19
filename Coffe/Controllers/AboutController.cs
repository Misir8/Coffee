using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataContext _context;

        public AboutController(DataContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            ViewBag.Culture = Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture.Name;
            AboutIndexViewModel vm = new AboutIndexViewModel
            {
                Abouts = _context.Abouts
            };
            return View(vm);
        }

        public async Task<IActionResult> Target()
        {
            var targets = await _context.Targets.ToListAsync();
            return View(targets);
        }

        public async Task<IActionResult> History()
        {
            var histories = await _context.Histories.ToListAsync();
            return View(histories);
        }

        public async Task<IActionResult> Value()
        {
            var values = await _context.Values.ToListAsync();
            return View(values);
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffe.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            ViewBag.Culture = Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture.Name;
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        public async Task<IActionResult> Products(int? id)
        {
            if (id != null)
            {
                var categoryPoduct =
                    await _context.Categories.Include(c => c.Products).FirstOrDefaultAsync(c => c.Id == id);
                
                if (categoryPoduct != null)
                {
                    if (categoryPoduct.Products.Count() == 0)
                    {
                        ViewBag.productCount = "Kateqoriyada məhsul yoxdur";
                    }
                    ViewBag.Culture = Request.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture.Name;
                    return View(categoryPoduct);
                }
            }

            return NotFound();
        }
    }
}
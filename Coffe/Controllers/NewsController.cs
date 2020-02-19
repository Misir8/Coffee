using System.Linq;
using System.Threading.Tasks;
using Coffe.DAL;
using Coffe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace Coffe.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataContext _context;

        public NewsController(DataContext context)
        {
            _context = context;
        }
        // GET
        public async Task<IActionResult> Index(int page = 1)
        {
            var query = _context.Newses.AsNoTracking().OrderByDescending(n => n.Id);
            var model = await PagingList.CreateAsync(query, 8, page);
            return View(model);
        }

        public async Task<IActionResult> Details(int ? id)
        {
            if (id != null)
            {
                NewsViewModel vm = new NewsViewModel
                {
                    Newses = await _context.Newses.OrderByDescending(n => n.Id).Take(4).ToListAsync(),
                    News = await _context.Newses.FirstOrDefaultAsync(n => n.Id == id)
                };
                
                if (vm.News != null)
                {
                    return View(vm);
                }
            }

            return NotFound();
        }


    }
}
using Microsoft.AspNetCore.Mvc;

namespace Coffe.Controllers
{
    public class NewsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
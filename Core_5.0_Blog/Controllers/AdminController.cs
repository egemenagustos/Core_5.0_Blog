using Microsoft.AspNetCore.Mvc;

namespace Core_5._0_Blog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminNavbar()
        {
            return PartialView();
        }
    }
}

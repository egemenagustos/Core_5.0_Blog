using Core_5._0_Blog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core_5._0_Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> categories = new List<CategoryClass>();
            categories.Add(new CategoryClass()
            {
                categorycount= 10,
                categoryname="Teknoloji"
            });
            categories.Add(new CategoryClass()
            {
                categorycount = 14,
                categoryname = "Yazılım"
            });
            categories.Add(new CategoryClass()
            {
                categorycount = 5,
                categoryname = "Spor"
            });
            return Json(categories);
        }
    }
}

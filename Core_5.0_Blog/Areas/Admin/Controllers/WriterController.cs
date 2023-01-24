using Core_5._0_Blog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Core_5._0_Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetWriterById(int writerid)
        {
            var findwriter = writers.FirstOrDefault(x => x.ID == writerid);
            var jsonconvert = JsonConvert.SerializeObject(findwriter);
            return Json(jsonconvert);
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x=>x.ID== w.ID);
            writer.Name = w.Name;
            var jsonconvert = JsonConvert.SerializeObject(writer);
            return Json(jsonconvert);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonconvert = JsonConvert.SerializeObject(w);
            return Json(jsonconvert);
        }

        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.ID == id);
            writers.Remove(writer);
            return Json(writer);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                ID= 1,
                Name="Ayşe"
            },
            new WriterClass
            {
                ID= 2,
                Name="Ahmet"
            },
            new WriterClass
            {
                ID= 3,
                Name="Egemen"
            }
        };
    }
}

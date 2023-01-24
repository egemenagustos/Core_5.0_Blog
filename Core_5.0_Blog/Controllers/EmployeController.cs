using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace Core_5._0_Blog.Controllers
{
    public class EmployeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var htppclient = new HttpClient();
            var responese = await htppclient.GetAsync("https://localhost:44388/api/Default/");
            var jsonstring = await responese.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<test>>(jsonstring);
            return View(values);
        }

        public IActionResult AddEmploye()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmploye(test p)
        {
            var htppclient = new HttpClient();
            var jsonemploye = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonemploye, encoding: System.Text.Encoding.UTF8, "application/json");
            var responsemessage = await htppclient.PostAsync("https://localhost:44388/api/Default/",content);
            if(responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);

        }

        [HttpGet]
        public async Task<IActionResult> EditEmploye(int id)
        {
            var htppclient = new HttpClient();
            var responsemessage = await htppclient.GetAsync("https://localhost:44388/api/Default/" + id);
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsonemploye = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<test>(jsonemploye);
                return View(values);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditEmploye(test p)
        {
            var htppclient = new HttpClient();
            var jsonEmploye = JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmploye, encoding: System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await htppclient.PutAsync("https://localhost:44388/api/Default/", content);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public async Task<IActionResult> DeleteEmploye(int id)
        {
            var htppclient = new HttpClient();
            var responsemessage = await htppclient.DeleteAsync("https://localhost:44388/api/Default/" + id);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public class test
        {           
            public int ID { get; set; }

            public string Name { get; set; }
        }
    }
}

using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employes.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeAdd(Employe p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult EmployeGet(int id)
        {
            using var c = new Context();
            var employe = c.Employes.Find(id);
            if(employe == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employe);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeDelete(int id)
        {
            using var c = new Context();
            var employe = c.Employes.Find(id);
            if(employe == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employe);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult EmployeUpdate(Employe p)
        {
            using var c = new Context();
            var employe = c.Find<Employe>(p.ID);
            if (employe == null)
            {
                return NotFound();
            }
            else
            {
                employe.Name = p.Name;
                c.Update(employe);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}

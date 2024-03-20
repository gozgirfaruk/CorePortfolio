using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceMenager experience= new ExperienceMenager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experience.GetList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values =experience.GetById(id);
            experience.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExp(int id)
        {
            var values = experience.GetById(id);
            return View(values);
        }

        [HttpPost] 
        public IActionResult UpdateExp(Experience exp)
        {
            experience.TUpdate(exp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddExp() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExp(Experience exp)
        {
            experience.TAdd(exp);
            return RedirectToAction("Index");
        }
    }
}

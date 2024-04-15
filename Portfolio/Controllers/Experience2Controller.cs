using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceMenager menager = new ExperienceMenager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(menager.GetList());
            return View(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            menager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);

        }

        public IActionResult GetByID(int id)
        {
            var values = menager.GetById(id);
            var val =JsonConvert.SerializeObject(values);
            return View(val);
        }

    }
}

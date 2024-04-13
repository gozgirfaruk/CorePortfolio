using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class TestimonialController : Controller
    {
        ReferanceMenager menager = new ReferanceMenager(new EfReferanceDal());
        public IActionResult Index()
        {
            var valeus = menager.GetList();
            return View(valeus);
        }

        public IActionResult Delete(int id)
        {
            menager.TDelete(menager.GetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(menager.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Referance r)
        {
            menager.TUpdate(r);
            return RedirectToAction("Index");
        }
    }
}

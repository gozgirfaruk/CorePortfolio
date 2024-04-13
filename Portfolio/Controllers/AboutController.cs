using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class AboutController : Controller
    {
        AboutMenager aboutMenager = new AboutMenager(new EfAboutDal());

		[HttpGet]
        public IActionResult Index()
        {
            
            var values = aboutMenager.GetById(2);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutMenager.TUpdate(about);
            return RedirectToAction("Index","Default");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMenager socialMenager = new SocialMenager(new EfSocialDal());
        public IActionResult Index()
        {
            
            return View(socialMenager.GetList());
        }

        public IActionResult Delete(int id)
        {
            socialMenager.TDelete(socialMenager.GetById(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            return View(socialMenager.GetById(id));
        }

        [HttpPost]
        public IActionResult Detail(Social social)
        {
            socialMenager.TUpdate(social);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Social social)
        {
            social.Status = true;
            socialMenager.TAdd(social);
            return RedirectToAction("Index");
        }
    }
}

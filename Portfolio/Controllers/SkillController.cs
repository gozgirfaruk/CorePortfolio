using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class SkillController : Controller
    {
        SkillMenager m_SkillMenager = new SkillMenager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.a = "Yetenek Listesi";
            ViewBag.b = "Yetenekler";
            ViewBag.c = "Yetenek Listesi";
            var values = m_SkillMenager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.a = "Yetenek Ekleme";
            ViewBag.b = "Yetenekler";
            ViewBag.c = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            m_SkillMenager.TAdd(skill);
            return RedirectToAction("Index");
        }
    }
}

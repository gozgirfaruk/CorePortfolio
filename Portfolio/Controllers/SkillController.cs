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
            var values = m_SkillMenager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skill.SkillImage = "#";
            m_SkillMenager.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = m_SkillMenager.GetById(id);
            m_SkillMenager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = m_SkillMenager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skill.SkillImage = "#";
            m_SkillMenager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}

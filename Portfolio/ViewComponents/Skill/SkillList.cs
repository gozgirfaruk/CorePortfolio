using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillMenager skillMenager = new SkillMenager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillMenager.GetList();
            return View(values);
        }
    }
}

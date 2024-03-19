using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceMenager menager =new ExperienceMenager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = menager.GetList();
            return View(values);
        }
    }
}

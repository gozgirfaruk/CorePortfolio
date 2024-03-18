using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutMenager aboutMenager = new AboutMenager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutMenager.GetList();
            return View(values);
        }
    }
}

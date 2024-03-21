using Microsoft.AspNetCore.Mvc;
using Potfolio.DataAccess.Concrete;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class FeatureStatistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.one = c.Skills.Count();
            ViewBag.two=c.Contacts.Where(x=>x.Status==false).Count();
            ViewBag.three=c.Contacts.Where(x=>x.Status==true).Count();
            ViewBag.four=c.Experiences.Count();
            return View();
        }
    }
}

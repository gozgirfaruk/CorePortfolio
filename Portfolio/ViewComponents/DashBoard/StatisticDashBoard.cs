using Microsoft.AspNetCore.Mvc;
using Potfolio.DataAccess.Concrete;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class StatisticDashBoard : ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.one = c.Projects.Count();
            ViewBag.two = c.Contacts.Count();
            ViewBag.three= c.Services.Count();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementMenager announcement= new AnnouncementMenager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcement.GetList().Take(4).ToList();
            return View(values);
        }
    }
}

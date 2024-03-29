using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementMenager announcement = new AnnouncementMenager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcement.GetList();
            return View(values);
        }

        public IActionResult announcementDetail(int id)
        {

            Announcement anc = announcement.GetById(id); 
            return View(anc);    
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class DefaultController : Controller
    {
        ContactMenager m_contactMenager = new ContactMenager(new EfContactDal());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            contact.Status = true;
            m_contactMenager.TAdd(contact);
            return PartialView();
        }
    }
}

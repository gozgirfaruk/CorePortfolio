using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class ContactController : Controller
    {
        ContactMenager contactMenager = new ContactMenager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactMenager.GetList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var values = contactMenager.GetById(id);
            contactMenager.TDelete(values);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var values = contactMenager.GetById(id);
            values.Status = true;
            contactMenager.TUpdate(values);
            return View(values);
        }
    }
}

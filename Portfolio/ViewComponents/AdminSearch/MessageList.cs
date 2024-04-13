using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.AdminSearch
{
    public class MessageList : ViewComponent
    {
        ContactMenager contactMenager = new ContactMenager(new EfContactDal());
        public IViewComponentResult Invoke()
        {

            var values = contactMenager.GetList().Take(3).ToList();
            return View(values);
        }
    }
}

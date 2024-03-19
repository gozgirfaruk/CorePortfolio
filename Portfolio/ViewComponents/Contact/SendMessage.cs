using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        ContactMenager m_contactMenager = new ContactMenager(new EfContactDal());

       
        public IViewComponentResult Invoke()
        {
            return View();
        }
       

    }
}

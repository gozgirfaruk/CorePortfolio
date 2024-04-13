using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.Concrete;
using Potfolio.DataAccess.EntityFramework;
using System.Security.Cryptography.Xml;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class ContactList : ViewComponent
    {
        //ContactMenager contactMenager= new ContactMenager(new EfContactDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.UserMessages.Include(x => x.UserSys).ToList();
            //var values = contactMenager.GetList();  
            return View(values);
        }
    }
}

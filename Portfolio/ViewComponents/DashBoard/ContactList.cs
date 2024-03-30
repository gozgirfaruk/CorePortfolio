using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;
using System.Security.Cryptography.Xml;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class ContactList : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}

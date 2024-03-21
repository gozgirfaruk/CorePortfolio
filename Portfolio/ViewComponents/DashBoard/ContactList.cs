using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;
using System.Security.Cryptography.Xml;

namespace Portfolio.UI.ViewComponents.DashBoard
{
    public class ContactList : ViewComponent
    {
        UserMessageMenager _userMessageMenager=new UserMessageMenager(new EfUserMessageMenager());
        public IViewComponentResult Invoke()
        {
            var values = _userMessageMenager.UserMessageWithUser();
            return View(values);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Contact
{
    public class Address : ViewComponent
    {
        AddressMenager menager = new AddressMenager(new EfAddressDal());
        public IViewComponentResult Invoke()
        {
            var values = menager.GetList();
            return View(values);
        }
    }
}

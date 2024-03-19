using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Referance
{
    public class ReferanceList : ViewComponent
    {
        ReferanceMenager menager = new ReferanceMenager(new EfReferanceDal());
        public IViewComponentResult Invoke()
        {
            var values = menager.GetList();
            return View(values);
        }
    }
}

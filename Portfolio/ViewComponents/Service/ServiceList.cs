using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    { 
        ServiceMenager serviceMenager=new ServiceMenager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceMenager.GetList();
            return View(values);
        }
    }
}
